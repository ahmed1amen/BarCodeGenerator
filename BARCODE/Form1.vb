Imports System.Drawing.Printing

Public Class Form1
    Private Sub butPageSetup_Click(sender As Object, e As EventArgs) Handles butPageSetup.Click
        Me.PageSetupDialog1.Document = Me.PrintDoc
        Me.PageSetupDialog1.MinMargins.Left = 0
        Me.PageSetupDialog1.PageSettings.Margins.Right = 0
        Me.PageSetupDialog1.PageSettings.Margins.Top = 0
        Me.PageSetupDialog1.PageSettings.Margins.Bottom = 0
        Me.PageSetupDialog1.PageSettings.Margins.Left = 0
        Try
            Me.PageSetupDialog1.PageSettings.PaperSize.PaperName = "USER"
        Catch exception1 As Exception

        End Try
        Me.PageSetupDialog1.ShowDialog()

    End Sub
    Private Sub PrintDocHandler(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim graphics As Graphics = Me.PicBarCode.CreateGraphics
        ev.Graphics.DrawImage(Me.PicBarCode.BackgroundImage, Convert.ToSingle(Me.NumericUpDown1.Value), 0!, CSng(Me.PicBarCode.BackgroundImage.Width), CSng(Me.PicBarCode.BackgroundImage.Height))
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.TextBox3.Text <> "") Then
            AddHandler Me.PrintDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.PrintDocHandler)
            Me.pd_PrintDialog.PrinterSettings.Copies = Convert.ToInt16(Me.nud_Count.Value)
            Me.PrintPreviewDialog1.Document = Me.PrintDoc
            Me.PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Me.PicBarCode.BackgroundImage = Module1.Code128(Me.TextBox3.Text, "A")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.TextBox3.Text <> "") Then
            Me.PageSetupDialog1.Document = Me.PrintDoc
            Me.PageSetupDialog1.MinMargins.Left = 0
            Me.PageSetupDialog1.PageSettings.Margins.Right = 0
            Me.PageSetupDialog1.PageSettings.Margins.Top = 0
            Me.PageSetupDialog1.PageSettings.Margins.Bottom = 0
            Me.PageSetupDialog1.PageSettings.Margins.Left = 0
            Try
                Me.PageSetupDialog1.PageSettings.PaperSize.PaperName = "USER"
            Catch exception1 As Exception

            End Try
            Me.pd_PrintDialog.UseEXDialog = True
            Me.pd_PrintDialog.AllowPrintToFile = False
            Me.pd_PrintDialog.PrinterSettings.Copies = Convert.ToInt16(Me.nud_Count.Value)
            If (Me.pd_PrintDialog.ShowDialog = DialogResult.OK) Then
                Me.PrintDoc.PrinterSettings = Me.pd_PrintDialog.PrinterSettings
                AddHandler Me.PrintDoc.PrintPage, New PrintPageEventHandler(AddressOf Me.PrintDocHandler)
                Me.PrintDoc.Print()
            ElseIf (Me.pd_PrintDialog.ShowDialog = DialogResult.Cancel) Then
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.PicBarCode.BackgroundImage = Module1.Code128(Me.TextBox3.Text, "A")
        Catch exception1 As Exception

        End Try

    End Sub
End Class
