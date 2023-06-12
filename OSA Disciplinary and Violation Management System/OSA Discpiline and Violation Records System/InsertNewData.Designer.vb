'
' Created by SharpDevelop.
' User: Twinkle
' Date: 29/05/2023
' Time: 9:04 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class InsertNewData
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsertNewData))
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
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
		Me.pnlInsert = New System.Windows.Forms.Panel()
		Me.txtRoomNumber = New System.Windows.Forms.TextBox()
		Me.txtDate = New System.Windows.Forms.TextBox()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.txtSection = New System.Windows.Forms.TextBox()
		Me.panel8 = New System.Windows.Forms.Panel()
		Me.label10 = New System.Windows.Forms.Label()
		Me.txtStrand = New System.Windows.Forms.TextBox()
		Me.panel7 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.txtAdviser = New System.Windows.Forms.TextBox()
		Me.txtParContactNo = New System.Windows.Forms.TextBox()
		Me.cmbViolation = New System.Windows.Forms.ComboBox()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.txtStudent = New System.Windows.Forms.TextBox()
		Me.cmbGrdLvl = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.pnlControls = New System.Windows.Forms.Panel()
		Me.txtSearchID = New System.Windows.Forms.TextBox()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnCheck = New System.Windows.Forms.Button()
		Me.btnClrViolationForm = New System.Windows.Forms.Button()
		Me.btnInsertData = New System.Windows.Forms.Button()
		Me.btnPopViolationForm = New System.Windows.Forms.Button()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnlInsert.SuspendLayout
		Me.pnlControls.SuspendLayout
		Me.SuspendLayout
		'
		'dataGridView1
		'
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(79, 187)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(1039, 142)
		Me.dataGridView1.TabIndex = 7
		'
		'listView1
		'
		Me.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5, Me.columnHeader6, Me.columnHeader7, Me.columnHeader8, Me.columnHeader9, Me.columnHeader10})
		Me.listView1.GridLines = true
		Me.listView1.Location = New System.Drawing.Point(78, 12)
		Me.listView1.Name = "listView1"
		Me.listView1.Size = New System.Drawing.Size(1038, 169)
		Me.listView1.TabIndex = 8
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
		'pnlInsert
		'
		Me.pnlInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.pnlInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlInsert.Controls.Add(Me.txtRoomNumber)
		Me.pnlInsert.Controls.Add(Me.txtDate)
		Me.pnlInsert.Controls.Add(Me.panel6)
		Me.pnlInsert.Controls.Add(Me.txtSection)
		Me.pnlInsert.Controls.Add(Me.panel8)
		Me.pnlInsert.Controls.Add(Me.label10)
		Me.pnlInsert.Controls.Add(Me.txtStrand)
		Me.pnlInsert.Controls.Add(Me.panel7)
		Me.pnlInsert.Controls.Add(Me.label1)
		Me.pnlInsert.Controls.Add(Me.txtAdviser)
		Me.pnlInsert.Controls.Add(Me.txtParContactNo)
		Me.pnlInsert.Controls.Add(Me.cmbViolation)
		Me.pnlInsert.Controls.Add(Me.panel5)
		Me.pnlInsert.Controls.Add(Me.panel4)
		Me.pnlInsert.Controls.Add(Me.panel3)
		Me.pnlInsert.Controls.Add(Me.panel2)
		Me.pnlInsert.Controls.Add(Me.label8)
		Me.pnlInsert.Controls.Add(Me.label7)
		Me.pnlInsert.Controls.Add(Me.label6)
		Me.pnlInsert.Controls.Add(Me.label5)
		Me.pnlInsert.Controls.Add(Me.txtStudent)
		Me.pnlInsert.Controls.Add(Me.cmbGrdLvl)
		Me.pnlInsert.Controls.Add(Me.label3)
		Me.pnlInsert.Controls.Add(Me.label2)
		Me.pnlInsert.Controls.Add(Me.label9)
		Me.pnlInsert.Location = New System.Drawing.Point(340, 335)
		Me.pnlInsert.Name = "pnlInsert"
		Me.pnlInsert.Size = New System.Drawing.Size(778, 250)
		Me.pnlInsert.TabIndex = 10
		'
		'txtRoomNumber
		'
		Me.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtRoomNumber.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtRoomNumber.Location = New System.Drawing.Point(533, 142)
		Me.txtRoomNumber.Name = "txtRoomNumber"
		Me.txtRoomNumber.Size = New System.Drawing.Size(206, 19)
		Me.txtRoomNumber.TabIndex = 36
		'
		'txtDate
		'
		Me.txtDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDate.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtDate.Location = New System.Drawing.Point(533, 98)
		Me.txtDate.Name = "txtDate"
		Me.txtDate.Size = New System.Drawing.Size(206, 19)
		Me.txtDate.TabIndex = 35
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel6.Location = New System.Drawing.Point(533, 120)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(208, 5)
		Me.panel6.TabIndex = 34
		'
		'txtSection
		'
		Me.txtSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtSection.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtSection.Location = New System.Drawing.Point(181, 132)
		Me.txtSection.Name = "txtSection"
		Me.txtSection.Size = New System.Drawing.Size(201, 19)
		Me.txtSection.TabIndex = 33
		'
		'panel8
		'
		Me.panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel8.Location = New System.Drawing.Point(182, 152)
		Me.panel8.Name = "panel8"
		Me.panel8.Size = New System.Drawing.Size(201, 5)
		Me.panel8.TabIndex = 32
		'
		'label10
		'
		Me.label10.BackColor = System.Drawing.Color.Transparent
		Me.label10.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label10.Location = New System.Drawing.Point(112, 127)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(72, 37)
		Me.label10.TabIndex = 31
		Me.label10.Text = "Section"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtStrand
		'
		Me.txtStrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtStrand.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtStrand.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtStrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtStrand.Location = New System.Drawing.Point(181, 95)
		Me.txtStrand.Name = "txtStrand"
		Me.txtStrand.Size = New System.Drawing.Size(201, 19)
		Me.txtStrand.TabIndex = 30
		'
		'panel7
		'
		Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel7.Location = New System.Drawing.Point(182, 115)
		Me.panel7.Name = "panel7"
		Me.panel7.Size = New System.Drawing.Size(201, 5)
		Me.panel7.TabIndex = 29
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(112, 90)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(72, 37)
		Me.label1.TabIndex = 28
		Me.label1.Text = "Strand"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtAdviser
		'
		Me.txtAdviser.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtAdviser.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtAdviser.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtAdviser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtAdviser.Location = New System.Drawing.Point(181, 181)
		Me.txtAdviser.Name = "txtAdviser"
		Me.txtAdviser.Size = New System.Drawing.Size(201, 19)
		Me.txtAdviser.TabIndex = 23
		'
		'txtParContactNo
		'
		Me.txtParContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtParContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtParContactNo.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtParContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtParContactNo.Location = New System.Drawing.Point(575, 181)
		Me.txtParContactNo.Name = "txtParContactNo"
		Me.txtParContactNo.Size = New System.Drawing.Size(169, 19)
		Me.txtParContactNo.TabIndex = 25
		'
		'cmbViolation
		'
		Me.cmbViolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbViolation.FormattingEnabled = true
		Me.cmbViolation.Items.AddRange(New Object() {"Misconduct", "Dishonesty", "Violation Acts", "Against Property"})
		Me.cmbViolation.Location = New System.Drawing.Point(533, 56)
		Me.cmbViolation.Name = "cmbViolation"
		Me.cmbViolation.Size = New System.Drawing.Size(207, 21)
		Me.cmbViolation.TabIndex = 24
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel5.Location = New System.Drawing.Point(573, 200)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(171, 5)
		Me.panel5.TabIndex = 20
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel4.Location = New System.Drawing.Point(534, 160)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(208, 5)
		Me.panel4.TabIndex = 19
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel3.Location = New System.Drawing.Point(181, 202)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(201, 5)
		Me.panel3.TabIndex = 18
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.panel2.Location = New System.Drawing.Point(182, 41)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(201, 5)
		Me.panel2.TabIndex = 5
		'
		'label8
		'
		Me.label8.BackColor = System.Drawing.Color.Transparent
		Me.label8.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label8.Location = New System.Drawing.Point(449, 46)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(80, 37)
		Me.label8.TabIndex = 13
		Me.label8.Text = "Violation"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label7
		'
		Me.label7.BackColor = System.Drawing.Color.Transparent
		Me.label7.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label7.Location = New System.Drawing.Point(413, 137)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(124, 37)
		Me.label7.TabIndex = 11
		Me.label7.Text = "Room Number"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label6
		'
		Me.label6.BackColor = System.Drawing.Color.Transparent
		Me.label6.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label6.Location = New System.Drawing.Point(483, 92)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(101, 37)
		Me.label6.TabIndex = 9
		Me.label6.Text = "Date"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label5
		'
		Me.label5.BackColor = System.Drawing.Color.Transparent
		Me.label5.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label5.Location = New System.Drawing.Point(112, 172)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(120, 37)
		Me.label5.TabIndex = 7
		Me.label5.Text = "Adviser"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtStudent
		'
		Me.txtStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.txtStudent.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtStudent.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtStudent.Location = New System.Drawing.Point(182, 21)
		Me.txtStudent.Name = "txtStudent"
		Me.txtStudent.Size = New System.Drawing.Size(201, 19)
		Me.txtStudent.TabIndex = 5
		'
		'cmbGrdLvl
		'
		Me.cmbGrdLvl.BackColor = System.Drawing.SystemColors.Window
		Me.cmbGrdLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbGrdLvl.FormattingEnabled = true
		Me.cmbGrdLvl.Items.AddRange(New Object() {"11", "12"})
		Me.cmbGrdLvl.Location = New System.Drawing.Point(182, 63)
		Me.cmbGrdLvl.Name = "cmbGrdLvl"
		Me.cmbGrdLvl.Size = New System.Drawing.Size(200, 21)
		Me.cmbGrdLvl.TabIndex = 4
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.Color.Transparent
		Me.label3.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label3.Location = New System.Drawing.Point(81, 46)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(97, 51)
		Me.label3.TabIndex = 3
		Me.label3.Text = "Grade Level"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.Transparent
		Me.label2.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label2.Location = New System.Drawing.Point(18, 12)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(166, 51)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Name of the Student"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label9
		'
		Me.label9.BackColor = System.Drawing.Color.Transparent
		Me.label9.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label9.Location = New System.Drawing.Point(413, 168)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(171, 57)
		Me.label9.TabIndex = 15
		Me.label9.Text = "Parent's Contact No."
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pnlControls
		'
		Me.pnlControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.pnlControls.BackgroundImage = CType(resources.GetObject("pnlControls.BackgroundImage"),System.Drawing.Image)
		Me.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlControls.Controls.Add(Me.txtSearchID)
		Me.pnlControls.Controls.Add(Me.btnClear)
		Me.pnlControls.Controls.Add(Me.btnCheck)
		Me.pnlControls.Controls.Add(Me.btnClrViolationForm)
		Me.pnlControls.Controls.Add(Me.btnInsertData)
		Me.pnlControls.Controls.Add(Me.btnPopViolationForm)
		Me.pnlControls.Controls.Add(Me.label11)
		Me.pnlControls.Location = New System.Drawing.Point(80, 335)
		Me.pnlControls.Name = "pnlControls"
		Me.pnlControls.Size = New System.Drawing.Size(255, 250)
		Me.pnlControls.TabIndex = 9
		'
		'txtSearchID
		'
		Me.txtSearchID.BackColor = System.Drawing.Color.FromArgb(CType(CType(97,Byte),Integer), CType(CType(118,Byte),Integer), CType(CType(195,Byte),Integer))
		Me.txtSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtSearchID.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSearchID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.txtSearchID.Location = New System.Drawing.Point(173, 36)
		Me.txtSearchID.Name = "txtSearchID"
		Me.txtSearchID.Size = New System.Drawing.Size(49, 32)
		Me.txtSearchID.TabIndex = 9
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
		Me.btnClear.Location = New System.Drawing.Point(129, 163)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnClear.Size = New System.Drawing.Size(104, 67)
		Me.btnClear.TabIndex = 8
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = false
		AddHandler Me.btnClear.Click, AddressOf Me.BtnClearClick
		'
		'btnCheck
		'
		Me.btnCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnCheck.FlatAppearance.BorderSize = 0
		Me.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCheck.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnCheck.Location = New System.Drawing.Point(129, 92)
		Me.btnCheck.Name = "btnCheck"
		Me.btnCheck.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnCheck.Size = New System.Drawing.Size(104, 64)
		Me.btnCheck.TabIndex = 7
		Me.btnCheck.Text = "Check"
		Me.btnCheck.UseVisualStyleBackColor = false
		AddHandler Me.btnCheck.Click, AddressOf Me.BtnCheckClick
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
		Me.btnClrViolationForm.Location = New System.Drawing.Point(19, 163)
		Me.btnClrViolationForm.Name = "btnClrViolationForm"
		Me.btnClrViolationForm.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnClrViolationForm.Size = New System.Drawing.Size(104, 67)
		Me.btnClrViolationForm.TabIndex = 5
		Me.btnClrViolationForm.Text = "Clear Violation Form"
		Me.btnClrViolationForm.UseVisualStyleBackColor = false
		AddHandler Me.btnClrViolationForm.Click, AddressOf Me.BtnClrViolationFormClick
		'
		'btnInsertData
		'
		Me.btnInsertData.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.btnInsertData.FlatAppearance.BorderSize = 0
		Me.btnInsertData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(4,Byte),Integer), CType(CType(28,Byte),Integer))
		Me.btnInsertData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102,Byte),Integer), CType(CType(48,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnInsertData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnInsertData.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnInsertData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.btnInsertData.Location = New System.Drawing.Point(19, 92)
		Me.btnInsertData.Name = "btnInsertData"
		Me.btnInsertData.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnInsertData.Size = New System.Drawing.Size(104, 65)
		Me.btnInsertData.TabIndex = 4
		Me.btnInsertData.Text = "Insert Data"
		Me.btnInsertData.UseVisualStyleBackColor = false
		AddHandler Me.btnInsertData.Click, AddressOf Me.BtnInsertDataClick
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
		Me.btnPopViolationForm.Location = New System.Drawing.Point(19, 19)
		Me.btnPopViolationForm.Name = "btnPopViolationForm"
		Me.btnPopViolationForm.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.btnPopViolationForm.Size = New System.Drawing.Size(104, 67)
		Me.btnPopViolationForm.TabIndex = 2
		Me.btnPopViolationForm.Text = "Populate Violation Form"
		Me.btnPopViolationForm.UseVisualStyleBackColor = false
		AddHandler Me.btnPopViolationForm.Click, AddressOf Me.BtnPopViolationFormClick
		'
		'label11
		'
		Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(108,Byte),Integer))
		Me.label11.Font = New System.Drawing.Font("Cambria", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label11.Location = New System.Drawing.Point(129, 18)
		Me.label11.Name = "label11"
		Me.label11.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
		Me.label11.Size = New System.Drawing.Size(104, 67)
		Me.label11.TabIndex = 37
		Me.label11.Text = "ID"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label4
		'
		Me.label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label4.BackColor = System.Drawing.Color.Transparent
		Me.label4.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(251,Byte),Integer))
		Me.label4.Location = New System.Drawing.Point(324, 14)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(546, 0)
		Me.label4.TabIndex = 11
		Me.label4.Text = "Violation Form"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'InsertNewData
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1130, 597)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.pnlControls)
		Me.Controls.Add(Me.listView1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.pnlInsert)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "InsertNewData"
		Me.Text = "InsertNewData"
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnlInsert.ResumeLayout(false)
		Me.pnlInsert.PerformLayout
		Me.pnlControls.ResumeLayout(false)
		Me.pnlControls.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private label11 As System.Windows.Forms.Label
	Private txtSearchID As System.Windows.Forms.TextBox
	Private btnCheck As System.Windows.Forms.Button
	Private btnClear As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private txtRoomNumber As System.Windows.Forms.TextBox
	Private txtDate As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private panel7 As System.Windows.Forms.Panel
	Private txtStrand As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private panel8 As System.Windows.Forms.Panel
	Private txtSection As System.Windows.Forms.TextBox
	Private btnPopViolationForm As System.Windows.Forms.Button
	Private btnInsertData As System.Windows.Forms.Button
	Private btnClrViolationForm As System.Windows.Forms.Button
	Private pnlControls As System.Windows.Forms.Panel
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private cmbGrdLvl As System.Windows.Forms.ComboBox
	Private txtStudent As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private panel4 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private txtAdviser As System.Windows.Forms.TextBox
	Private cmbViolation As System.Windows.Forms.ComboBox
	Private txtParContactNo As System.Windows.Forms.TextBox
	Private panel6 As System.Windows.Forms.Panel
	Private pnlInsert As System.Windows.Forms.Panel
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
	Private dataGridView1 As System.Windows.Forms.DataGridView
End Class
