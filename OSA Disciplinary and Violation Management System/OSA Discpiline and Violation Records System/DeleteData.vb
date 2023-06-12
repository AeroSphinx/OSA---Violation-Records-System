Imports System.Data.OleDb
Imports System.Data
' Created by SharpDevelop.
' User: Twinkle
' Date: 29/05/2023
' Time: 9:40 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class DeleteData
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnPopViolationFormClick(sender As Object, e As EventArgs)
		con = New OleDbConnection(conStr)
		con.Open 
		
		Dim dt As New DataTable 
		Dim da As New OleDbDataAdapter("SELECT * FROM [Personal Information];", con)
		da.Fill(dt)
		
		For Each row As DataRow In dt.Rows
			Dim Item As New ListViewItem(row(0).ToString())
			Item.SubItems.Add(row(1).ToString())
			Item.SubItems.Add(row(2).ToString())
			Item.SubItems.Add(row(3).ToString())
			Item.SubItems.Add(row(4).ToString())
			Item.SubItems.Add(row(5).ToString())
			Item.SubItems.Add(row(6).ToString())
			Item.SubItems.Add(row(7).ToString())
			Item.SubItems.Add(row(8).ToString())
			Item.SubItems.Add(row(9).ToString())
			listView1.Items.Add(Item)
		Next
		dataGridView1.DataSource = dt.DefaultView
		con.Close
	End Sub
	
	Sub BtnClrViolationFormClick(sender As Object, e As EventArgs)
		listView1.Items.Clear
		dataGridView1.DataSource = Nothing
        dataGridView1.Refresh
	End Sub
	
	Sub BtnCheckClick(sender As Object, e As EventArgs)
		con = New OleDbConnection (conStr)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter ("SELECT * FROM [Personal Information] WHERE [ID] = ? ;",con)
        da.SelectCommand.Parameters.Add("?",OleDbType.VarChar).Value = txtSearchID.Text
        da.Fill(dt)
        
        If dt.Rows.Count = 0 Then 'pag walang nahanap
        MsgBox ("No data found!",vbExclamation, "Warning!") 
        Else 'pag may nahanap na data
        for Each row As DataRow In dt.Rows
        txtStudent.Text = row("Name of the Student").ToString
		cmbGrdLvl.Text = row("Grade").ToString
		txtStrand.Text = row("Strand").ToString
		txtSection.Text = row("Section").ToString
		txtAdviser.Text = row("Adviser").ToString
		cmbViolation.Text = row("Violation").ToString
		txtDate.Text = row("Date").ToString
		txtRoomNumber.Text = row("Room Number").ToString
		txtParContactNo.Text = row("Parent's Contact Number").ToString
		Next
		End if
	End Sub
	
	Sub BtnClearClick(sender As Object, e As EventArgs)
		txtStudent.Text = ""
		cmbGrdLvl.Text = ""
		txtStrand.Text = ""
		txtSection.Text = ""
		txtAdviser.Text = ""
		cmbViolation.Text = ""
		txtDate.Text = ""
		txtRoomNumber.Text = ""
		txtParContactNo.Text = ""
	End Sub
	
	Sub BtnDeleteClick(sender As Object, e As EventArgs)
		If txtSearchID.text = Nothing Then
			MsgBox("No ID search bar! ",vbInformation,"Warning!")
			Exit Sub
		End If
		If MsgBox("Do you want to delete the data?" ,MsgBoxStyle.YesNo) =MsgBoxResult.Yes Then
			con =New OleDbConnection(conStr)			
			Dim cmd  =New OleDbCommand("DELETE FROM [Personal Information] Where ID = " &CInt(txtSearchID.Text)& " ;",con)
			con.Open
			cmd.ExecuteNonQuery
			MsgBox("Data has been deleted! " ,vbExclamation, "Warning!")
			con.Close
			End If
	End Sub
End Class
