<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox))
        Me.Filter1but = New System.Windows.Forms.Button()
        Me.Filter2but = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Filter1but
        '
        Me.Filter1but.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filter1but.Location = New System.Drawing.Point(13, 13)
        Me.Filter1but.Name = "Filter1but"
        Me.Filter1but.Size = New System.Drawing.Size(140, 31)
        Me.Filter1but.TabIndex = 0
        Me.Filter1but.Text = "Filter 1"
        Me.Filter1but.UseVisualStyleBackColor = True
        '
        'Filter2but
        '
        Me.Filter2but.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filter2but.Location = New System.Drawing.Point(12, 60)
        Me.Filter2but.Name = "Filter2but"
        Me.Filter2but.Size = New System.Drawing.Size(140, 31)
        Me.Filter2but.TabIndex = 1
        Me.Filter2but.Text = "Filter 2"
        Me.Filter2but.UseVisualStyleBackColor = True
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 103)
        Me.Controls.Add(Me.Filter2but)
        Me.Controls.Add(Me.Filter1but)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toolbox"
        Me.Text = "Toolbox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Filter1but As Button
    Friend WithEvents Filter2but As Button
End Class
