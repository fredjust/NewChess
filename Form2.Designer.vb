<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(73, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Active Blanche"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(182, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Case noire"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(73, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 72)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Active noire"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(182, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 72)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Case blanche"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 320)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Thème des couleurs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
