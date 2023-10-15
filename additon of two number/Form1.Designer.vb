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
        Me.btnSum = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSum
        '
        Me.btnSum.AutoEllipsis = True
        Me.btnSum.BackColor = System.Drawing.Color.Coral
        Me.btnSum.Location = New System.Drawing.Point(396, 392)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(174, 52)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Add"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label1.Location = New System.Drawing.Point(122, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter any number"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(384, 264)
        Me.txt1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(276, 58)
        Me.txt1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.AutoEllipsis = True
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.Location = New System.Drawing.Point(210, 392)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 52)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 603)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSum)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSum As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btnClear As Button
End Class
