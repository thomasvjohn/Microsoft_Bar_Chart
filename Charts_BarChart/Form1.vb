Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    Dim Position0 As New CustomLabel
    Dim Position1 As New CustomLabel
    Dim Position2 As New CustomLabel
    Dim Position3 As New CustomLabel
    Dim Position4 As New CustomLabel
    Dim Position5 As New CustomLabel
    Dim Position6 As New CustomLabel
    Dim Position7 As New CustomLabel
    Dim Position8 As New CustomLabel
    Dim Position9 As New CustomLabel
    Dim Position10 As New CustomLabel
    Dim Position11 As New CustomLabel
    Dim Position12 As New CustomLabel
    Dim Position13 As New CustomLabel
    Dim Position14 As New CustomLabel
    Dim Position15 As New CustomLabel
    Dim Position16 As New CustomLabel
    Dim Position17 As New CustomLabel
    Dim Position18 As New CustomLabel
    Dim Position19 As New CustomLabel
    Dim Position20 As New CustomLabel
    Dim Position21 As New CustomLabel
    Dim Position22 As New CustomLabel
    Dim Position23 As New CustomLabel
    Dim Position24 As New CustomLabel


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Position0)
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Position1)
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Position2)
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Position3)
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Position4)

        'Position0.Text = "tHOMAS1"
        'Position1.Text = "tHOMAS2"
        'Position2.Text = "tHOMAS3"
        'Position3.Text = "tHOMAS4"
        'Position4.Text = "tHOMAS5"

        'Chart1.Series(0).Points.AddXY(0, 5)
        'Chart1.Series(0).Points.AddXY(1, 10)
        'Chart1.Series(0).Points.AddXY(2, 20.2)
        'Chart1.Series(0).Points.AddXY(2.2, 20.4)
        'Chart1.Series(0).Points.AddXY(2.8, 20.6)
        'Chart1.Series(0).Points.AddXY(2.9, 20.8)
        'Chart1.Series(0).Points.AddXY(3, 30)
        'Chart1.Series(0).Points.AddXY(4, 5)

        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(0, 1, "abcdefghiklmnop")
        ''Chart1.ChartAreas(0).AxisX.CustomLabels.Add(1, 2, "abcdefghiklmnop")
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(2, 3, "abcdefghiklmnop")
        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(3, 4, "abcdefghiklmnop")

        'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(1, 2, "07/11/2015", 0, LabelMarkStyle.SideMark, GridTickTypes.TickMark)

        'Chart1.ChartAreas(0).AxisX.Maximum = 10

        'Chart1.Series(0).Points(2).AxisLabel = "07/11/2015"

        'Chart1.Series(0).XValueType = ChartValueType.String("MM-dd")
        'Dim x As New Date(2008, 11, 21)
        'Chart1.Series(0).Points.AddXY(x.ToOADate(), 34)
        Timer1.Enabled = True
    End Sub

    Dim R As Random
    Dim c As Double = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        c = c + 1
        Dim A As Double = CInt(Math.Ceiling(Rnd() * 100)) + 1
        Chart1.Series(0).Points.AddXY(c, A)
        Chart1.Series(0).Points(c - 1).Label = "TEST"
        'Chart1.Series(0).Points(c - 1).LabelAngle = 90
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 0
        'Chart1.Series(0).Points(0).AxisLabel = "TESTING"
    End Sub
End Class
