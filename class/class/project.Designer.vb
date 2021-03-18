<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class project
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.username = New System.Windows.Forms.TextBox
        Me.marka = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.markb = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.markc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.savedatabtn = New System.Windows.Forms.Button
        Me.listboxmain = New System.Windows.Forms.ListBox
        Me.deletebtn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label6 = New System.Windows.Forms.Label
        Me.databaselink = New System.Windows.Forms.LinkLabel
        Me.studentidtxt = New System.Windows.Forms.TextBox
        Me.h = New System.Windows.Forms.Label
        Me.processbtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter name"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(147, 109)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(199, 20)
        Me.username.TabIndex = 1
        '
        'marka
        '
        Me.marka.Location = New System.Drawing.Point(147, 141)
        Me.marka.Name = "marka"
        Me.marka.Size = New System.Drawing.Size(49, 20)
        Me.marka.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mark 1"
        '
        'markb
        '
        Me.markb.Location = New System.Drawing.Point(147, 168)
        Me.markb.Name = "markb"
        Me.markb.Size = New System.Drawing.Size(49, 20)
        Me.markb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mark 2"
        '
        'markc
        '
        Me.markc.Location = New System.Drawing.Point(147, 193)
        Me.markc.Name = "markc"
        Me.markc.Size = New System.Drawing.Size(49, 20)
        Me.markc.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mark 3"
        '
        'savedatabtn
        '
        Me.savedatabtn.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savedatabtn.ForeColor = System.Drawing.Color.Blue
        Me.savedatabtn.Location = New System.Drawing.Point(53, 318)
        Me.savedatabtn.Name = "savedatabtn"
        Me.savedatabtn.Size = New System.Drawing.Size(316, 32)
        Me.savedatabtn.TabIndex = 8
        Me.savedatabtn.Text = "Save Data To Database"
        Me.savedatabtn.UseVisualStyleBackColor = True
        '
        'listboxmain
        '
        Me.listboxmain.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxmain.FormattingEnabled = True
        Me.listboxmain.ItemHeight = 19
        Me.listboxmain.Location = New System.Drawing.Point(506, 30)
        Me.listboxmain.Name = "listboxmain"
        Me.listboxmain.Size = New System.Drawing.Size(494, 232)
        Me.listboxmain.TabIndex = 9
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.Red
        Me.deletebtn.Location = New System.Drawing.Point(736, 311)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(99, 39)
        Me.deletebtn.TabIndex = 10
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(658, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Select data to Remove then press delete button"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(150, 446)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "VIEW GROUP MEMBERS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 34)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CLASS PROJECT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'databaselink
        '
        Me.databaselink.AutoSize = True
        Me.databaselink.Location = New System.Drawing.Point(738, 446)
        Me.databaselink.Name = "databaselink"
        Me.databaselink.Size = New System.Drawing.Size(97, 13)
        Me.databaselink.TabIndex = 14
        Me.databaselink.TabStop = True
        Me.databaselink.Text = "OPEN DATABASE"
        '
        'studentidtxt
        '
        Me.studentidtxt.Location = New System.Drawing.Point(147, 73)
        Me.studentidtxt.Name = "studentidtxt"
        Me.studentidtxt.Size = New System.Drawing.Size(199, 20)
        Me.studentidtxt.TabIndex = 16
        '
        'h
        '
        Me.h.AutoSize = True
        Me.h.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h.Location = New System.Drawing.Point(49, 73)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(86, 21)
        Me.h.TabIndex = 15
        Me.h.Text = "student ID"
        '
        'processbtn
        '
        Me.processbtn.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processbtn.Location = New System.Drawing.Point(53, 255)
        Me.processbtn.Name = "processbtn"
        Me.processbtn.Size = New System.Drawing.Size(316, 32)
        Me.processbtn.TabIndex = 17
        Me.processbtn.Text = "Process Input"
        Me.processbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(55, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(314, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Clear Input Fields"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(564, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(436, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "To Open and Manipulate the database Please click on link below"
        '
        'project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1040, 492)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.processbtn)
        Me.Controls.Add(Me.studentidtxt)
        Me.Controls.Add(Me.h)
        Me.Controls.Add(Me.databaselink)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.listboxmain)
        Me.Controls.Add(Me.savedatabtn)
        Me.Controls.Add(Me.markc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.markb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.marka)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "project"
        Me.Text = "Grading System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents marka As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents markb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents markc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents savedatabtn As System.Windows.Forms.Button
    Friend WithEvents listboxmain As System.Windows.Forms.ListBox
    Friend WithEvents deletebtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents databaselink As System.Windows.Forms.LinkLabel
    Friend WithEvents studentidtxt As System.Windows.Forms.TextBox
    Friend WithEvents h As System.Windows.Forms.Label
    Friend WithEvents processbtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
