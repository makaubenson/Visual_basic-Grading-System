Imports System.Data.OleDb

Public Class database

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    Dim datafile As String = "E:\school\vb code\class\studentdatabase.accdb"
    Dim constring As String = provider & datafile
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim str As String
    Dim i As Integer
    Dim state As String
    Dim id As Integer


    Private Sub database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            myconnection.ConnectionString = constring
            myconnection.Open()

            str = "Select * from students"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
            cmd.Connection = myconnection
            cmd.CommandText = str
            Dim datatable As New DataTable
            Dim databaseadapter As New OleDb.OleDbDataAdapter
            databaseadapter.SelectCommand = cmd

            databaseadapter.Fill(datatable)
            DataGridmain.DataSource = datatable
            myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebtn.Click

        myconnection.Open()

        If (deleteid.Text <> "") Then
            Try
                Try
                    id = CInt(deleteid.Text)

                    state = "valid"


                Catch ex As Exception
                    MessageBox.Show("YOU Did Not Enter A NUMBER", "input error")

                End Try


                If (state = "valid") Then

                    str = "Delete from students WHERE studentID = "

                    Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
                    cmd.Connection = myconnection
                    cmd.CommandText = str

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Record has been deleted successfully!")
                        state = "invalid"

                    Else
                        MsgBox("No record has been deleted!")
                        state = "invalid"
                    End If

                End If





            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            myconnection.Close()

        Else
            MessageBox.Show("PLEASE INPUT A STUDENT ID TO DELETE", "error")
        End If
        myconnection.Close()


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        project.Show()

    End Sub

    Private Sub DataGridmain_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridmain.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            myconnection.ConnectionString = constring
            myconnection.Open()

            str = "Select * from students"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
            cmd.Connection = myconnection
            cmd.CommandText = str
            Dim datatable As New DataTable
            Dim databaseadapter As New OleDb.OleDbDataAdapter
            databaseadapter.SelectCommand = cmd

            databaseadapter.Fill(datatable)
            DataGridmain.DataSource = datatable
            myconnection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class