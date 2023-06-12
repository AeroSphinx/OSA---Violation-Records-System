Imports System.Data.OleDb
Imports System.Data
' Created by SharpDevelop.
' User: Twinkle
' Date: 29/05/2023
' Time: 9:04 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class InsertNewData
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
	
	Sub BtnInsertDataClick(sender As Object, e As EventArgs)
		
		If MessageBox.Show("Do you want to insert a new data?", "Insert New Data",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
			
			con = New OleDbConnection(conStr)
			con.Open
			Dim da As OleDbDataAdapter = New OleDbDataAdapter
			da.InsertCommand = New OleDbCommand("INSERT INTO [Personal Information] ([Name of the Student], [Grade], [Strand], [Section], [Adviser], [Violation], [Date], [Room Number], [Parent's Contact Number]) " & _
            "VALUES(?,?,?,?,?,?,?,?,?);", con)

            da.InsertCommand.Parameters.AddWithValue("[Name of the Student]", txtStudent.Text)
            da.InsertCommand.Parameters.AddWithValue("[Grade]", cmbGrdLvl.Text)
            da.InsertCommand.Parameters.AddWithValue("[Strand]", txtStrand.Text)
            da.InsertCommand.Parameters.AddWithValue("[Section]", txtSection.Text)
            da.InsertCommand.Parameters.AddWithValue("[Adviser]", txtAdviser.Text)
            da.InsertCommand.Parameters.AddWithValue("[Violation]", cmbViolation.Text)
            da.InsertCommand.Parameters.AddWithValue("[Date]", txtDate.Text)
            da.InsertCommand.Parameters.AddWithValue("[Room Number]", txtRoomNumber.Text)
            da.InsertCommand.Parameters.AddWithValue("[Parent's Contact Number]", txtParContactNo.Text)
			da.InsertCommand.ExecuteNonQuery
			MsgBox("New Data Inserted!", vbExclamation, "Successfully Inserted")
			
			con.Close
			btnClrViolationFormClick(sender, e)
		Else 
			
		End if
		
	End Sub
	
	
	Sub BtnClrViolationFormClick(sender As Object, e As EventArgs)
		listView1.Items.Clear
		dataGridView1.DataSource = Nothing
        dataGridView1.Refresh
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
	
End Class
