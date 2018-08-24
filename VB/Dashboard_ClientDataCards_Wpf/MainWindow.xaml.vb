Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.Xpf.Charts
Imports System
Imports System.Data
Imports System.Windows

Namespace Dashboard_ClientDataCards_Wpf
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        ' Handles the DashboardControl_DashboardItemMouseUp event.
        Private Sub DashboardControl_DashboardItemMouseUp(ByVal sender As Object, ByVal e As DevExpress.DashboardWpf.DashboardItemMouseActionWpfEventArgs)
            If e.DashboardItemName = "cardDashboardItem1" And e.GetAxisPoint() IsNot Nothing Then
                ' Obtains client data related to the clicked card.
                Dim clickedItemData As MultiDimensionalData = e.GetSlice()
                Dim delta As DeltaDescriptor = e.GetDeltas()(0)

                ' Creates a data table that will be used to hold client data.
                Dim dataSource As New DataTable()
                dataSource.Columns.Add("Argument", GetType(Date))
                dataSource.Columns.Add("Actual", GetType(Double))
                dataSource.Columns.Add("Target", GetType(Double))

                ' Saves values of axis points placed on the "sparkline" axis and corresponding
                ' actual/target values to the data table.
                For Each point As AxisPoint In clickedItemData.GetAxisPoints(DashboardDataAxisNames.SparklineAxis)
                    Dim row As DataRow = dataSource.NewRow()
                    Dim deltaValue As DeltaValue = clickedItemData.GetSlice(point).GetDeltaValue(delta)
                    If deltaValue.ActualValue.Value IsNot Nothing AndAlso deltaValue.TargetValue.Value IsNot Nothing Then
                        row("Argument") = point.Value
                        row("Actual") = deltaValue.ActualValue.Value
                        row("Target") = deltaValue.TargetValue.Value
                    Else
                        row("Argument") = DBNull.Value
                        row("Actual") = DBNull.Value
                        row("Target") = DBNull.Value
                    End If
                    dataSource.Rows.Add(row)
                Next point
                DisplayDetailedChart(GetFormTitle(clickedItemData), dataSource)
            End If
        End Sub

        ' Creates a new form that is invoked on the card click and 
        ' shows the chart displaying client data.
        Private Sub DisplayDetailedChart(ByVal title As String, ByVal dataSource As DataTable)
            Dim detailWindow As New DetailedChart()
            detailWindow.Title = title

            Dim chart As ChartControl = detailWindow.detailedChartControl
            Dim diagram As New XYDiagram2D()
            chart.Diagram = diagram
            Dim series1 As New SplineAreaSeries2D()
            series1.DisplayName = "Actual"
            Dim series2 As New SplineAreaSeries2D()
            series2.DisplayName = "Target"
            diagram.Series.AddRange(New Series() { series1, series2 })

            For Each series As Series In diagram.Series
                series.DataSource = dataSource
                series.ArgumentDataMember = "Argument"
                series.ValueScaleType = ScaleType.Numerical
            Next series

            series1.ValueDataMember = "Actual"
            series2.ValueDataMember = "Target"

            detailWindow.ShowDialog()
        End Sub

        ' Obtains a value of the axis point placed on the "default" axis
        ' to display this value in the invoked form title.
        Private Function GetFormTitle(ByVal clickedItemData As MultiDimensionalData) As String
            Dim clickedPoint As AxisPoint = clickedItemData.GetAxisPoints(DashboardDataAxisNames.DefaultAxis)(0)
            Dim clickedPointValue As String = clickedPoint.Value.ToString()
            Return clickedPointValue
        End Function
    End Class
End Namespace
