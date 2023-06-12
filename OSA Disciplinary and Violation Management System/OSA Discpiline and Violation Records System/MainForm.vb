Imports System.Data.OleDb
Imports System.Data
' Created by SharpDevelop.
' User: Twinkle
' Date: 25/05/2023
' Time: 3:41 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Private InsertNewDataForm As InsertNewData
	
	Sub PcbMenuIconClick(sender As Object, e As EventArgs)
		 If panelMenu.Width > 60 Then 
            TimerPanelDecrease.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
            
        End If

	End Sub
	
	Sub TimerPanelIncreaseTick(sender As Object, e As EventArgs)
          If panelMenu.Width < 200 Then
            panelMenu.Width += 5
        Else
            TimerPanelIncrease.Enabled = False
        End If
		
	End Sub
	
	Sub TimerPanelDecreaseTick(sender As Object, e As EventArgs)
		  If panelMenu.Width  > 60 Then
            panelMenu.Width -= 5
        Else
            TimerPanelDecrease.Enabled = False
        End If

	End Sub
	
	Sub PanelMenuSizeChanged(sender As Object, e As EventArgs)
		If panelMenu.Width < 85 Then
			btnHomePage.Text = ""
            btnInsertNewData.Text = ""
            btnSearchData.Text = ""
            btnUpdateData.Text = ""
            btnDeleteData.Text = ""
            btnExit.Text = ""
            pcbLogo.Hide
		Else
			btnHomePage.Text = "Home Page"
            btnInsertNewData.Text = "Insert Data"
            btnSearchData.Text = "Search Data"
            btnUpdateData.Text = "Update Data"
            btnDeleteData.Text = "Delete Data"
            btnExit.Text = "Exit"
            pcbLogo.Show
         End If

	End Sub
	
	Sub switchPanel (ByVal panel As Form)
		pnlTransition.Controls.Clear
		panel.TopLevel = False
		pnlTransition.Controls.Add(panel)
		panel.Show
	End Sub
	
	Sub BtnHomePageClick(sender As Object, e As EventArgs)
	    switchPanel(Home_Page)
	End Sub
	
	Sub BtnInsertNewDataClick(sender As Object, e As EventArgs)
		switchPanel(InsertNewData)
	End Sub
	
	Sub BtnSearchDataClick(sender As Object, e As EventArgs)
		switchPanel(SearchData)
	End Sub
	
	Sub BtnUpdateDataClick(sender As Object, e As EventArgs)
		switchPanel(UpdateData)
	End Sub
	
	Sub BtnDeleteDataClick(sender As Object, e As EventArgs)
		switchPanel(DeleteData)
	End Sub
	
	Sub BtnSettingsClick(sender As Object, e As EventArgs)
		switchPanel(Settings)
	End Sub
	
	Sub BtnExitClick(sender As Object, e As EventArgs)
		Dim response As Integer
		
		response = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		
		If response = vbYes Then
			Application.ExitThread
		Else
			Return
		End If
	End Sub
	
	Sub BtnClosefrmClick(sender As Object, e As EventArgs)
		Dim response As Integer
		
		response = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		
		If response = vbYes Then
			Application.ExitThread
		Else
			Return
		End If
	End Sub
	
	Sub BtnMinClick(sender As Object, e As EventArgs)
		Me.WindowState = FormWindowState.Minimized
	End Sub
	
	
	
End Class
