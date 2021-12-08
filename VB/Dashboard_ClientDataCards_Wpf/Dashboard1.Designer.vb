Namespace Dashboard_ClientDataCards_Wpf

    Partial Class Dashboard1

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim allColumns1 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_ClientDataCards_Wpf.Dashboard1))
            Dim measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim card1 As DevExpress.DashboardCommon.Card = New DevExpress.DashboardCommon.Card()
            Dim cardCompactLayoutTemplate1 As DevExpress.DashboardCommon.CardCompactLayoutTemplate = New DevExpress.DashboardCommon.CardCompactLayoutTemplate()
            Dim dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pieDashboardItem1 = New DevExpress.DashboardCommon.PieDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            CType((Me.pieDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dashboardSqlDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pieDashboardItem1
            ' 
            dimension1.DataMember = "OrderDate"
            Me.pieDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension1})
            Me.pieDashboardItem1.ComponentName = "pieDashboardItem1"
            measure1.DataMember = "Extended Price"
            dimension2.DataMember = "Country"
            Me.pieDashboardItem1.DataItemRepository.Clear()
            Me.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1")
            Me.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem2")
            Me.pieDashboardItem1.DataMember = "SalesPerson"
            Me.pieDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieDashboardItem1.Name = "Pies 1"
            Me.pieDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension2})
            Me.pieDashboardItem1.ShowCaption = True
            Me.pieDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure1})
            ' 
            ' dashboardSqlDataSource1
            ' 
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "nwind.mdb"
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""286"" />"
            table1.Name = "SalesPerson"
            allColumns1.Table = table1
            selectQuery1.Columns.Add(allColumns1)
            selectQuery1.Name = "SalesPerson"
            selectQuery1.Tables.Add(table1)
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            ' 
            ' cardDashboardItem1
            ' 
            measure2.DataMember = "Extended Price"
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDev
            measure3.DataMember = "Extended Price"
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.StdDevp
            cardCompactLayoutTemplate1.BottomSubValue1.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomSubValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            cardCompactLayoutTemplate1.BottomSubValue1.Visible = True
            cardCompactLayoutTemplate1.BottomSubValue2.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomSubValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            cardCompactLayoutTemplate1.BottomSubValue2.Visible = True
            cardCompactLayoutTemplate1.BottomValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.BottomValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            cardCompactLayoutTemplate1.BottomValue.Visible = True
            cardCompactLayoutTemplate1.DeltaIndicator.Visible = True
            cardCompactLayoutTemplate1.MainValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            cardCompactLayoutTemplate1.MainValue.Visible = True
            cardCompactLayoutTemplate1.MinWidth = 125
            cardCompactLayoutTemplate1.Sparkline.Visible = True
            cardCompactLayoutTemplate1.SubValue.DimensionIndex = 0
            cardCompactLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            cardCompactLayoutTemplate1.SubValue.Visible = True
            card1.LayoutTemplate = cardCompactLayoutTemplate1
            card1.AddDataItem("ActualValue", measure2)
            card1.AddDataItem("TargetValue", measure3)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() {card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension3.DataMember = "Sales Person"
            dimension4.DataMember = "OrderDate"
            dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(measure3, "DataItem1")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3")
            Me.cardDashboardItem1.DataMember = "SalesPerson"
            Me.cardDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension3})
            Me.cardDashboardItem1.ShowCaption = False
            Me.cardDashboardItem1.SparklineArgument = dimension4
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.pieDashboardItem1, Me.cardDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pieDashboardItem1
            dashboardLayoutItem1.Weight = 34.41762854144806R
            dashboardLayoutItem2.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem2.Weight = 65.582371458551947R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType((dimension1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dashboardSqlDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource

        Private pieDashboardItem1 As DevExpress.DashboardCommon.PieDashboardItem

        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
    End Class
End Namespace
