<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        txtName = New TextBox()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(390, 178)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(466, 261)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(75, 23)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStart)
        Controls.Add(txtName)
        Name = "frmStart"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnStart As Button
End Class