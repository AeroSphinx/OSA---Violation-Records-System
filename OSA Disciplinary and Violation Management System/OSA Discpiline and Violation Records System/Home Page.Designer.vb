'
' Created by SharpDevelop.
' User: 217
' Date: 6/2/2023
' Time: 8:46 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Home_Page
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
		Me.label1 = New System.Windows.Forms.Label()
		Me.pcbLogo = New System.Windows.Forms.PictureBox()
		CType(Me.pcbLogo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Cambria", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(324, 170)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(648, 137)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Discipline and Violation Records and Management System for Lyceum of Alabang Inc."& _ 
		" OSA Basic Education Department"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pcbLogo
		'
		Me.pcbLogo.Image = CType(resources.GetObject("pcbLogo.Image"),System.Drawing.Image)
		Me.pcbLogo.Location = New System.Drawing.Point(579, 45)
		Me.pcbLogo.Name = "pcbLogo"
		Me.pcbLogo.Size = New System.Drawing.Size(122, 122)
		Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pcbLogo.TabIndex = 2
		Me.pcbLogo.TabStop = false
		'
		'Home_Page
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1068, 675)
		Me.Controls.Add(Me.pcbLogo)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Home_Page"
		Me.Text = "Home_Page"
		CType(Me.pcbLogo,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pcbLogo As System.Windows.Forms.PictureBox
	Private label1 As System.Windows.Forms.Label
End Class
