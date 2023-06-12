'
' Created by SharpDevelop.
' User: Twinkle
' Date: 25/05/2023
' Time: 3:42 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class LoginForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.pictureBox3 = New System.Windows.Forms.PictureBox()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnLogIn = New System.Windows.Forms.Button()
		Me.btnlogExit = New System.Windows.Forms.Button()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.pcbCloseLogin = New System.Windows.Forms.PictureBox()
		Me.pictureBox4 = New System.Windows.Forms.PictureBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel5.SuspendLayout
		CType(Me.pcbCloseLogin,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(327, 59)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(122, 122)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Cambria", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(228, 184)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(329, 82)
		Me.label1.TabIndex = 1
		Me.label1.Text = "OSA Discipline and Violation Records System"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.panel1.Controls.Add(Me.pictureBox2)
		Me.panel1.Controls.Add(Me.panel2)
		Me.panel1.Controls.Add(Me.txtUsername)
		Me.panel1.Location = New System.Drawing.Point(253, 290)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(278, 68)
		Me.panel1.TabIndex = 2
		AddHandler Me.panel1.Paint, AddressOf Me.Panel1Paint
		'
		'pictureBox2
		'
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.Location = New System.Drawing.Point(13, 11)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(48, 48)
		Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBox2.TabIndex = 3
		Me.pictureBox2.TabStop = false
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel2.Location = New System.Drawing.Point(74, 52)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(189, 5)
		Me.panel2.TabIndex = 3
		'
		'txtUsername
		'
		Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtUsername.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtUsername.Location = New System.Drawing.Point(74, 29)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(189, 18)
		Me.txtUsername.TabIndex = 0
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.panel3.Controls.Add(Me.pictureBox3)
		Me.panel3.Controls.Add(Me.panel4)
		Me.panel3.Controls.Add(Me.txtPassword)
		Me.panel3.Location = New System.Drawing.Point(253, 364)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(278, 68)
		Me.panel3.TabIndex = 3
		'
		'pictureBox3
		'
		Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"),System.Drawing.Image)
		Me.pictureBox3.Location = New System.Drawing.Point(13, 11)
		Me.pictureBox3.Name = "pictureBox3"
		Me.pictureBox3.Size = New System.Drawing.Size(48, 48)
		Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBox3.TabIndex = 3
		Me.pictureBox3.TabStop = false
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel4.Location = New System.Drawing.Point(74, 52)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(189, 5)
		Me.panel4.TabIndex = 3
		'
		'txtPassword
		'
		Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPassword.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtPassword.Location = New System.Drawing.Point(74, 29)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(189, 18)
		Me.txtPassword.TabIndex = 0
		'
		'btnLogIn
		'
		Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogIn.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnLogIn.Location = New System.Drawing.Point(253, 451)
		Me.btnLogIn.Name = "btnLogIn"
		Me.btnLogIn.Size = New System.Drawing.Size(130, 50)
		Me.btnLogIn.TabIndex = 4
		Me.btnLogIn.Text = "Log In"
		Me.btnLogIn.UseVisualStyleBackColor = false
		AddHandler Me.btnLogIn.Click, AddressOf Me.BtnLogInClick
		'
		'btnlogExit
		'
		Me.btnlogExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnlogExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnlogExit.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnlogExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnlogExit.Location = New System.Drawing.Point(401, 451)
		Me.btnlogExit.Name = "btnlogExit"
		Me.btnlogExit.Size = New System.Drawing.Size(130, 50)
		Me.btnlogExit.TabIndex = 5
		Me.btnlogExit.Text = "Exit"
		Me.btnlogExit.UseVisualStyleBackColor = false
		AddHandler Me.btnlogExit.Click, AddressOf Me.BtnlogExitClick
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.panel5.BackgroundImage = CType(resources.GetObject("panel5.BackgroundImage"),System.Drawing.Image)
		Me.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel5.Controls.Add(Me.pcbCloseLogin)
		Me.panel5.Controls.Add(Me.pictureBox4)
		Me.panel5.Location = New System.Drawing.Point(0, 0)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(784, 37)
		Me.panel5.TabIndex = 6
		'
		'pcbCloseLogin
		'
		Me.pcbCloseLogin.BackColor = System.Drawing.Color.Transparent
		Me.pcbCloseLogin.Image = CType(resources.GetObject("pcbCloseLogin.Image"),System.Drawing.Image)
		Me.pcbCloseLogin.Location = New System.Drawing.Point(749, 0)
		Me.pcbCloseLogin.Name = "pcbCloseLogin"
		Me.pcbCloseLogin.Size = New System.Drawing.Size(35, 37)
		Me.pcbCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pcbCloseLogin.TabIndex = 7
		Me.pcbCloseLogin.TabStop = false
		AddHandler Me.pcbCloseLogin.Click, AddressOf Me.PcbCloseLoginClick
		'
		'pictureBox4
		'
		Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"),System.Drawing.Image)
		Me.pictureBox4.Location = New System.Drawing.Point(1057, 0)
		Me.pictureBox4.Name = "pictureBox4"
		Me.pictureBox4.Size = New System.Drawing.Size(24, 24)
		Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBox4.TabIndex = 0
		Me.pictureBox4.TabStop = false
		'
		'LoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ClientSize = New System.Drawing.Size(784, 561)
		Me.Controls.Add(Me.panel5)
		Me.Controls.Add(Me.btnlogExit)
		Me.Controls.Add(Me.btnLogIn)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.pictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Location = New System.Drawing.Point(265, 0)
		Me.Name = "LoginForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login Form"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.pictureBox3,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel5.ResumeLayout(false)
		Me.panel5.PerformLayout
		CType(Me.pcbCloseLogin,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox4,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pcbCloseLogin As System.Windows.Forms.PictureBox
	Private pictureBox4 As System.Windows.Forms.PictureBox
	Private panel5 As System.Windows.Forms.Panel
	Private btnLogIn As System.Windows.Forms.Button
	Private btnlogExit As System.Windows.Forms.Button
	Private txtPassword As System.Windows.Forms.TextBox
	Private panel4 As System.Windows.Forms.Panel
	Private pictureBox3 As System.Windows.Forms.PictureBox
	Private panel3 As System.Windows.Forms.Panel
	Private txtUsername As System.Windows.Forms.TextBox
	Private panel2 As System.Windows.Forms.Panel
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
