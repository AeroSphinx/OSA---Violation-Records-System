'
' Created by SharpDevelop.
' User: Twinkle
' Date: 29/05/2023
' Time: 9:18 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data.OleDb
Imports System.Data
Public Partial Class SearchData
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnSearchClick(sender As Object, e As EventArgs)
		con = New OleDbConnection(conStr)
		con.Open
		Dim dt As New DataTable
		Dim da As New OleDbDataAdapter("SELECT * FROM [Personal Information] WHERE [Name of the Student] LIKE ? AND [Grade] LIKE ? AND [Violation] = ? ;", con)
		da.SelectCommand.Parameters.AddWithValue("Name of the Student", txtSearch. Text & "%")
		da.SelectCommand.Parameters.AddWithValue("Grade", comboBox3.Text)
		da.SelectCommand.Parameters.AddWithValue("Violation", comboBox4.Text)
		da.Fill(dt)
		
		For Each row As DataRow In dt.Rows 
			Dim item As ListViewItem = New ListViewItem(row(0).ToString())
			item.SubItems.Add(row(1).ToString()) 
			item.SubItems.Add(row(2).ToString())
			item.SubItems.Add(row(3).ToString()) 
			item.SubItems.Add(row(4).ToString())
			item.SubItems.Add(row(5).ToString())
			item.SubItems.Add(row(6).ToString())
			item.SubItems.Add(row(7).ToString())
			item.SubItems.Add(row(8).ToString())
			item.SubItems.Add(row(9).ToString())
			listView1.Items.Add(item)
			con.Close
		Next
		dataGridView1.DataSource = dt.DefaultView
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
		txtSearch.Text = ""
	End Sub
	
	Sub BtnApplyFilterClick(sender As Object, e As EventArgs)
		con = New OleDbConnection(conStr) 
		Dim dt As New DataTable
		Dim da As New OleDbDataAdapter("SELECT * FROM [Personal Information] WHERE [Name of the Student] LIKE ? ;",con)
		da.SelectCommand.Parameters.AddWithValue("?", txtSearch.Text & "%")
		da.Fill(dt)
		
		For Each row As DataRow In dt.Rows 
			Dim item As ListViewItem = New ListViewItem(row(0).ToString())
			item.SubItems.Add(row(1).ToString()) 
			item.SubItems.Add(row(2).ToString())
			item.SubItems.Add(row(3).ToString()) 
			item.SubItems.Add(row(4).ToString())
			item.SubItems.Add(row(5).ToString())
			item.SubItems.Add(row(6).ToString())
			item.SubItems.Add(row(7).ToString())
			item.SubItems.Add(row(8).ToString())
			item.SubItems.Add(row(9).ToString())
			listView1.Items.Add(item)
		Next
		dataGridView1.DataSource = dt.DefaultView
	End Sub
End Class
