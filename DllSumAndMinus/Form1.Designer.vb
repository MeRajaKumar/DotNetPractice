<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.txtStuid = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(54, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1st Num"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.txt1.Location = New System.Drawing.Point(199, 43)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(160, 42)
        Me.txt1.TabIndex = 1
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.SlateGray
        Me.btnSum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.btnSum.Location = New System.Drawing.Point(60, 191)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(123, 49)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "SUM"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.txt2.Location = New System.Drawing.Point(199, 114)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(160, 41)
        Me.txt2.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblResult.Location = New System.Drawing.Point(104, 356)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(119, 35)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result Is"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(54, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "2st Num"
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.SlateGray
        Me.btnMinus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.btnMinus.Location = New System.Drawing.Point(221, 191)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(123, 49)
        Me.btnMinus.TabIndex = 8
        Me.btnMinus.Text = "Minus"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'txtStuid
        '
        Me.txtStuid.Location = New System.Drawing.Point(670, 181)
        Me.txtStuid.Multiline = True
        Me.txtStuid.Name = "txtStuid"
        Me.txtStuid.Size = New System.Drawing.Size(204, 32)
        Me.txtStuid.TabIndex = 9
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(670, 287)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(204, 32)
        Me.txtFname.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(670, 234)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 32)
        Me.txtName.TabIndex = 11
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(670, 344)
        Me.txtMobile.Multiline = True
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(204, 32)
        Me.txtMobile.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(497, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "StuID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(497, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mobile No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(497, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 31)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "F Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label6.Location = New System.Drawing.Point(497, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 31)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Your Name"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.SlateGray
        Me.btnInsert.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.btnInsert.Location = New System.Drawing.Point(631, 408)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(171, 42)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "Insert Data"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnMultiple
        '
        Me.btnMultiple.BackColor = System.Drawing.Color.SlateGray
        Me.btnMultiple.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.0!)
        Me.btnMultiple.Location = New System.Drawing.Point(137, 257)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(123, 49)
        Me.btnMultiple.TabIndex = 18
        Me.btnMultiple.Text = "Multiple"
        Me.btnMultiple.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1025, 653)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtStuid)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents txtStuid As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnMultiple As Button
End Class
