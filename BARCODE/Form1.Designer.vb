<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nud_Count = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.PicBarCode = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butPageSetup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pd_PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(288, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(6, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Priv"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nud_Count)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.PicBarCode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.butPageSetup)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(612, 331)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'nud_Count
        '
        Me.nud_Count.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nud_Count.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Count.Location = New System.Drawing.Point(69, 51)
        Me.nud_Count.Name = "nud_Count"
        Me.nud_Count.Size = New System.Drawing.Size(56, 32)
        Me.nud_Count.TabIndex = 96
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NumericUpDown1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(39, 196)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 32)
        Me.NumericUpDown1.TabIndex = 106
        '
        'PicBarCode
        '
        Me.PicBarCode.BackColor = System.Drawing.Color.White
        Me.PicBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBarCode.Location = New System.Drawing.Point(147, 51)
        Me.PicBarCode.Name = "PicBarCode"
        Me.PicBarCode.Size = New System.Drawing.Size(369, 135)
        Me.PicBarCode.TabIndex = 28
        Me.PicBarCode.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Count"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(103, 32)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Test Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-3, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "L/R"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 26)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Powered By Programmers </ Mohamed Khalil && Ahmed Amen />"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'butPageSetup
        '
        Me.butPageSetup.Location = New System.Drawing.Point(6, 117)
        Me.butPageSetup.Name = "butPageSetup"
        Me.butPageSetup.Size = New System.Drawing.Size(120, 56)
        Me.butPageSetup.TabIndex = 103
        Me.butPageSetup.Text = "PAGE SETUP"
        Me.butPageSetup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(147, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(369, 32)
        Me.TextBox1.TabIndex = 105
        Me.TextBox1.Text = "500"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(252, 18)
        Me.TextBox3.MaxLength = 9
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(157, 32)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'pd_PrintDialog
        '
        Me.pd_PrintDialog.UseEXDialog = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Barcode Generator v1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents butPageSetup As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicBarCode As PictureBox
    Friend WithEvents nud_Count As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents pd_PrintDialog As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
End Class
