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
        Me.sumBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.sumLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sumBtn
        '
        Me.sumBtn.BackColor = System.Drawing.Color.Cornsilk
        Me.sumBtn.Font = New System.Drawing.Font("Comic Sans MS", 13.2!, System.Drawing.FontStyle.Bold)
        Me.sumBtn.Location = New System.Drawing.Point(477, 140)
        Me.sumBtn.Name = "sumBtn"
        Me.sumBtn.Size = New System.Drawing.Size(201, 88)
        Me.sumBtn.TabIndex = 0
        Me.sumBtn.Text = "Click to Sum"
        Me.sumBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your 1st Number"
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Txt1.Location = New System.Drawing.Point(295, 82)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(108, 50)
        Me.Txt1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your 2nd Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Your 3rd Number"
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.txt3.Location = New System.Drawing.Point(295, 225)
        Me.txt3.Multiline = True
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(108, 50)
        Me.txt3.TabIndex = 6
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.txt2.Location = New System.Drawing.Point(295, 158)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(108, 50)
        Me.txt2.TabIndex = 7
        '
        'sumLbl
        '
        Me.sumLbl.AutoSize = True
        Me.sumLbl.BackColor = System.Drawing.Color.Cyan
        Me.sumLbl.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumLbl.Location = New System.Drawing.Point(236, 330)
        Me.sumLbl.Name = "sumLbl"
        Me.sumLbl.Size = New System.Drawing.Size(325, 46)
        Me.sumLbl.TabIndex = 8
        Me.sumLbl.Text = "Your 3rd Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sumLbl)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sumBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sumBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents sumLbl As Label
End Class
