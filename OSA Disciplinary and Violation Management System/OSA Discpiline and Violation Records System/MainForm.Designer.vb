'
' Created by SharpDevelop.
' User: Twinkle
' Date: 25/05/2023
' Time: 3:41 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.panelMenu = New System.Windows.Forms.Panel()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.pcbLogo = New System.Windows.Forms.PictureBox()
		Me.btnHomePage = New System.Windows.Forms.Button()
		Me.panelbuttons = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnDeleteData = New System.Windows.Forms.Button()
		Me.btnUpdateData = New System.Windows.Forms.Button()
		Me.btnSearchData = New System.Windows.Forms.Button()
		Me.btnInsertNewData = New System.Windows.Forms.Button()
		Me.panelmenuIcon = New System.Windows.Forms.Panel()
		Me.PcbMenuIcon = New System.Windows.Forms.PictureBox()
		Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
		Me.TimerPanelDecrease = New System.Windows.Forms.Timer(Me.components)
		Me.pnlHeader = New System.Windows.Forms.Panel()
		Me.btnSettings = New System.Windows.Forms.Button()
		Me.btnMin = New System.Windows.Forms.Button()
		Me.btnClosefrm = New System.Windows.Forms.Button()
		Me.pnlTransition = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panelMenu.SuspendLayout
		Me.panel1.SuspendLayout
		CType(Me.pcbLogo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panelbuttons.SuspendLayout
		Me.panelmenuIcon.SuspendLayout
		CType(Me.PcbMenuIcon,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlHeader.SuspendLayout
		Me.pnlTransition.SuspendLayout
		Me.SuspendLayout
		'
		'panelMenu
		'
		Me.panelMenu.Controls.Add(Me.panel1)
		Me.panelMenu.Controls.Add(Me.panelbuttons)
		Me.panelMenu.Controls.Add(Me.panelmenuIcon)
		Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.panelMenu.Location = New System.Drawing.Point(0, 0)
		Me.panelMenu.Name = "panelMenu"
		Me.panelMenu.Size = New System.Drawing.Size(200, 645)
		Me.panelMenu.TabIndex = 0
		AddHandler Me.panelMenu.SizeChanged, AddressOf Me.PanelMenuSizeChanged
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.panel1.Controls.Add(Me.pcbLogo)
		Me.panel1.Controls.Add(Me.btnHomePage)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 48)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(200, 233)
		Me.panel1.TabIndex = 1
		'
		'pcbLogo
		'
		Me.pcbLogo.Image = CType(resources.GetObject("pcbLogo.Image"),System.Drawing.Image)
		Me.pcbLogo.Location = New System.Drawing.Point(39, 22)
		Me.pcbLogo.Name = "pcbLogo"
		Me.pcbLogo.Size = New System.Drawing.Size(122, 122)
		Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pcbLogo.TabIndex = 1
		Me.pcbLogo.TabStop = false
		'
		'btnHomePage
		'
		Me.btnHomePage.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnHomePage.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.btnHomePage.FlatAppearance.BorderSize = 0
		Me.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnHomePage.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnHomePage.Image = CType(resources.GetObject("btnHomePage.Image"),System.Drawing.Image)
		Me.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnHomePage.Location = New System.Drawing.Point(0, 166)
		Me.btnHomePage.Name = "btnHomePage"
		Me.btnHomePage.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.btnHomePage.Size = New System.Drawing.Size(200, 67)
		Me.btnHomePage.TabIndex = 5
		Me.btnHomePage.Text = "Home Page"
		Me.btnHomePage.UseVisualStyleBackColor = false
		AddHandler Me.btnHomePage.Click, AddressOf Me.BtnHomePageClick
		'
		'panelbuttons
		'
		Me.panelbuttons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.panelbuttons.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.panelbuttons.Controls.Add(Me.btnExit)
		Me.panelbuttons.Controls.Add(Me.btnDeleteData)
		Me.panelbuttons.Controls.Add(Me.btnUpdateData)
		Me.panelbuttons.Controls.Add(Me.btnSearchData)
		Me.panelbuttons.Controls.Add(Me.btnInsertNewData)
		Me.panelbuttons.Location = New System.Drawing.Point(0, 281)
		Me.panelbuttons.Name = "panelbuttons"
		Me.panelbuttons.Size = New System.Drawing.Size(200, 364)
		Me.panelbuttons.TabIndex = 2
		'
		'btnExit
		'
		Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnExit.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"),System.Drawing.Image)
		Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnExit.Location = New System.Drawing.Point(0, 268)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Padding = New System.Windows.Forms.Padding(0, 0, 38, 0)
		Me.btnExit.Size = New System.Drawing.Size(200, 67)
		Me.btnExit.TabIndex = 4
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = false
		AddHandler Me.btnExit.Click, AddressOf Me.BtnExitClick
		'
		'btnDeleteData
		'
		Me.btnDeleteData.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnDeleteData.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnDeleteData.FlatAppearance.BorderSize = 0
		Me.btnDeleteData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnDeleteData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDeleteData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDeleteData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnDeleteData.Image = CType(resources.GetObject("btnDeleteData.Image"),System.Drawing.Image)
		Me.btnDeleteData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnDeleteData.Location = New System.Drawing.Point(0, 201)
		Me.btnDeleteData.Name = "btnDeleteData"
		Me.btnDeleteData.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
		Me.btnDeleteData.Size = New System.Drawing.Size(200, 67)
		Me.btnDeleteData.TabIndex = 3
		Me.btnDeleteData.Text = "Delete Data"
		Me.btnDeleteData.UseVisualStyleBackColor = false
		AddHandler Me.btnDeleteData.Click, AddressOf Me.BtnDeleteDataClick
		'
		'btnUpdateData
		'
		Me.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnUpdateData.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnUpdateData.FlatAppearance.BorderSize = 0
		Me.btnUpdateData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdateData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUpdateData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnUpdateData.Image = CType(resources.GetObject("btnUpdateData.Image"),System.Drawing.Image)
		Me.btnUpdateData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnUpdateData.Location = New System.Drawing.Point(0, 134)
		Me.btnUpdateData.Name = "btnUpdateData"
		Me.btnUpdateData.Size = New System.Drawing.Size(200, 67)
		Me.btnUpdateData.TabIndex = 2
		Me.btnUpdateData.Text = "Update Data"
		Me.btnUpdateData.UseVisualStyleBackColor = false
		AddHandler Me.btnUpdateData.Click, AddressOf Me.BtnUpdateDataClick
		'
		'btnSearchData
		'
		Me.btnSearchData.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnSearchData.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnSearchData.FlatAppearance.BorderSize = 0
		Me.btnSearchData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnSearchData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnSearchData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSearchData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSearchData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnSearchData.Image = CType(resources.GetObject("btnSearchData.Image"),System.Drawing.Image)
		Me.btnSearchData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSearchData.Location = New System.Drawing.Point(0, 67)
		Me.btnSearchData.Name = "btnSearchData"
		Me.btnSearchData.Size = New System.Drawing.Size(200, 67)
		Me.btnSearchData.TabIndex = 1
		Me.btnSearchData.Text = "Search Data"
		Me.btnSearchData.UseVisualStyleBackColor = false
		AddHandler Me.btnSearchData.Click, AddressOf Me.BtnSearchDataClick
		'
		'btnInsertNewData
		'
		Me.btnInsertNewData.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnInsertNewData.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnInsertNewData.FlatAppearance.BorderSize = 0
		Me.btnInsertNewData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnInsertNewData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnInsertNewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnInsertNewData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnInsertNewData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnInsertNewData.Image = CType(resources.GetObject("btnInsertNewData.Image"),System.Drawing.Image)
		Me.btnInsertNewData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnInsertNewData.Location = New System.Drawing.Point(0, 0)
		Me.btnInsertNewData.Name = "btnInsertNewData"
		Me.btnInsertNewData.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnInsertNewData.Size = New System.Drawing.Size(200, 67)
		Me.btnInsertNewData.TabIndex = 0
		Me.btnInsertNewData.Text = "Insert Data"
		Me.btnInsertNewData.UseVisualStyleBackColor = false
		AddHandler Me.btnInsertNewData.Click, AddressOf Me.BtnInsertNewDataClick
		'
		'panelmenuIcon
		'
		Me.panelmenuIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.panelmenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panelmenuIcon.Controls.Add(Me.PcbMenuIcon)
		Me.panelmenuIcon.Dock = System.Windows.Forms.DockStyle.Top
		Me.panelmenuIcon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.panelmenuIcon.Location = New System.Drawing.Point(0, 0)
		Me.panelmenuIcon.Name = "panelmenuIcon"
		Me.panelmenuIcon.Size = New System.Drawing.Size(200, 48)
		Me.panelmenuIcon.TabIndex = 0
		'
		'PcbMenuIcon
		'
		Me.PcbMenuIcon.Dock = System.Windows.Forms.DockStyle.Right
		Me.PcbMenuIcon.Image = CType(resources.GetObject("PcbMenuIcon.Image"),System.Drawing.Image)
		Me.PcbMenuIcon.Location = New System.Drawing.Point(152, 0)
		Me.PcbMenuIcon.Name = "PcbMenuIcon"
		Me.PcbMenuIcon.Size = New System.Drawing.Size(48, 48)
		Me.PcbMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.PcbMenuIcon.TabIndex = 0
		Me.PcbMenuIcon.TabStop = false
		AddHandler Me.PcbMenuIcon.Click, AddressOf Me.PcbMenuIconClick
		'
		'TimerPanelIncrease
		'
		Me.TimerPanelIncrease.Interval = 30
		AddHandler Me.TimerPanelIncrease.Tick, AddressOf Me.TimerPanelIncreaseTick
		'
		'TimerPanelDecrease
		'
		Me.TimerPanelDecrease.Interval = 30
		AddHandler Me.TimerPanelDecrease.Tick, AddressOf Me.TimerPanelDecreaseTick
		'
		'pnlHeader
		'
		Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.pnlHeader.BackgroundImage = CType(resources.GetObject("pnlHeader.BackgroundImage"),System.Drawing.Image)
		Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlHeader.Controls.Add(Me.btnSettings)
		Me.pnlHeader.Controls.Add(Me.btnMin)
		Me.pnlHeader.Controls.Add(Me.btnClosefrm)
		Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
		Me.pnlHeader.Name = "pnlHeader"
		Me.pnlHeader.Size = New System.Drawing.Size(1130, 48)
		Me.pnlHeader.TabIndex = 1
		'
		'btnSettings
		'
		Me.btnSettings.BackColor = System.Drawing.Color.Transparent
		Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Right
		Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"),System.Drawing.Image)
		Me.btnSettings.Location = New System.Drawing.Point(1046, 0)
		Me.btnSettings.Name = "btnSettings"
		Me.btnSettings.Size = New System.Drawing.Size(28, 48)
		Me.btnSettings.TabIndex = 5
		Me.btnSettings.UseVisualStyleBackColor = false
		AddHandler Me.btnSettings.Click, AddressOf Me.BtnSettingsClick
		'
		'btnMin
		'
		Me.btnMin.BackColor = System.Drawing.Color.Transparent
		Me.btnMin.Dock = System.Windows.Forms.DockStyle.Right
		Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"),System.Drawing.Image)
		Me.btnMin.Location = New System.Drawing.Point(1074, 0)
		Me.btnMin.Name = "btnMin"
		Me.btnMin.Size = New System.Drawing.Size(28, 48)
		Me.btnMin.TabIndex = 4
		Me.btnMin.UseVisualStyleBackColor = false
		AddHandler Me.btnMin.Click, AddressOf Me.BtnMinClick
		'
		'btnClosefrm
		'
		Me.btnClosefrm.BackColor = System.Drawing.Color.Transparent
		Me.btnClosefrm.Dock = System.Windows.Forms.DockStyle.Right
		Me.btnClosefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClosefrm.Image = CType(resources.GetObject("btnClosefrm.Image"),System.Drawing.Image)
		Me.btnClosefrm.Location = New System.Drawing.Point(1102, 0)
		Me.btnClosefrm.Name = "btnClosefrm"
		Me.btnClosefrm.Size = New System.Drawing.Size(28, 48)
		Me.btnClosefrm.TabIndex = 1
		Me.btnClosefrm.UseVisualStyleBackColor = false
		AddHandler Me.btnClosefrm.Click, AddressOf Me.BtnClosefrmClick
		'
		'pnlTransition
		'
		Me.pnlTransition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.pnlTransition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTransition.Controls.Add(Me.label1)
		Me.pnlTransition.Location = New System.Drawing.Point(0, 48)
		Me.pnlTransition.Name = "pnlTransition"
		Me.pnlTransition.Size = New System.Drawing.Size(1130, 597)
		Me.pnlTransition.TabIndex = 2
		'
		'label1
		'
		Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(333, 179)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(648, 137)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Discipline and Violation Records and Management System for Lyceum of Alabang Inc."& _ 
		" OSA Basic Education Department"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1130, 645)
		Me.Controls.Add(Me.panelMenu)
		Me.Controls.Add(Me.pnlHeader)
		Me.Controls.Add(Me.pnlTransition)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "OSA Discipline and Violation Records System"
		Me.panelMenu.ResumeLayout(false)
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		CType(Me.pcbLogo,System.ComponentModel.ISupportInitialize).EndInit
		Me.panelbuttons.ResumeLayout(false)
		Me.panelmenuIcon.ResumeLayout(false)
		Me.panelmenuIcon.PerformLayout
		CType(Me.PcbMenuIcon,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlHeader.ResumeLayout(false)
		Me.pnlTransition.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private btnSettings As System.Windows.Forms.Button
	Private btnMin As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private btnHomePage As System.Windows.Forms.Button
	Private pnlTransition As System.Windows.Forms.Panel
	Private btnClosefrm As System.Windows.Forms.Button
	Private pnlHeader As System.Windows.Forms.Panel
	Private TimerPanelDecrease As System.Windows.Forms.Timer
	Private TimerPanelIncrease As System.Windows.Forms.Timer
	Private btnSearchData As System.Windows.Forms.Button
	Private btnUpdateData As System.Windows.Forms.Button
	Private btnDeleteData As System.Windows.Forms.Button
	Private btnExit As System.Windows.Forms.Button
	Private btnInsertNewData As System.Windows.Forms.Button
	Private pcbLogo As System.Windows.Forms.PictureBox
	Private PcbMenuIcon As System.Windows.Forms.PictureBox
	Private panelmenuIcon As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private panelbuttons As System.Windows.Forms.Panel
	Private panelMenu As System.Windows.Forms.Panel
	
End Class
