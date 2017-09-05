<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formSummaRuut
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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblSisestatudA = New System.Windows.Forms.Label()
        Me.lblSisestatudB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSumma = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblKorrutis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(15, 60)
        Me.txtA.MaxLength = 8
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 0
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(12, 34)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(57, 13)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "Operand a"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(12, 101)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(57, 13)
        Me.lblB.TabIndex = 3
        Me.lblB.Text = "Operand b"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(15, 127)
        Me.txtB.MaxLength = 8
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 169)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblSisestatudA
        '
        Me.lblSisestatudA.Location = New System.Drawing.Point(175, 60)
        Me.lblSisestatudA.Name = "lblSisestatudA"
        Me.lblSisestatudA.Size = New System.Drawing.Size(102, 13)
        Me.lblSisestatudA.TabIndex = 5
        Me.lblSisestatudA.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSisestatudB
        '
        Me.lblSisestatudB.Location = New System.Drawing.Point(175, 127)
        Me.lblSisestatudB.Name = "lblSisestatudB"
        Me.lblSisestatudB.Size = New System.Drawing.Size(102, 13)
        Me.lblSisestatudB.TabIndex = 6
        Me.lblSisestatudB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Summa"
        '
        'lblSumma
        '
        Me.lblSumma.Location = New System.Drawing.Point(134, 169)
        Me.lblSumma.Name = "lblSumma"
        Me.lblSumma.Size = New System.Drawing.Size(143, 13)
        Me.lblSumma.TabIndex = 9
        Me.lblSumma.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Sisestatud a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sisestatud b"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Korrutis"
        '
        'lblKorrutis
        '
        Me.lblKorrutis.Location = New System.Drawing.Point(134, 211)
        Me.lblKorrutis.Name = "lblKorrutis"
        Me.lblKorrutis.Size = New System.Drawing.Size(143, 13)
        Me.lblKorrutis.TabIndex = 14
        Me.lblKorrutis.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'formSummaRuut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 261)
        Me.Controls.Add(Me.lblKorrutis)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSumma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSisestatudB)
        Me.Controls.Add(Me.lblSisestatudA)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtA)
        Me.Name = "formSummaRuut"
        Me.Text = "Summa ruudu arvutamine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblSisestatudA As Label
    Friend WithEvents lblSisestatudB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSumma As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblKorrutis As Label
End Class
