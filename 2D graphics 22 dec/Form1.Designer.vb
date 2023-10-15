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
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnDraw2 = New System.Windows.Forms.Button()
        Me.btnDraw3 = New System.Windows.Forms.Button()
        Me.btnColorGradiant = New System.Windows.Forms.Button()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.btnDraw.Location = New System.Drawing.Point(834, 636)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(119, 52)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Click1"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnDraw2
        '
        Me.btnDraw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.btnDraw2.Location = New System.Drawing.Point(959, 636)
        Me.btnDraw2.Name = "btnDraw2"
        Me.btnDraw2.Size = New System.Drawing.Size(119, 52)
        Me.btnDraw2.TabIndex = 1
        Me.btnDraw2.Text = "Click2"
        Me.btnDraw2.UseVisualStyleBackColor = True
        '
        'btnDraw3
        '
        Me.btnDraw3.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.btnDraw3.Location = New System.Drawing.Point(1084, 636)
        Me.btnDraw3.Name = "btnDraw3"
        Me.btnDraw3.Size = New System.Drawing.Size(119, 52)
        Me.btnDraw3.TabIndex = 2
        Me.btnDraw3.Text = "Click3"
        Me.btnDraw3.UseVisualStyleBackColor = True
        '
        'btnColorGradiant
        '
        Me.btnColorGradiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColorGradiant.Location = New System.Drawing.Point(729, 636)
        Me.btnColorGradiant.Name = "btnColorGradiant"
        Me.btnColorGradiant.Size = New System.Drawing.Size(99, 52)
        Me.btnColorGradiant.TabIndex = 3
        Me.btnColorGradiant.Text = "Color Gradiante"
        Me.btnColorGradiant.UseVisualStyleBackColor = True
        '
        'btnConnection
        '
        Me.btnConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnection.Location = New System.Drawing.Point(624, 636)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(99, 52)
        Me.btnConnection.TabIndex = 4
        Me.btnConnection.Text = "Show"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1163, 452)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 700)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnConnection)
        Me.Controls.Add(Me.btnColorGradiant)
        Me.Controls.Add(Me.btnDraw3)
        Me.Controls.Add(Me.btnDraw2)
        Me.Controls.Add(Me.btnDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents btnDraw2 As Button
    Friend WithEvents btnDraw3 As Button
    Friend WithEvents btnColorGradiant As Button
    Friend WithEvents btnConnection As Button
    Friend WithEvents ListBox1 As ListBox
End Class
