Imports System.Data.OleDb
'Imports System.Data.SqlClient
Public Class Form1
    Dim Con As OleDbConnection
    Dim Com As OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Con As OleDbConnection = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Dim Com As OleDbCommand = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "insert into Stu values(" & txtd.Text & ",'" & txtName.Text & "','" & txtFName.Text & "','" & txtMob.Text & "')"
        Com.ExecuteNonQuery()
        MessageBox.Show("The record is inserted!")
        Con.Dispose()
        Com.Dispose()
        txtId.Text = ""
        txtName.Text = ""
        txtFName.Text = ""
        txtMob.Text = ""
        txtId.Focus()
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim Oad As OleDbDataAdapter = New OleDbDataAdapter("select * from Stu", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb")
        Dim Osal As DataSet = New DataSet()
        Oad.Fill(Osal)
        DGlist.DataSource = Osal.Tables(0)
        Oad.Dispose()
        Osal.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Com = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "select * from Stu"
        Dim oread As OleDbDataReader = Com.ExecuteReader()
        While (oread.Read() = True)
            cmbIdUpdate.Items.Add(oread("StuId").ToString())
            'cmbId.Items.Add(oread("0").ToString())
        End While
        Con.Dispose()
        Com.Dispose()
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Con = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Com = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "delete from Stu where StuId=" & cmbId.Text & ""
        Com.ExecuteNonQuery()
        Com.Dispose()
        Con.Dispose()
        MessageBox.Show("the record is deleted!")
        cmbId.Items.RemoveAt(cmbId.SelectedIndex)
        cmbId.Text = ""
    End Sub

    Private Sub CmbIdUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdUpdate.SelectedIndexChanged
        Con = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Com = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "select Name,Fname,Mob from Stu where StuId=" & cmbIdUpdate.Text & ""
        Dim oread As OleDbDataReader = Com.ExecuteReader()
        'oread.Read()
        If (oread.Read() = True) Then
            txtNameUpdate.Text = oread("Name").ToString()
            txtFNameupdate.Text = oread("Fname").ToString()
            txtMarkUpdate.Text = oread("Mob").ToString()
        End If
        Con.Dispose()
        Com.Dispose()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Con = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Com = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "update Stu Set Name='" & txtNameUpdate.Text & "',Fname='" & txtFNameupdate.Text & "',Mob='" & txtMarkUpdate.Text & "'where StuId=" & cmbIdUpdate.Text & ""
        Com.ExecuteNonQuery()
        MessageBox.Show("Record is updated!!")
        Con.Dispose()
        Com.Dispose()
    End Sub
    'this is delete btn's code >>>>>>>>>>>>>>>>>
    Private Sub CmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbId.SelectedIndexChanged
        Con = New OleDbConnection()
        Con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Databases\BCA.accdb"
        Con.Open()
        Com = New OleDbCommand()
        Com.Connection = Con
        Com.CommandText = "select * from Stu"
        Dim oread As OleDbDataReader = Com.ExecuteReader()
        While (oread.Read() = True)
            cmbIdUpdate.Items.Add(oread("StuId").ToString())
            'cmbId.Items.Add(oread("0").ToString())
        End While
        Con.Dispose()
        Com.Dispose()
    End Sub

    Private Sub CmbId_MouseEnter(sender As Object, e As EventArgs) Handles cmbId.MouseEnter

    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
End Class


