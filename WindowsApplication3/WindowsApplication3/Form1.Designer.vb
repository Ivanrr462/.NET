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
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"IAW", "SRI", "HLC", "SAD", "ASO", "EINE", "ASGB"})
        Me.CB1.Location = New System.Drawing.Point(25, 30)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(212, 21)
        Me.CB1.TabIndex = 0
        Me.CB1.Text = "MODULOS"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(138, 87)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(99, 20)
        Me.T1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 287)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.CB1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox

End Class
