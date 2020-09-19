Public Class Form1
    ReadOnly pm = {1989000, 0.33, 4.87, 5.97, 0.642, 1898, 568, 86.8, 102, 0.0146} 'masse i 10^24 kg
    ReadOnly psma = {0, 0.387, 0.723, 1.0, 1.52, 5.2, 9.58, 19.2, 30.05, 39.48} 'halvstore akse i AU
    ReadOnly navn = {"Solen", "Merkur", "Venus", "Jorden", "Mars", "Jupiter", "Saturn", "Uranus", "Neptun", "Pluto"}

    ReadOnly r_0 = {0, 0.4663, 0.7263, 0.9833, 1.5898, 5.2276, 10.0344, 19.8187, 29.9328, 33.9504}
    ReadOnly theta = {0, 4.579, 0.7629, 1.745, 3.737, 4.818, 5.105, 0.6164, 6.0737, 5.109} 'positioner i polære koordinater (AU og Rad) fra 1. jan 2020 kl. 0:00
    ReadOnly v_0 = {0, 47.4, 35.0, 29.8, 24.1, 13.1, 9.7, 6.8, 5.4, 4.7} 'km/s

    Dim pfx(9) 'kraften i x-retningen
    Dim pfy(9) 'kraft i y-retning   
    Dim distSq(9, 9)
    Dim directx(9, 9)
    Dim directy(9, 9)

    Dim pax(9)
    Dim pay(9)

    Dim pvx(9)
    Dim pvy(9)

    Dim px(9)
    Dim py(9)

    Dim colorBrush(9)
    Dim dato As Date = #1/01/2020 12:00 AM#

    Dim warpto As Date
    Dim go As Boolean

    Dim time As Double
    Dim dt As Double

    Dim sc = 250 'scaling factor
    Dim offsetx = Me.Width / 2
    Dim offsety = Me.Height / 2

    ReadOnly G = 1.9934951 * 10 ^ -20 'AU^3/(s^2*10^24kg)
    Dim G_emp As Double

    Private Sub init()

        For i As Integer = 0 To 9
            If i > 0 Then
                px(i) = r_0(i) * Math.Sin(theta(i))
                py(i) = r_0(i) * Math.Cos(theta(i))

                'pvx(i) = Math.Sqrt(G * pm(0) * (2 / r_0(i) - 1 / psma(i))) * Math.Cos(theta(i)) 'enhed i AU/s
                'pvy(i) = -Math.Sqrt(G * pm(0) * (2 / r_0(i) - 1 / psma(i))) * Math.Sin(theta(i))

                pvx(i) = v_0(i) * 6.684587 * 10 ^ -9 * Math.Cos(theta(i))
                pvy(i) = -v_0(i) * 6.684587 * 10 ^ -9 * Math.Sin(theta(i)) 'v0 omregnes til AU/s
            Else
                pvx(i) = 0
                pvy(i) = 0
                px(i) = 0
                py(i) = 0
            End If
        Next

        Timer1.Enabled = True
        btnTimer.Text = "Stop"
        go = False
        time = 0.0
        offsetx = Me.Width / 2
        offsety = Me.Height / 2
        dato = #1/01/2020 12:00 AM#
        lblDate.Text = dato
        lblInfo.Text = ""

        colorBrush(0) = New SolidBrush(Color.Orange)
        colorBrush(1) = New SolidBrush(Color.Brown)
        colorBrush(2) = New SolidBrush(Color.DarkOrange)
        colorBrush(3) = New SolidBrush(Color.DarkBlue)
        colorBrush(4) = New SolidBrush(Color.DarkRed)
        colorBrush(5) = New SolidBrush(Color.Purple)
        colorBrush(6) = New SolidBrush(Color.Gold)
        colorBrush(7) = New SolidBrush(Color.DarkBlue)
        colorBrush(8) = New SolidBrush(Color.LightBlue)
        colorBrush(9) = New SolidBrush(Color.Black)
        pm(0) = 1989000

        If dt < 0 Then
            lbldeltaT.Text = "dt [-10 dage; -1 s]"
            tbardeltaT.Minimum = -864000
            tbardeltaT.Maximum = -1
        ElseIf dt > 0 Then
            lbldeltaT.Text = "dt [1 s; 10 dage]"
            tbardeltaT.Minimum = 1
            tbardeltaT.Maximum = 864000
        End If

        Invalidate()

    End Sub

    'Brugergrænseflade
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1920
        Me.Height = 1080
        dt = 86400 'dt er en halv dag

        cboxAfstandTil.Items.Clear()
        For i As Integer = 0 To 9
            cboxAfstandTil.Items.Add(navn(i))
        Next
        cboxAfstandTil.SelectedIndex = 0

        cboxAfstandFra.Items.Clear()
        For i As Integer = 0 To 9
            cboxAfstandFra.Items.Add(navn(i))
        Next
        cboxAfstandFra.SelectedIndex = 3

        cboxMetode.Items.Clear()
        cboxMetode.Items.Add("Euler-Cromer")
        cboxMetode.Items.Add("Euler")
        cboxMetode.SelectedIndex = 0

        Timer1.Interval = 1

        G_emp = G
        lblGravity.Text = G_emp

        CenterToScreen()
        Call init()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DoubleBuffered = True 'Undgår flickering

        'tegner solsystemet
        Dim pwidth = CInt(5 + sc / 50)
        Dim swidth = CInt(10 + sc / 50)

        e.Graphics.FillEllipse(colorBrush(0), CInt(px(0) * sc + offsetx), CInt(py(0) * sc + offsety), swidth, swidth)

        For i As Integer = 1 To 9
            e.Graphics.FillEllipse(colorBrush(i), CInt(px(i) * sc + offsetx + swidth / 2 - pwidth / 2), CInt(py(i) * sc + offsety + swidth / 2 - pwidth / 2), pwidth, pwidth)
        Next

    End Sub

    'Logik
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += dt / 86400
        dato = DateAdd(DateInterval.Second, dt, dato)
        lblTime.Text = CStr(Format(time, "###0.0")) + " dage"
        lblDate.Text = dato
        lbldt.Text = dt
        Dim i = cboxAfstandTil.SelectedIndex
        Dim j = cboxAfstandFra.SelectedIndex
        lblAfstand.Text = Format(((px(j) - px(i)) ^ 2 + (py(j) - py(i)) ^ 2) ^ 0.5, "###0.0000") + " AU"
        lblVelocity.Text = Format(Math.Sqrt(pvx(j) ^ 2 + pvy(j) ^ 2) * 149597871, "###0.0000") + " km/s"

        If warpto > dato And go = True And dt > 0 Then
            Timer1.Enabled = True
            btnTimer.Text = "Stop"
        ElseIf warpto <= dato And go = True Then
            Timer1.Enabled = False
            btnTimer.Text = "Start"
            btnGoto.Enabled = True
            go = False
        Else
            Timer1.Enabled = True
        End If

        If cboxMetode.SelectedIndex = 0 Then
            Call eulercromer()
        ElseIf cboxMetode.SelectedIndex = 1 Then
            Call euler()
        End If

    End Sub

    Private Sub eulercromer()
        For i As Integer = 0 To 9
            For j As Integer = 0 To 9
                distSq(i, j) = (px(j) - px(i)) ^ 2 + (py(j) - py(i)) ^ 2
                'udregner r^2
                directx(i, j) = (px(j) - px(i)) / Math.Sqrt(distSq(i, j))
                directy(i, j) = (py(j) - py(i)) / Math.Sqrt(distSq(i, j))
                'udregner enhedsvektorens x og y værdi (direction)

                If i <> j Then
                    pfx(i) += (G_emp * pm(i) * pm(j) / distSq(i, j)) * directx(i, j)
                    pfy(i) += (G_emp * pm(i) * pm(j) / distSq(i, j)) * directy(i, j)
                    'udregner den resulterende kraft. Hvis i = j, divideres der med 0.
                End If
            Next

            pax(i) = pfx(i) / pm(i)
            pay(i) = pfy(i) / pm(i)
            'udregner acceleration

            pvx(i) = pvx(i) + pax(i) * dt
            pvy(i) = pvy(i) + pay(i) * dt
            'udregner hastighed

            px(i) = px(i) + pvx(i) * dt
            py(i) = py(i) + pvy(i) * dt
            'udregner position

            pfx(i) = 0
            pfy(i) = 0
            pax(i) = 0
            pay(i) = 0
            'resetter kraft og acceleration

            Invalidate() 'opdaterer UI
        Next
    End Sub

    Private Sub euler()
        For i As Integer = 0 To 9
            For j As Integer = 0 To 9
                distSq(i, j) = (px(j) - px(i)) ^ 2 + (py(j) - py(i)) ^ 2
                directx(i, j) = (px(j) - px(i)) / Math.Sqrt(distSq(i, j))
                directy(i, j) = (py(j) - py(i)) / Math.Sqrt(distSq(i, j))

                If i <> j Then
                    pfx(i) += (G * pm(i) * pm(j) / distSq(i, j)) * directx(i, j)
                    pfy(i) += (G * pm(i) * pm(j) / distSq(i, j)) * directy(i, j)
                End If
            Next

            pax(i) = pfx(i) / pm(i)
            pay(i) = pfy(i) / pm(i)

            px(i) = px(i) + pvx(i) * dt
            py(i) = py(i) + pvy(i) * dt

            pvx(i) = pvx(i) + pax(i) * dt
            pvy(i) = pvy(i) + pay(i) * dt

            pfx(i) = 0
            pfy(i) = 0
            pax(i) = 0
            pay(i) = 0

            Invalidate()
        Next
    End Sub

    'Controls og knapper (UI)
    Private Sub Btn_restart_Click(sender As Object, e As EventArgs) Handles btn_restart.Click
        Call init()
    End Sub

    Private Sub BtnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        If Timer1.Enabled = True Then
            btnTimer.Text = "Start"
            Timer1.Enabled = False
        Else
            btnTimer.Text = "Stop"
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub TbarSpeed_Scroll(sender As Object, e As EventArgs) Handles tbardeltaT.Scroll
        'Timer1.Interval = tbarSpeed.Value
        dt = tbardeltaT.Value
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            offsety -= 10
        End If

        If e.KeyCode = Keys.S Then
            offsety += 10
        End If

        If e.KeyCode = Keys.A Then
            offsetx -= 10
        End If

        If e.KeyCode = Keys.D Then
            offsetx += 10
        End If

        If e.KeyCode = Keys.R Then
            dt = 86400
            lbldeltaT.Text = "dt [1 s; 10 dage]"
            tbardeltaT.Minimum = 1
            tbardeltaT.Maximum = 864000
            tbardeltaT.Value = dt
        End If

        If e.KeyCode = Keys.C Then
            offsetx = Me.Width / 2
            offsety = Me.Height / 2
        End If

        If e.KeyCode = Keys.B Then
            dt = -dt
            If dt < 0 Then
                lbldeltaT.Text = "dt [-10 dage; -1 s]"
                tbardeltaT.Minimum = -864000
                tbardeltaT.Maximum = -1
            ElseIf dt > 0 Then
                lbldeltaT.Text = "dt [1 s; 10 dage]"
                tbardeltaT.Minimum = 1
                tbardeltaT.Maximum = 864000
            End If
            tbardeltaT.Value = dt
        End If

            If e.KeyCode = Keys.Space Then
            If Timer1.Enabled = True Then
                btnTimer.Text = "Start"
                Timer1.Enabled = False
            Else
                btnTimer.Text = "Stop"
                Timer1.Enabled = True
            End If
        End If

        If e.KeyCode = Keys.P Then
            pm(0) = pm(0) * 3
            colorBrush(0) = New SolidBrush(Color.Black)
            lblInfo.Text = "Sort hul-mode"
        End If

        Invalidate()
    End Sub

    Private Sub CboxMetode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxMetode.SelectedIndexChanged
        init()
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta < 0 And sc > 10 Then
            sc -= 10
            Invalidate()
        ElseIf e.Delta > 0 And sc < 500 Then
            sc += 10
            Invalidate()
        End If
    End Sub

    Private Sub BtnGoto_Click(sender As Object, e As EventArgs) Handles btnGoto.Click
        warpto = cal.SelectionEnd
        go = True
        Timer1.Enabled = True
        btnTimer.Text = "Stop"
        btnGoto.Enabled = False
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Form2.Show
    End Sub

    Private Sub LblGravity_Click(sender As Object, e As EventArgs) Handles lblGravity.Click
        G_emp = Val(tboxG_emp.Text)
        lblGravity.Text = G_emp
        init()
    End Sub
End Class
