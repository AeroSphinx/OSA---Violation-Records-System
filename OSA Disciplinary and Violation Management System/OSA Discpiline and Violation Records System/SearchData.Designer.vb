'
' Created by SharpDevelop.
' User: Twinkle
' Date: 29/05/2023
' Time: 9:18 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class SearchData
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchData))
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnClrViolationForm = New System.Windows.Forms.Button()
		Me.btnPopViolationForm = New System.Windows.Forms.Button()
		Me.pnlControls = New System.Windows.Forms.Panel()
		Me.label4 = New System.Windows.Forms.Label()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		Me.pnlInsert = New System.Windows.Forms.Panel()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.comboBox4 = New System.Windows.Forms.ComboBox()
		Me.btnApplyFilter = New System.Windows.Forms.Button()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.comboBox2 = New System.Windows.Forms.ComboBox()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.comboBox3 = New System.Windows.Forms.ComboBox()
		Me.listView1 = New System.Windows.Forms.ListView()
		Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader4 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader5 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader6 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader7 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader8 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader9 = New System.Windows.Forms.ColumnHeader()
		Me.columnHeader10 = New System.Windows.Forms.ColumnHeader()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.pnlControls.SuspendLayout
		Me.pnlInsert.SuspendLayout
		Me.panel1.SuspendLayout
		Me.panel3.SuspendLayout
		Me.panel4.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnClear
		'
		Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnClear.FlatAppearance.BorderSize = 0
		Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnClear.Location = New System.Drawing.Point(19, 140)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnClear.Size = New System.Drawing.Size(214, 64)
		Me.btnClear.TabIndex = 7
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = false
		AddHandler Me.btnClear.Click, AddressOf Me.BtnCheckClick
		'
		'btnClrViolationForm
		'
		Me.btnClrViolationForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnClrViolationForm.FlatAppearance.BorderSize = 0
		Me.btnClrViolationForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnClrViolationForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnClrViolationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClrViolationForm.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClrViolationForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnClrViolationForm.Location = New System.Drawing.Point(129, 57)
		Me.btnClrViolationForm.Name = "btnClrViolationForm"
		Me.btnClrViolationForm.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnClrViolationForm.Size = New System.Drawing.Size(104, 67)
		Me.btnClrViolationForm.TabIndex = 5
		Me.btnClrViolationForm.Text = "Clear Violation Form"
		Me.btnClrViolationForm.UseVisualStyleBackColor = false
		AddHandler Me.btnClrViolationForm.Click, AddressOf Me.BtnClrViolationFormClick
		'
		'btnPopViolationForm
		'
		Me.btnPopViolationForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnPopViolationForm.FlatAppearance.BorderSize = 0
		Me.btnPopViolationForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnPopViolationForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnPopViolationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPopViolationForm.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPopViolationForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnPopViolationForm.Location = New System.Drawing.Point(19, 57)
		Me.btnPopViolationForm.Name = "btnPopViolationForm"
		Me.btnPopViolationForm.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnPopViolationForm.Size = New System.Drawing.Size(104, 67)
		Me.btnPopViolationForm.TabIndex = 2
		Me.btnPopViolationForm.Text = "Populate Violation Form"
		Me.btnPopViolationForm.UseVisualStyleBackColor = false
		AddHandler Me.btnPopViolationForm.Click, AddressOf Me.BtnPopViolationFormClick
		'
		'pnlControls
		'
		Me.pnlControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.pnlControls.BackgroundImage = CType(resources.GetObject("pnlControls.BackgroundImage"),System.Drawing.Image)
		Me.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlControls.Controls.Add(Me.btnClear)
		Me.pnlControls.Controls.Add(Me.btnClrViolationForm)
		Me.pnlControls.Controls.Add(Me.btnPopViolationForm)
		Me.pnlControls.Location = New System.Drawing.Point(82, 335)
		Me.pnlControls.Name = "pnlControls"
		Me.pnlControls.Size = New System.Drawing.Size(255, 250)
		Me.pnlControls.TabIndex = 14
		'
		'label4
		'
		Me.label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label4.BackColor = System.Drawing.Color.Transparent
		Me.label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label4.Location = New System.Drawing.Point(291, 12)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(546, 0)
		Me.label4.TabIndex = 16
		Me.label4.Text = "Violation Form"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel5.Location = New System.Drawing.Point(97, 97)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(171, 5)
		Me.panel5.TabIndex = 20
		'
		'txtSearch
		'
		Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtSearch.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtSearch.Location = New System.Drawing.Point(100, 80)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(168, 19)
		Me.txtSearch.TabIndex = 25
		'
		'pnlInsert
		'
		Me.pnlInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.pnlInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlInsert.Controls.Add(Me.btnSearch)
		Me.pnlInsert.Controls.Add(Me.panel1)
		Me.pnlInsert.Controls.Add(Me.txtSearch)
		Me.pnlInsert.Controls.Add(Me.panel5)
		Me.pnlInsert.Location = New System.Drawing.Point(342, 335)
		Me.pnlInsert.Name = "pnlInsert"
		Me.pnlInsert.Size = New System.Drawing.Size(388, 250)
		Me.pnlInsert.TabIndex = 15
		'
		'btnSearch
		'
		Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnSearch.FlatAppearance.BorderSize = 0
		Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSearch.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnSearch.Location = New System.Drawing.Point(136, 126)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnSearch.Size = New System.Drawing.Size(104, 64)
		Me.btnSearch.TabIndex = 8
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = false
		AddHandler Me.btnSearch.Click, AddressOf Me.BtnSearchClick
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel1.Controls.Add(Me.textBox1)
		Me.panel1.Controls.Add(Me.comboBox1)
		Me.panel1.Controls.Add(Me.panel2)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(392, -2)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(382, 250)
		Me.panel1.TabIndex = 26
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox1.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.textBox1.Location = New System.Drawing.Point(60, 72)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(169, 19)
		Me.textBox1.TabIndex = 25
		'
		'comboBox1
		'
		Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"Misconduct", "Dishonesty", "Violation Acts", "Against Property"})
		Me.comboBox1.Location = New System.Drawing.Point(41, 149)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(207, 21)
		Me.comboBox1.TabIndex = 24
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel2.Location = New System.Drawing.Point(41, 97)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(171, 5)
		Me.panel2.TabIndex = 20
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(60, 19)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(80, 37)
		Me.label1.TabIndex = 13
		Me.label1.Text = "Violation"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel3.Controls.Add(Me.comboBox4)
		Me.panel3.Controls.Add(Me.btnApplyFilter)
		Me.panel3.Controls.Add(Me.panel4)
		Me.panel3.Controls.Add(Me.comboBox3)
		Me.panel3.Location = New System.Drawing.Point(731, 335)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(388, 250)
		Me.panel3.TabIndex = 27
		'
		'comboBox4
		'
		Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox4.FormattingEnabled = true
		Me.comboBox4.Items.AddRange(New Object() {"Misconduct", "Dishonesty", "Violation Acts", "Against Property"})
		Me.comboBox4.Location = New System.Drawing.Point(203, 81)
		Me.comboBox4.Name = "comboBox4"
		Me.comboBox4.Size = New System.Drawing.Size(135, 21)
		Me.comboBox4.TabIndex = 28
		'
		'btnApplyFilter
		'
		Me.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnApplyFilter.FlatAppearance.BorderSize = 0
		Me.btnApplyFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnApplyFilter.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnApplyFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnApplyFilter.Location = New System.Drawing.Point(149, 126)
		Me.btnApplyFilter.Name = "btnApplyFilter"
		Me.btnApplyFilter.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnApplyFilter.Size = New System.Drawing.Size(104, 64)
		Me.btnApplyFilter.TabIndex = 27
		Me.btnApplyFilter.Text = "Apply"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Filter"
		Me.btnApplyFilter.UseVisualStyleBackColor = false
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel4.Controls.Add(Me.textBox2)
		Me.panel4.Controls.Add(Me.comboBox2)
		Me.panel4.Controls.Add(Me.panel6)
		Me.panel4.Controls.Add(Me.label2)
		Me.panel4.Location = New System.Drawing.Point(392, -2)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(382, 250)
		Me.panel4.TabIndex = 26
		'
		'textBox2
		'
		Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.textBox2.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.textBox2.Location = New System.Drawing.Point(60, 72)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(169, 19)
		Me.textBox2.TabIndex = 25
		'
		'comboBox2
		'
		Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox2.FormattingEnabled = true
		Me.comboBox2.Items.AddRange(New Object() {"Misconduct", "Dishonesty", "Violation Acts", "Against Property"})
		Me.comboBox2.Location = New System.Drawing.Point(41, 149)
		Me.comboBox2.Name = "comboBox2"
		Me.comboBox2.Size = New System.Drawing.Size(207, 21)
		Me.comboBox2.TabIndex = 24
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel6.Location = New System.Drawing.Point(41, 97)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(171, 5)
		Me.panel6.TabIndex = 20
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.Transparent
		Me.label2.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label2.Location = New System.Drawing.Point(60, 19)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(80, 37)
		Me.label2.TabIndex = 13
		Me.label2.Text = "Violation"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'comboBox3
		'
		Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox3.FormattingEnabled = true
		Me.comboBox3.Items.AddRange(New Object() {"11", "12"})
		Me.comboBox3.Location = New System.Drawing.Point(46, 81)
		Me.comboBox3.Name = "comboBox3"
		Me.comboBox3.Size = New System.Drawing.Size(135, 21)
		Me.comboBox3.TabIndex = 24
		'
		'listView1
		'
		Me.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5, Me.columnHeader6, Me.columnHeader7, Me.columnHeader8, Me.columnHeader9, Me.columnHeader10})
		Me.listView1.GridLines = true
		Me.listView1.Location = New System.Drawing.Point(80, 12)
		Me.listView1.Name = "listView1"
		Me.listView1.Size = New System.Drawing.Size(1038, 169)
		Me.listView1.TabIndex = 29
		Me.listView1.UseCompatibleStateImageBehavior = false
		Me.listView1.View = System.Windows.Forms.View.Details
		'
		'columnHeader1
		'
		Me.columnHeader1.Text = "ID"
		Me.columnHeader1.Width = 32
		'
		'columnHeader2
		'
		Me.columnHeader2.Text = "Name of the Student"
		Me.columnHeader2.Width = 170
		'
		'columnHeader3
		'
		Me.columnHeader3.Text = "Grade"
		Me.columnHeader3.Width = 43
		'
		'columnHeader4
		'
		Me.columnHeader4.Text = "Strand"
		Me.columnHeader4.Width = 70
		'
		'columnHeader5
		'
		Me.columnHeader5.Text = "Section"
		Me.columnHeader5.Width = 95
		'
		'columnHeader6
		'
		Me.columnHeader6.Text = "Adviser"
		Me.columnHeader6.Width = 166
		'
		'columnHeader7
		'
		Me.columnHeader7.Text = "Violation"
		Me.columnHeader7.Width = 160
		'
		'columnHeader8
		'
		Me.columnHeader8.Text = "Date"
		Me.columnHeader8.Width = 87
		'
		'columnHeader9
		'
		Me.columnHeader9.Text = "Room Number"
		Me.columnHeader9.Width = 81
		'
		'columnHeader10
		'
		Me.columnHeader10.Text = "Parent's Contact Number"
		Me.columnHeader10.Width = 144
		'
		'dataGridView1
		'
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(81, 187)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(1039, 142)
		Me.dataGridView1.TabIndex = 28
		'
		'SearchData
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1130, 597)
		Me.Controls.Add(Me.listView1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.pnlControls)
		Me.Controls.Add(Me.pnlInsert)
		Me.Controls.Add(Me.label4)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "SearchData"
		Me.Text = "SearchData"
		Me.pnlControls.ResumeLayout(false)
		Me.pnlInsert.ResumeLayout(false)
		Me.pnlInsert.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.panel4.ResumeLayout(false)
		Me.panel4.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private columnHeader10 As System.Windows.Forms.ColumnHeader
	Private columnHeader9 As System.Windows.Forms.ColumnHeader
	Private columnHeader8 As System.Windows.Forms.ColumnHeader
	Private columnHeader7 As System.Windows.Forms.ColumnHeader
	Private columnHeader6 As System.Windows.Forms.ColumnHeader
	Private columnHeader5 As System.Windows.Forms.ColumnHeader
	Private columnHeader4 As System.Windows.Forms.ColumnHeader
	Private columnHeader3 As System.Windows.Forms.ColumnHeader
	Private columnHeader2 As System.Windows.Forms.ColumnHeader
	Private columnHeader1 As System.Windows.Forms.ColumnHeader
	Private listView1 As System.Windows.Forms.ListView
	Private txtSearch As System.Windows.Forms.TextBox
	Private btnSearch As System.Windows.Forms.Button
	Private btnApplyFilter As System.Windows.Forms.Button
	Private btnClear As System.Windows.Forms.Button
	Private comboBox4 As System.Windows.Forms.ComboBox
	Private comboBox3 As System.Windows.Forms.ComboBox
	Private comboBox2 As System.Windows.Forms.ComboBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private panel1 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private panel4 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private panel6 As System.Windows.Forms.Panel
	Private label4 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private pnlInsert As System.Windows.Forms.Panel
	Private btnPopViolationForm As System.Windows.Forms.Button
	Private btnClrViolationForm As System.Windows.Forms.Button
	Private pnlControls As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
End Class
