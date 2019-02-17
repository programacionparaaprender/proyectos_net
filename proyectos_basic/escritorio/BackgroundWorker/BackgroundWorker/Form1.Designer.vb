<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelarTarea = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Iniciar tarea"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelarTarea
        '
        Me.btnCancelarTarea.Location = New System.Drawing.Point(48, 116)
        Me.btnCancelarTarea.Name = "btnCancelarTarea"
        Me.btnCancelarTarea.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarTarea.TabIndex = 1
        Me.btnCancelarTarea.Text = "Cancelar tarea"
        Me.btnCancelarTarea.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 235)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(281, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnCancelarTarea)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancelarTarea As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
