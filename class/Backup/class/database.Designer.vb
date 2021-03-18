<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class database
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
        Me.deletebtn = New System.Windows.Forms.Button
        Me.DataGridmain = New System.Windows.Forms.DataGridView
        Me.deleteid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridmain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.Red
        Me.deletebtn.Location = New System.Drawing.Point(368, 419)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(142, 39)
        Me.deletebtn.TabIndex = 0
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'DataGridmain
        '
        Me.DataGridmain.AllowUserToAddRows = False
        Me.DataGridmain.AllowUserToDeleteRows = False
        Me.DataGridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridmain.Location = New System.Drawing.Point(12, 12)
        Me.DataGridmain.Name = "DataGridmain"
        Me.DataGridmain.ReadOnly = True
        Me.DataGridmain.Size = New System.Drawing.Size(877, 309)
        Me.DataGridmain.TabIndex = 1
        '
        'deleteid
        '
        Me.deleteid.Location = New System.Drawing.Point(393, 378)
        Me.deleteid.Name = "deleteid"
        Me.deleteid.Size = New System.Drawing.Size(100, 20)
        Me.deleteid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To Delete an Entry Enter Student ID  Below and press DELETE BUTTON"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(407, 478)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 16)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add a record"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(747, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Re-load Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deleteid)
        Me.Controls.Add(Me.DataGridmain)
        Me.Controls.Add(Me.deletebtn)
        Me.Name = "database"
        Me.Text = "database"
        CType(Me.DataGridmain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deletebtn As System.Windows.Forms.Button
    Friend WithEvents DataGridmain As System.Windows.Forms.DataGridView
    Friend WithEvents deleteid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
