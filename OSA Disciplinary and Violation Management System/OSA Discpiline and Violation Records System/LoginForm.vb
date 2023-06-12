Imports System.Data.OleDb
Imports System.Data
' Created by SharpDevelop.
' User: Twinkle
' Date: 25/05/2023
' Time: 3:42 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class LoginForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnLogInClick(sender As Object, e As EventArgs)
		
		If txtUsername.Text = "AeroSphinx" And txtPassword.Text = "Credacious" Then
			Me.Hide
			MainForm.Show
		ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
			MsgBox("Please Enter your Username and Passsword.")
		Else
			MsgBox("Incorrect username or password. Please try again.", MsgBoxStyle.Critical)
			
		End If
		
	End Sub
	
	
	Sub BtnlogExitClick(sender As Object, e As EventArgs)
		End
	End Sub
	
	Sub PcbCloseLoginClick(sender As Object, e As EventArgs)
		End
	End Sub
	
	Sub Panel1Paint(sender As Object, e As PaintEventArgs)
		
	End Sub
End Class
