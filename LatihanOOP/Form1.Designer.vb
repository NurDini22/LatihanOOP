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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoMatrik = New System.Windows.Forms.TextBox()
        Me.BtnPapar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoliteknik = New System.Windows.Forms.TextBox()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmbilan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombor Matrik"
        '
        'txtNoMatrik
        '
        Me.txtNoMatrik.Location = New System.Drawing.Point(12, 28)
        Me.txtNoMatrik.MaxLength = 12
        Me.txtNoMatrik.Name = "txtNoMatrik"
        Me.txtNoMatrik.Size = New System.Drawing.Size(100, 26)
        Me.txtNoMatrik.TabIndex = 1
        '
        'BtnPapar
        '
        Me.BtnPapar.AutoSize = True
        Me.BtnPapar.Location = New System.Drawing.Point(12, 56)
        Me.BtnPapar.Name = "BtnPapar"
        Me.BtnPapar.Size = New System.Drawing.Size(100, 30)
        Me.BtnPapar.TabIndex = 2
        Me.BtnPapar.Text = "PAPAR"
        Me.BtnPapar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Politeknik"
        '
        'txtPoliteknik
        '
        Me.txtPoliteknik.Location = New System.Drawing.Point(12, 120)
        Me.txtPoliteknik.Name = "txtPoliteknik"
        Me.txtPoliteknik.Size = New System.Drawing.Size(214, 26)
        Me.txtPoliteknik.TabIndex = 4
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(12, 180)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(214, 26)
        Me.txtProgram.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Program"
        '
        'txtAmbilan
        '
        Me.txtAmbilan.Location = New System.Drawing.Point(12, 239)
        Me.txtAmbilan.Name = "txtAmbilan"
        Me.txtAmbilan.Size = New System.Drawing.Size(214, 26)
        Me.txtAmbilan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ambilan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 270)
        Me.Controls.Add(Me.txtAmbilan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPoliteknik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnPapar)
        Me.Controls.Add(Me.txtNoMatrik)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUR DINI BINTI AZHAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoMatrik As TextBox
    Friend WithEvents BtnPapar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPoliteknik As TextBox
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmbilan As TextBox
    Friend WithEvents Label4 As Label
End Class
