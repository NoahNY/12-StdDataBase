﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnFindStud = New System.Windows.Forms.Button()
        Me.txtFoundResult = New System.Windows.Forms.TextBox()
        Me.txtTestIndex = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(36, 54)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(142, 54)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(d/mm/yy)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "('m' or 'f')"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "(0-100)"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(142, 110)
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(100, 20)
        Me.txtAvMk.TabIndex = 4
        '
        'btnAddStud
        '
        Me.btnAddStud.Location = New System.Drawing.Point(469, 106)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(100, 23)
        Me.btnAddStud.TabIndex = 9
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'lstStud
        '
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.Location = New System.Drawing.Point(36, 202)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(533, 160)
        Me.lstStud.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of entered students (for testing)"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(248, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 5
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Checked = True
        Me.chkPaid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPaid.Location = New System.Drawing.Point(401, 110)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 6
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone Number"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(248, 54)
        Me.txtDOB.MaxDate = New Date(2020, 11, 9, 0, 0, 0, 0)
        Me.txtDOB.MinDate = New Date(1960, 1, 1, 0, 0, 0, 0)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(200, 20)
        Me.txtDOB.TabIndex = 2
        Me.txtDOB.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Date of Birth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Gender                        Average Mark"
        '
        'btnFindStud
        '
        Me.btnFindStud.Location = New System.Drawing.Point(454, 150)
        Me.btnFindStud.Name = "btnFindStud"
        Me.btnFindStud.Size = New System.Drawing.Size(145, 23)
        Me.btnFindStud.TabIndex = 10
        Me.btnFindStud.Text = "Find Student by Surname"
        Me.btnFindStud.UseVisualStyleBackColor = True
        '
        'txtFoundResult
        '
        Me.txtFoundResult.Location = New System.Drawing.Point(36, 152)
        Me.txtFoundResult.Name = "txtFoundResult"
        Me.txtFoundResult.Size = New System.Drawing.Size(309, 20)
        Me.txtFoundResult.TabIndex = 7
        '
        'txtTestIndex
        '
        Me.txtTestIndex.Location = New System.Drawing.Point(351, 152)
        Me.txtTestIndex.Name = "txtTestIndex"
        Me.txtTestIndex.Size = New System.Drawing.Size(100, 20)
        Me.txtTestIndex.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(36, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Test field for selected element in list box"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(352, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Element Index"
        '
        'txtGender
        '
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.txtGender.Location = New System.Drawing.Point(36, 109)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 21)
        Me.txtGender.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 391)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTestIndex)
        Me.Controls.Add(Me.txtFoundResult)
        Me.Controls.Add(Me.btnFindStud)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "v2.0.4 Student Entry Form - Improved validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvMk As TextBox
    Friend WithEvents btnAddStud As Button


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnFindStud As Button
    Friend WithEvents txtFoundResult As TextBox
    Friend WithEvents txtTestIndex As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
