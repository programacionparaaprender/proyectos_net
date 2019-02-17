Public Class Form1
    'https://codigoscript.com/2015/08/21/vb-net-tareas-asincronas-con-backgroundworker/

#Region "INICIO"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        Me.BackgroundWorker1.WorkerReportsProgress = True
    End Sub
#End Region

#Region "EVENTOS"
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For x As Integer = 0 To 100
            Threading.Thread.Sleep(100)
            Me.BackgroundWorker1.ReportProgress(1)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If (Not Me.ProgressBar1.Value = 100) Then
            Me.ProgressBar1.Value += e.ProgressPercentage
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("La operación ha sido cancelada.")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Se ha producido un error durante la ejecución: " & e.Error.Message)
        Else
            MessageBox.Show("La operación en segundo plano ha finalizado con éxito.")
        End If
    End Sub

    Private Sub btnCancelarTarea_Click(sender As Object, e As EventArgs) Handles btnCancelarTarea.Click
        If Me.BackgroundWorker1.WorkerSupportsCancellation = True Then
            Me.btnCancelarTarea.Enabled = False
            Me.BackgroundWorker1.CancelAsync()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub

#End Region


End Class
