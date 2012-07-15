Imports System.Data.SQLite
Imports System.IO
Imports System.Deployment.Application

Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        versionLabel.Text = "v " & My.Application.Info.Version.ToString

        Dim mydocdir As String
        mydocdir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        mydocdir = mydocdir + "\.trflabels\"
        'Console.WriteLine(mydocdir)
        'Try
        If Not (Directory.Exists(mydocdir)) Then
            Directory.CreateDirectory(mydocdir)
        End If

        'Console.WriteLine("Directories created")
        'Catch E As Exception
        'Console.WriteLine("Error creating directory")
        'Console.WriteLine("Error: {0}", e.Message)
        'End Try

        'MsgBox(mydocdir)
        Dim sqlfilename As String

        sqlfilename = mydocdir + "TrfPrtLabels.s3db"
        If Not File.Exists(sqlfilename) Then
            'Create Database
            Dim Cr8SQLconnect As New SQLite.SQLiteConnection()
            'Database Doesn't Exist so Created at Path
            Cr8SQLconnect.ConnectionString = "Data Source=" & sqlfilename & ";"
            Cr8SQLconnect.Open()
            Cr8SQLconnect.Close()

            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & sqlfilename & ";"
            SQLconnect.Open()

            'SQL query to Create Table
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "CREATE TABLE trf_items(item_code text PRIMARY KEY , prt_label text , prt_line1 text , prt_line2 text , prt_count integer);"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()

            'SQL query to Create Table
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "CREATE TABLE labels_prt(prt_label text , prt_line1 text , prt_line2 text);"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()

            'SQL query to Create Table
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "CREATE TABLE integers(i integer PRIMARY KEY);"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()

            Dim i As Integer
            For i = 1 To 1000
                SQLcommand = SQLconnect.CreateCommand
                SQLcommand.CommandText = "INSERT into integers (i) values (" & i & ");"
                SQLcommand.ExecuteNonQuery()
                SQLcommand.Dispose()
            Next

            SQLconnect.Close()
        Else
            Dim SQLconnect As New SQLite.SQLiteConnection()
            Dim SQLcommand As SQLiteCommand
            SQLconnect.ConnectionString = "Data Source=" & sqlfilename & ";"
            SQLconnect.Open()

            'SQL query to update Table
            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandText = "update trf_items set prt_count = 0 ;"
            SQLcommand.ExecuteNonQuery()
            SQLcommand.Dispose()
            'MsgBox("2")
            SQLconnect.Close()

        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        'insert into prt_lbls (prt_label) 
        'select trf_items.prt_label from trf_items 
        'inner join integers on integers.i between 1 and trf_items.prt_count ;
    End Sub
End Class