Public Class frmAboutUs
    Private Sub btnOrgChart_Click(sender As Object, e As EventArgs) Handles btnOrgChart.Click
        frmOrgChartPage.ShowDialog() 'show the organization chart
    End Sub

    Private Sub btnBacktoTop_Click_1(sender As Object, e As EventArgs) Handles btnBacktoTop.Click
        'resetting the vertical scroll
        Me.AutoScrollPosition = New Point(Me.AutoScrollPosition.X, 0)
        Me.VerticalScroll.Value = 0
    End Sub
End Class
