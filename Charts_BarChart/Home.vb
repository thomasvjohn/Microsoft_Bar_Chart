Imports System.Windows.Forms.DataVisualization.Charting

Public Class Home

    Dim S1X, S1Y, S2X, S2Y, S3X, S3Y As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> Nothing AndAlso TextBox2.Text <> Nothing Then
            S1X = Val(TextBox1.Text)
            S1Y = Val(TextBox2.Text)
            HomeChart.Series(0).Points.AddXY(S1X, S1Y)
            S1X = S1X + 1
        Else
            S1X = Val(TextBox1.Text)
            HomeChart.Series(0).Points.AddXY(S1X, Double.NaN)
        End If
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox3.Text <> Nothing AndAlso TextBox4.Text <> Nothing Then
            S2X = Val(TextBox3.Text)
            S2Y = Val(TextBox4.Text)
            HomeChart.Series(1).Points.AddXY(S2X, S2Y)
            S2X = S2X + 1
        Else
            S2X = Val(TextBox3.Text)
            HomeChart.Series(1).Points.AddXY(S2X, Double.NaN)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox5.Text <> Nothing AndAlso TextBox6.Text <> Nothing Then
            S3X = Val(TextBox5.Text)
            S3Y = Val(TextBox6.Text)
            HomeChart.Series(2).Points.AddXY(S3X, S3Y)
            S3X = S3X + 1
        Else
            S3X = Val(TextBox5.Text)
            HomeChart.Series(2).Points.AddXY(S3X, Double.NaN)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        HomeChart.Series(0).Points.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        HomeChart.Series(1).Points.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        HomeChart.Series(2).Points.Clear()
    End Sub

    Private Sub Chart1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HomeChart.MouseDown
        'Call Hit Test Method
        Dim result As HitTestResult = HomeChart.HitTest(e.X, e.Y)
        If result.ChartElementType = ChartElementType.DataPoint Then
            ' reset the previous point selected here     
            HomeChart.Series(0).Points(result.PointIndex).Color = Color.Green
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Series 1 - AVAIABLE
        HomeChart.Series(0).Points.AddXY(1, 24)
        HomeChart.Series(0).Points.AddXY(2, 24)
        HomeChart.Series(0).Points.AddXY(3, Double.NaN)
        HomeChart.Series(0).Points.AddXY(4, 24)
        HomeChart.Series(0).Points.AddXY(5, 1)
        HomeChart.Series(0).Points.AddXY(6, 2)
        HomeChart.Series(0).Points.AddXY(7, 3)
        HomeChart.Series(0).Points.AddXY(8, 4)
        HomeChart.Series(0).Points.AddXY(9, 5)
        HomeChart.Series(0).Points.AddXY(10, 24)
        HomeChart.Series(0).Points.AddXY(11, 6)
        HomeChart.Series(0).Points.AddXY(12, 7)
        HomeChart.Series(0).Points.AddXY(13, 8)
        HomeChart.Series(0).Points.AddXY(14, 9)
        HomeChart.Series(0).Points.AddXY(15, 10)
        HomeChart.Series(0).Points.AddXY(16, 24)
        HomeChart.Series(0).Points.AddXY(17, 11)
        HomeChart.Series(0).Points.AddXY(18, 12)
        HomeChart.Series(0).Points.AddXY(19, 13)
        HomeChart.Series(0).Points.AddXY(20, 14)
        HomeChart.Series(0).Points.AddXY(21, 15)
        HomeChart.Series(0).Points.AddXY(22, 24)
        HomeChart.Series(0).Points.AddXY(23, 16)
        HomeChart.Series(0).Points.AddXY(24, 17)
        HomeChart.Series(0).Points.AddXY(25, 18)
        HomeChart.Series(0).Points.AddXY(26, 19)
        HomeChart.Series(0).Points.AddXY(27, 20)
        HomeChart.Series(0).Points.AddXY(28, Double.NaN)
        HomeChart.Series(0).Points.AddXY(29, 21)
        HomeChart.Series(0).Points.AddXY(30, 22)
        HomeChart.Series(0).Points.AddXY(31, 23)

        'Series 2 - BREAK
        HomeChart.Series(1).Points.AddXY(1, Double.NaN)
        HomeChart.Series(1).Points.AddXY(2, Double.NaN)
        HomeChart.Series(1).Points.AddXY(3, Double.NaN)
        HomeChart.Series(1).Points.AddXY(4, Double.NaN)
        HomeChart.Series(1).Points.AddXY(5, 23)
        HomeChart.Series(1).Points.AddXY(6, 22)
        HomeChart.Series(1).Points.AddXY(7, 21)
        HomeChart.Series(1).Points.AddXY(8, 20)
        HomeChart.Series(1).Points.AddXY(9, 19)
        HomeChart.Series(1).Points.AddXY(10, Double.NaN)
        HomeChart.Series(1).Points.AddXY(11, 18)
        HomeChart.Series(1).Points.AddXY(12, 17)
        HomeChart.Series(1).Points.AddXY(13, 16)
        HomeChart.Series(1).Points.AddXY(14, 15)
        HomeChart.Series(1).Points.AddXY(15, 14)
        HomeChart.Series(1).Points.AddXY(16, Double.NaN)
        HomeChart.Series(1).Points.AddXY(17, 13)
        HomeChart.Series(1).Points.AddXY(18, 12)
        HomeChart.Series(1).Points.AddXY(19, 11)
        HomeChart.Series(1).Points.AddXY(20, 10)
        HomeChart.Series(1).Points.AddXY(21, 9)
        HomeChart.Series(1).Points.AddXY(22, Double.NaN)
        HomeChart.Series(1).Points.AddXY(23, 8)
        HomeChart.Series(1).Points.AddXY(24, 7)
        HomeChart.Series(1).Points.AddXY(25, 6)
        HomeChart.Series(1).Points.AddXY(26, 5)
        HomeChart.Series(1).Points.AddXY(27, 4)
        HomeChart.Series(1).Points.AddXY(28, Double.NaN)
        HomeChart.Series(1).Points.AddXY(29, 3)
        HomeChart.Series(1).Points.AddXY(30, 2)
        HomeChart.Series(1).Points.AddXY(31, 1)

        'HomeChart.Series(1).Points.AddXY(1, Double.NaN)
        'HomeChart.Series(1).Points.AddXY(2, Double.NaN)
        'HomeChart.Series(1).Points.AddXY(3, Double.NaN)
        'HomeChart.Series(1).Points.AddXY(4, Double.NaN)
        'HomeChart.Series(1).Points.AddXY(5, Double.NaN)
        'HomeChart.Series(1).Points.AddXY(6, 1)

        'Series 3 - NO FILE
        HomeChart.Series(2).Points.AddXY(1, Double.NaN)
        HomeChart.Series(2).Points.AddXY(2, Double.NaN)
        HomeChart.Series(2).Points.AddXY(3, 24)
        HomeChart.Series(2).Points.AddXY(4, Double.NaN)
        HomeChart.Series(2).Points.AddXY(5, Double.NaN)
        HomeChart.Series(2).Points.AddXY(6, Double.NaN)
        HomeChart.Series(2).Points.AddXY(7, Double.NaN)
        HomeChart.Series(2).Points.AddXY(8, Double.NaN)
        HomeChart.Series(2).Points.AddXY(9, Double.NaN)
        HomeChart.Series(2).Points.AddXY(10, Double.NaN)
        HomeChart.Series(2).Points.AddXY(11, Double.NaN)
        HomeChart.Series(2).Points.AddXY(12, Double.NaN)
        HomeChart.Series(2).Points.AddXY(13, Double.NaN)
        HomeChart.Series(2).Points.AddXY(14, Double.NaN)
        HomeChart.Series(2).Points.AddXY(15, Double.NaN)
        HomeChart.Series(2).Points.AddXY(16, Double.NaN)
        HomeChart.Series(2).Points.AddXY(17, Double.NaN)
        HomeChart.Series(2).Points.AddXY(18, Double.NaN)
        HomeChart.Series(2).Points.AddXY(19, Double.NaN)
        HomeChart.Series(2).Points.AddXY(20, Double.NaN)
        HomeChart.Series(2).Points.AddXY(21, Double.NaN)
        HomeChart.Series(2).Points.AddXY(22, Double.NaN)
        HomeChart.Series(2).Points.AddXY(23, Double.NaN)
        HomeChart.Series(2).Points.AddXY(24, Double.NaN)
        HomeChart.Series(2).Points.AddXY(25, Double.NaN)
        HomeChart.Series(2).Points.AddXY(26, Double.NaN)
        HomeChart.Series(2).Points.AddXY(27, Double.NaN)
        HomeChart.Series(2).Points.AddXY(28, 24)
        HomeChart.Series(2).Points.AddXY(29, Double.NaN)
        HomeChart.Series(2).Points.AddXY(30, Double.NaN)
        HomeChart.Series(2).Points.AddXY(31, Double.NaN)

        'HomeChart.Series(2).Points.AddXY(1, Double.NaN)
        'HomeChart.Series(2).Points.AddXY(2, Double.NaN)
        'HomeChart.Series(2).Points.AddXY(3, Double.NaN)
        'HomeChart.Series(2).Points.AddXY(4, Double.NaN)
        'HomeChart.Series(2).Points.AddXY(5, Double.NaN)
        'HomeChart.Series(2).Points.AddXY(6, 10)



    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        HomeChart.Series(0).Points.AddXY(1, 24)
        HomeChart.Series(1).Points.AddXY(1, Double.NaN)
        HomeChart.Series(2).Points.AddXY(1, Double.NaN)

        HomeChart.Series(0).Points.AddXY(15, 24)
        
        HomeChart.Series(2).Points.AddXY(15, Double.NaN)

        HomeChart.Series(0).Points.AddXY(3, Double.NaN)
        HomeChart.Series(1).Points.AddXY(3, Double.NaN)
        HomeChart.Series(2).Points.AddXY(3, 24)

        HomeChart.Series(0).Points.AddXY(4, 24)
        HomeChart.Series(1).Points.AddXY(4, Double.NaN)
        HomeChart.Series(2).Points.AddXY(4, Double.NaN)

        HomeChart.Series(0).Points.AddXY(5, 1)
        HomeChart.Series(1).Points.AddXY(5, 23)
        HomeChart.Series(2).Points.AddXY(5, Double.NaN)

    End Sub

    Dim A As Double = 0.0833

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        HomeChart.Series(1).Points.AddXY(15, A)
        A = A + 0.0833
       
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        'A1 - 00:04:41 > 09:24:41
        HomeChart.Series("A1").Points.AddXY(1, Val(Format(Val("9") + (Val("24") / 60) + ((Val("41") / 60) / 100), "00.00")))
        'B1 - 09:24:41 > 10:24:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 9, 24, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        Dim A As Double = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B1").Points.AddXY(1, A)
        'A2 - 10:24:41 > 14:29:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A2").Points.AddXY(1, A)
        'B2 - 14:29:41 > 14:44:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B2").Points.AddXY(1, A)
        'A3 - 14:44:41 > 18:09:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A3").Points.AddXY(1, A)
        'B3 - 18:09:41 > 19:04:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B3").Points.AddXY(1, A)
        'A4 - 19:04:41 > 21:54:41 
        D1 = New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A4").Points.AddXY(1, A)
        'B4 - 21:54:41 > 21:55:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B4").Points.AddXY(1, A)
        'A5 - 21:55:41 > 23:39:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A5").Points.AddXY(1, A)
        'B5 - 23:39:41 > 24:00:00
        D1 = New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B5").Points.AddXY(1, A)

        '---------------------------------------------
        'A1 - 00:04:41 > 09:24:41
        HomeChart.Series("A1").Points.AddXY(2, Val(Format(Val("9") + (Val("24") / 60) + ((Val("41") / 60) / 100), "00.00")))
        'B1 - 09:24:41 > 10:24:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 9, 24, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B1").Points.AddXY(2, A)
        'A2 - 10:24:41 > 14:29:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A2").Points.AddXY(2, A)
        'B2 - 14:29:41 > 14:44:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B2").Points.AddXY(2, A)
        'A3 - 14:44:41 > 18:09:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A3").Points.AddXY(2, A)
        'B3 - 18:09:41 > 19:04:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B3").Points.AddXY(2, A)
        'A4 - 19:04:41 > 21:54:41 
        D1 = New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A4").Points.AddXY(2, A)
        'B4 - 21:54:41 > 21:55:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B4").Points.AddXY(2, A)
        'A5 - 21:55:41 > 23:39:41
        D1 = New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A5").Points.AddXY(2, A)
        'B5 - 23:39:41 > 24:00:00
        D1 = New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        D2 = New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B5").Points.AddXY(2, A)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'A1 - 00:04:41 > 09:24:41
        HomeChart.Series("A1").Points.AddXY(1, Val(Format(Val("9") + (Val("24") / 60) + ((Val("41") / 60) / 100), "00.00")))
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button11.BackColor = Color.Red
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'B1 - 09:24:41 > 10:24:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 9, 24, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        Dim A As Double = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B1").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button12.BackColor = Color.Red
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'A2 - 10:24:41 > 14:29:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 10, 24, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A2").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button13.BackColor = Color.Red
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'B2 - 14:29:41 > 14:44:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 14, 29, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B2").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button17.BackColor = Color.Red
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'A3 - 14:44:41 > 18:09:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 14, 44, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A3").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button14.BackColor = Color.Red
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'B3 - 18:09:41 > 19:04:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 18, 9, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B3").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button18.BackColor = Color.Red
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        'A4 - 19:04:41 > 21:54:41 
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 19, 4, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A4").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button15.BackColor = Color.Red
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        'B4 - 21:54:41 > 21:55:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 21, 54, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B4").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button19.BackColor = Color.Red
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        'A5 - 21:55:41 > 23:39:41
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 21, 55, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("A5").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button16.BackColor = Color.Red
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        'B5 - 23:39:41 > 24:00:00
        Dim D1 As New Date(Now.Year, Now.Month, Now.Day, 23, 39, 41)
        Dim D2 As New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)
        A = Val(Format(DateDiff(DateInterval.Second, D1, D2) / 3600, "00.00"))
        HomeChart.Series("B5").Points.AddXY(1, A)
        HomeChart.Series("NewData").Points.AddXY(1, Double.NaN)
        HomeChart.Series("NoData").Points.AddXY(1, Double.NaN)
        Button20.BackColor = Color.Red
    End Sub

    Dim A1 As New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0)
    Dim A2 As New Date(Now.Year, Now.Month, Now.Day, 0, 4, 41)
    Dim A3 As New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59)

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

        HomeChart.Series("NewData").Points.Clear()
        HomeChart.Series("NoData").Points.Clear()

        A = Val(Format(DateDiff(DateInterval.Second, A1, A2) / 3600, "00.00"))
        HomeChart.Series("NewData").Points.AddXY(3, A)

        A = Val(Format(DateDiff(DateInterval.Second, A2, A3) / 3600, "00.00"))
        HomeChart.Series("NoData").Points.AddXY(3, A)

        A2 = DateAdd(DateInterval.Minute, 5, A2)

    End Sub
End Class

