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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_restart = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnTimer = New System.Windows.Forms.Button()
        Me.cboxAfstandTil = New System.Windows.Forms.ComboBox()
        Me.lblAfstand = New System.Windows.Forms.Label()
        Me.tbardeltaT = New System.Windows.Forms.TrackBar()
        Me.lbldeltaT = New System.Windows.Forms.Label()
        Me.cboxMetode = New System.Windows.Forms.ComboBox()
        Me.cboxAfstandFra = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.cal = New System.Windows.Forms.MonthCalendar()
        Me.btnGoto = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.tboxG_emp = New System.Windows.Forms.TextBox()
        Me.lblGravity = New System.Windows.Forms.Label()
        CType(Me.tbardeltaT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btn_restart
        '
        Me.btn_restart.Location = New System.Drawing.Point(24, 37)
        Me.btn_restart.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_restart.Name = "btn_restart"
        Me.btn_restart.Size = New System.Drawing.Size(138, 42)
        Me.btn_restart.TabIndex = 7
        Me.btn_restart.TabStop = False
        Me.btn_restart.Text = "Restart"
        Me.btn_restart.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(22, 169)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 25)
        Me.lblTime.TabIndex = 19
        Me.lblTime.Text = "[tid]"
        '
        'btnTimer
        '
        Me.btnTimer.Location = New System.Drawing.Point(24, 112)
        Me.btnTimer.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTimer.Name = "btnTimer"
        Me.btnTimer.Size = New System.Drawing.Size(138, 40)
        Me.btnTimer.TabIndex = 20
        Me.btnTimer.TabStop = False
        Me.btnTimer.Text = "Stop"
        Me.btnTimer.UseVisualStyleBackColor = True
        '
        'cboxAfstandTil
        '
        Me.cboxAfstandTil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAfstandTil.FormattingEnabled = True
        Me.cboxAfstandTil.Location = New System.Drawing.Point(192, 37)
        Me.cboxAfstandTil.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxAfstandTil.Name = "cboxAfstandTil"
        Me.cboxAfstandTil.Size = New System.Drawing.Size(160, 33)
        Me.cboxAfstandTil.TabIndex = 21
        '
        'lblAfstand
        '
        Me.lblAfstand.AutoSize = True
        Me.lblAfstand.Location = New System.Drawing.Point(186, 169)
        Me.lblAfstand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAfstand.Name = "lblAfstand"
        Me.lblAfstand.Size = New System.Drawing.Size(95, 25)
        Me.lblAfstand.TabIndex = 22
        Me.lblAfstand.Text = "[afstand]"
        '
        'tbardeltaT
        '
        Me.tbardeltaT.Location = New System.Drawing.Point(16, 273)
        Me.tbardeltaT.Margin = New System.Windows.Forms.Padding(4)
        Me.tbardeltaT.Maximum = 864000
        Me.tbardeltaT.Minimum = 1
        Me.tbardeltaT.Name = "tbardeltaT"
        Me.tbardeltaT.Size = New System.Drawing.Size(240, 90)
        Me.tbardeltaT.SmallChange = 864
        Me.tbardeltaT.TabIndex = 24
        Me.tbardeltaT.TickFrequency = 10000000
        Me.tbardeltaT.Value = 86400
        '
        'lbldeltaT
        '
        Me.lbldeltaT.AutoSize = True
        Me.lbldeltaT.Location = New System.Drawing.Point(22, 244)
        Me.lbldeltaT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldeltaT.Name = "lbldeltaT"
        Me.lbldeltaT.Size = New System.Drawing.Size(167, 25)
        Me.lbldeltaT.TabIndex = 26
        Me.lbldeltaT.Text = "dt [1 s; 10 dage]"
        '
        'cboxMetode
        '
        Me.cboxMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxMetode.FormattingEnabled = True
        Me.cboxMetode.Location = New System.Drawing.Point(386, 37)
        Me.cboxMetode.Margin = New System.Windows.Forms.Padding(6)
        Me.cboxMetode.Name = "cboxMetode"
        Me.cboxMetode.Size = New System.Drawing.Size(170, 33)
        Me.cboxMetode.TabIndex = 27
        '
        'cboxAfstandFra
        '
        Me.cboxAfstandFra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAfstandFra.FormattingEnabled = True
        Me.cboxAfstandFra.Location = New System.Drawing.Point(192, 112)
        Me.cboxAfstandFra.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxAfstandFra.Name = "cboxAfstandFra"
        Me.cboxAfstandFra.Size = New System.Drawing.Size(160, 33)
        Me.cboxAfstandFra.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Afstand til"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "fra (+fokus)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Numerisk metode:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(22, 204)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(66, 25)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "[date]"
        '
        'lblVelocity
        '
        Me.lblVelocity.AutoSize = True
        Me.lblVelocity.Location = New System.Drawing.Point(381, 116)
        Me.lblVelocity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(97, 25)
        Me.lblVelocity.TabIndex = 35
        Me.lblVelocity.Text = "[velocity]"
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(2617, 18)
        Me.cal.Name = "cal"
        Me.cal.TabIndex = 36
        '
        'btnGoto
        '
        Me.btnGoto.Location = New System.Drawing.Point(2687, 347)
        Me.btnGoto.Name = "btnGoto"
        Me.btnGoto.Size = New System.Drawing.Size(152, 42)
        Me.btnGoto.TabIndex = 37
        Me.btnGoto.Text = "Stop ved..."
        Me.btnGoto.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(2851, 1731)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(120, 41)
        Me.btnInfo.TabIndex = 38
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(1421, 40)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(77, 25)
        Me.lblInfo.TabIndex = 39
        Me.lblInfo.Text = "Label1"
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.Location = New System.Drawing.Point(22, 328)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(77, 25)
        Me.lbldt.TabIndex = 42
        Me.lbldt.Text = "Label1"
        '
        'tboxG_emp
        '
        Me.tboxG_emp.Location = New System.Drawing.Point(27, 390)
        Me.tboxG_emp.Name = "tboxG_emp"
        Me.tboxG_emp.Size = New System.Drawing.Size(248, 31)
        Me.tboxG_emp.TabIndex = 44
        '
        'lblGravity
        '
        Me.lblGravity.AutoSize = True
        Me.lblGravity.Location = New System.Drawing.Point(22, 440)
        Me.lblGravity.Name = "lblGravity"
        Me.lblGravity.Size = New System.Drawing.Size(77, 25)
        Me.lblGravity.TabIndex = 45
        Me.lblGravity.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(2974, 1929)
        Me.Controls.Add(Me.lblGravity)
        Me.Controls.Add(Me.tboxG_emp)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnGoto)
        Me.Controls.Add(Me.cal)
        Me.Controls.Add(Me.lblVelocity)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxAfstandFra)
        Me.Controls.Add(Me.cboxMetode)
        Me.Controls.Add(Me.lbldeltaT)
        Me.Controls.Add(Me.tbardeltaT)
        Me.Controls.Add(Me.lblAfstand)
        Me.Controls.Add(Me.cboxAfstandTil)
        Me.Controls.Add(Me.btnTimer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btn_restart)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solsystemet v.1.2"
        CType(Me.tbardeltaT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_restart As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents btnTimer As Button
    Friend WithEvents cboxAfstandTil As ComboBox
    Friend WithEvents lblAfstand As Label
    Friend WithEvents tbardeltaT As TrackBar
    Friend WithEvents lbldeltaT As Label
    Friend WithEvents cboxMetode As ComboBox
    Friend WithEvents cboxAfstandFra As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblVelocity As Label
    Friend WithEvents cal As MonthCalendar
    Friend WithEvents btnGoto As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents tboxG_emp As TextBox
    Friend WithEvents lblGravity As Label
End Class
