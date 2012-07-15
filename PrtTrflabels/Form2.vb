Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrfPrtLabelsDataSet.labels_prt' table. You can move, or remove it, as needed.
        Me.labels_prtTableAdapter.Fill(Me.TrfPrtLabelsDataSet.labels_prt)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class