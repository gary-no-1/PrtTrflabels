Imports System.Data.SQLite
Public Class Form1

    Private Sub Trf_itemsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Trf_itemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Trf_itemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TrfPrtLabelsDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mydocdir As String
        mydocdir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        mydocdir = mydocdir + "\.trflabels\"
        Dim sqlfilename As String
        sqlfilename = mydocdir + "TrfPrtLabels.s3db"

        My.MySettings.Default("TrfPrtLabelsConnectionString") = "data source=" & sqlfilename

        'TODO: This line of code loads data into the 'TrfPrtLabelsDataSet.trf_items' table. You can move, or remove it, as needed.
        Me.Trf_itemsTableAdapter.Fill(Me.TrfPrtLabelsDataSet.trf_items)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        Dim mydocdir As String
        mydocdir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        mydocdir = mydocdir + "\.trflabels\"
        Dim sqlfilename As String
        sqlfilename = mydocdir + "TrfPrtLabels.s3db"
        Dim SQLconnect As New SQLite.SQLiteConnection()
        Dim SQLcommand As SQLiteCommand
        SQLconnect.ConnectionString = "Data Source=" & sqlfilename & ";"
        SQLconnect.Open()

        'SQL query to delete all records in labels_prt
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "delete from labels_prt ;"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()

        'SQL query to insert labels for printing
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandText = "insert into labels_prt (prt_line1, prt_line2) " & _
            "select trf_items.prt_line1 , trf_items.prt_line2 from trf_items " & _
            "inner join integers on integers.i between 1 and trf_items.prt_count ;"
        SQLcommand.ExecuteNonQuery()
        SQLcommand.Dispose()
        SQLconnect.Close()

        Form2.Show()
    End Sub

    Private Sub Trf_itemsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Trf_itemsDataGridView.CellContentClick

    End Sub
End Class