<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnSub = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGlist = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cmbId = New System.Windows.Forms.ComboBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbIdUpdate = New System.Windows.Forms.ComboBox()
        Me.txtMarkUpdate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNameUpdate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFNameupdate = New System.Windows.Forms.TextBox()
        CType(Me.DGlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.btnSub.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSub.Location = New System.Drawing.Point(102, 287)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(138, 40)
        Me.btnSub.TabIndex = 0
        Me.btnSub.Text = "Submit"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(114, 84)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(77, 31)
        Me.txtId.TabIndex = 1
        Me.txtId.Text = "StuID"
        '
        'txtd
        '
        Me.txtd.Location = New System.Drawing.Point(212, 82)
        Me.txtd.Multiline = True
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(167, 33)
        Me.txtd.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(212, 130)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 33)
        Me.txtName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(212, 177)
        Me.txtFName.Multiline = True
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(167, 33)
        Me.txtFName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Father's Name"
        '
        'txtMob
        '
        Me.txtMob.Location = New System.Drawing.Point(212, 226)
        Me.txtMob.Multiline = True
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Size = New System.Drawing.Size(167, 33)
        Me.txtMob.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mob Number"
        '
        'DGlist
        '
        Me.DGlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGlist.Location = New System.Drawing.Point(458, 56)
        Me.DGlist.Name = "DGlist"
        Me.DGlist.RowTemplate.Height = 24
        Me.DGlist.Size = New System.Drawing.Size(530, 213)
        Me.DGlist.TabIndex = 9
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.btnView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnView.Location = New System.Drawing.Point(580, 288)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(276, 51)
        Me.btnView.TabIndex = 10
        Me.btnView.Text = "view"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'cmbId
        '
        Me.cmbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.8!)
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.Location = New System.Drawing.Point(173, 473)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(231, 43)
        Me.cmbId.TabIndex = 11
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Location = New System.Drawing.Point(89, 543)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(186, 41)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete Row"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Cornsilk
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 27)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "For Inserting Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Cornsilk
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(608, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "For Viewing Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Cornsilk
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "For Deleting Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Select StuId"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(567, 434)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Select StuId"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdate.Location = New System.Drawing.Point(626, 638)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(194, 48)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update Row"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cmbIdUpdate
        '
        Me.cmbIdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.8!)
        Me.cmbIdUpdate.FormattingEnabled = True
        Me.cmbIdUpdate.Location = New System.Drawing.Point(735, 423)
        Me.cmbIdUpdate.Name = "cmbIdUpdate"
        Me.cmbIdUpdate.Size = New System.Drawing.Size(231, 43)
        Me.cmbIdUpdate.TabIndex = 17
        '
        'txtMarkUpdate
        '
        Me.txtMarkUpdate.Location = New System.Drawing.Point(736, 576)
        Me.txtMarkUpdate.Multiline = True
        Me.txtMarkUpdate.Name = "txtMarkUpdate"
        Me.txtMarkUpdate.Size = New System.Drawing.Size(167, 33)
        Me.txtMarkUpdate.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(559, 578)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 31)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Update Mob"
        '
        'txtNameUpdate
        '
        Me.txtNameUpdate.Location = New System.Drawing.Point(736, 485)
        Me.txtNameUpdate.Multiline = True
        Me.txtNameUpdate.Name = "txtNameUpdate"
        Me.txtNameUpdate.Size = New System.Drawing.Size(167, 33)
        Me.txtNameUpdate.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(550, 487)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 31)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Update Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Cornsilk
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(647, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 27)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "For Updating Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(545, 526)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(182, 31)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Update FName"
        '
        'txtFNameupdate
        '
        Me.txtFNameupdate.Location = New System.Drawing.Point(735, 524)
        Me.txtFNameupdate.Multiline = True
        Me.txtFNameupdate.Name = "txtFNameupdate"
        Me.txtFNameupdate.Size = New System.Drawing.Size(167, 33)
        Me.txtFNameupdate.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1132, 717)
        Me.Controls.Add(Me.txtFNameupdate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMarkUpdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNameUpdate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cmbIdUpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmbId)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DGlist)
        Me.Controls.Add(Me.txtMob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnSub)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSub As Button
    Friend WithEvents txtId As Label
    Friend WithEvents txtd As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGlist As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents cmbId As ComboBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbIdUpdate As ComboBox
    Friend WithEvents txtMarkUpdate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNameUpdate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFNameupdate As TextBox
End Class
