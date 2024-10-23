
Public Class test1
    Dim arrServiceId() As String = {"S01", "S02", "S03", "S04", ""}
    Dim arrServices() As String = {"FoodChuck", "Sarape", "Croffle Haven", "NyorKorchok", "Batik Cantik"}
    Dim arrDateTime() As Date = {#06/21/2023 19:00:00#, #06/21/2023 16:00:00#, #06/21/2023 17:30:00#, #06/21/2023 19:00:00#, #06/21/2023 23:00:00#}
    Dim arrStatus() As String = {"True", "False", "True", "True", "False"}
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplayServices.Click
        FlowLayoutPanel1.Controls.Clear()
        For i = 0 To arrServiceId.Count - 1 Step 1
            If arrServiceId(i) <> "" Then 'if contain id
                Dim fopRequest As New FlowOutAvailableService
                With fopRequest
                    .Name = "fopRequest" & CStr(i + 1)
                    .Size = New Size(585, 125)
                    .lblServiceName.Text = arrServices(i)
                    .lblOperationDateTime.Text = arrDateTime(i)
                    If arrStatus(i) = "True" Then
                        .pcbStatus.Image = My.Resources.icons8_green_circle_24
                        .lblStatus.Text = "Operating..."
                    Else
                        .lblStatus.Text = "Preparing"
                        .pcbStatus.Image = My.Resources.icons8_blue_24
                    End If
                End With
                FlowLayoutPanel1.Controls.Add(fopRequest)
            End If
        Next i
    End Sub

    Private Sub cboHourEnd_DropDown(sender As Object, e As EventArgs) Handles cboHourEnd.DropDown
        If cboHourStart.SelectedIndex <> -1 Then 'if hour is not 12
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex + 1)
        Else 'if hour is 12, set also 
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex)
        End If
    End Sub

    Private Sub btnDifference_Click(sender As Object, e As EventArgs) Handles btnDifference.Click
        'input of date time picker from user
        Dim dateStart As DateTime
        Dim dateEnd As DateTime

        'the input of combo boxes from user
        Dim timeStart As String
        Dim timeEnd As String

        'the variables to store the difference between date and time
        Dim daysRemaining As Single
        Dim timeRemaining As Double

        dateStart = DateTime.Parse(dtpStartOperationDate.Text)
        dateEnd = DateTime.Parse(dtpEndOperationDate.Text)

        timeStart = DateTime.Parse("#" & cboHourStart.SelectedItem & ":" & cboMinuteStart.SelectedItem & ":00 " & cboDayNightStart.SelectedItem & "#")
        timeEnd = DateTime.Parse("#" & cboHourEnd.SelectedItem & ":" & cboMinuteEnd.SelectedItem & ":00 " & cboDayNightEnd.SelectedItem & "#")
        MsgBox("This is " & timeStart & vbNewLine & timeEnd)

        'to find the difference between date
        daysRemaining = (dateEnd - dateStart).TotalDays

        If daysRemaining > 0 Then 'Not in the same day
            'to find the time remaining in hours
            timeRemaining = (DateTime.Parse(timeEnd) - DateTime.Parse(timeStart)).TotalHours + (24 * daysRemaining)

        Else 'in the same day/ earlier day
            'to find the time remaining in hours
            timeRemaining = (DateTime.Parse(timeEnd) - DateTime.Parse(timeStart)).TotalHours
        End If

        If timeRemaining <= 0 Then 'end Operation time is equal or earlier than start operation time
            MsgBox("Please Choose the correct end Date and Time!")
            dtpEndOperationDate.Text = Date.Today 'set back to current date
            cboHourEnd.SelectedItem = cboHourEnd.Items(cboHourStart.SelectedIndex + 1) 'set end operation time to 1 hour after the start operation time
            Exit Sub
        End If

        MsgBox("The days remaining is " & daysRemaining & vbNewLine & "The Time remaining is " & timeRemaining)

        'combine both date and time > save into database
        'datetimeStart = DateTime.Parse("#" & dtpStartOperationDate.Text & " " & cboHourStart.SelectedItem & ":" & cboMinuteStart.SelectedItem & ":00 " & cboDayNightStart.SelectedItem & "#")
        'datetimeEnd = DateTime.Parse("#" & dtpEndOperationDate.Text & " " & cboHourEnd.SelectedItem & ":" & cboMinuteEnd.SelectedItem & ":00 " & cboDayNightEnd.SelectedItem & "#")
        'MsgBox(datetimeStart & vbNewLine & datetimeEnd & vbNewLine)
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Dim datCurrDate As DateTime = Today
        Dim datCurrTime As DateTime = TimeOfDay

        'input of date time picker from user
        Dim dateStart As DateTime
        Dim dateEnd As DateTime

        'the input of combo boxes from user
        Dim timeStart As String
        Dim timeEnd As String

        'the variables to store the difference between date and time
        Dim daysRemainingfromStart As Double
        Dim hoursRemainingfromStart As Double
        Dim daysRemainingToEnd As Double
        Dim hoursRemainingToEnd As Double


        dateStart = DateTime.Parse(dtpStartOperationDate.Text)
        dateEnd = DateTime.Parse(dtpEndOperationDate.Text)

        timeStart = DateTime.Parse("#" & cboHourStart.SelectedItem & ":" & cboMinuteStart.SelectedItem & ":00 " & cboDayNightStart.SelectedItem & "#")
        timeEnd = DateTime.Parse("#" & cboHourEnd.SelectedItem & ":" & cboMinuteEnd.SelectedItem & ":00 " & cboDayNightEnd.SelectedItem & "#")
        MsgBox("This is " & timeStart & vbNewLine & timeEnd)

        'difference between current date and start operation date
        'If start operation date is less than current date (<=0), means that it is on going and available
        daysRemainingfromStart = (dateStart - datCurrDate).TotalDays

        'difference between current date and end operation date
        'If end operation date is exceeding the current date (>=0), which means that it is still available and not Ended
        daysRemainingToEnd = (dateEnd - datCurrDate).TotalDays

        FlowOutRequest1.lblOperationDateTime.Text = "Start Date :" & dateStart.ToShortDateString & vbNewLine & "End Date :" & dateEnd.ToShortDateString

        'check the status of the services by comparing the date
        If daysRemainingfromStart <= 0 AndAlso daysRemainingToEnd >= 0 Then 'current date in between start and end date
            'MsgBox("Status = On Going, since current date is exceeding the operating date, and less than the end operation date")
            'FlowOutRequest1.lblStatus.Text = "On Going..."
            'FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_green_circle_24
            MsgBox("Now is in betwwen the start and end operation date!")
            'Check the status of the services by comparing the time
            hoursRemainingfromStart = (DateTime.Parse(timeStart) - DateTime.Parse(datCurrTime)).TotalHours
            hoursRemainingToEnd = (DateTime.Parse(timeEnd) - DateTime.Parse(datCurrTime)).TotalHours

            If hoursRemainingfromStart <= 0 AndAlso hoursRemainingToEnd > 0 Then 'Current time is in between operation hour
                MsgBox("Status = On Going, since current date in between start and end date. Also in between operation hours")
                FlowOutRequest1.lblStatus.Text = "On Going..."
                FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_green_circle_24

            Else 'its is not in between operation hour, either before start time or after end time

                If hoursRemainingToEnd <= 0 Then 'current is after then operation end time
                    If daysRemainingToEnd = 0 Then 'current date is end date, and current time is closing time
                        MsgBox("Status = Ended ,since current date is after the end date of service")
                        FlowOutRequest1.lblStatus.Text = "Ended..."
                        FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_black_circle_24
                    Else 'current date is not the end date, and current time is closing time
                        MsgBox("Status = Closing ,since now is after the operation hour " & timeStart)
                        FlowOutRequest1.lblStatus.Text = "Closing..."
                        FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_red_24
                    End If
                Else 'current time is before the start time
                    MsgBox("Status = preparing ,since now is before the operation hour " & timeStart)
                    FlowOutRequest1.lblStatus.Text = "Preparing..."
                    FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_blue_24
                End If
            End If
        Else 'current date is either before start date or after the end date

            If daysRemainingToEnd < 0 Then 'current date is after end date of services
                MsgBox("Status = Ended ,since current date is after the end date of service")
                FlowOutRequest1.lblStatus.Text = "Ended..."
                FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_black_circle_24
            Else 'curret date is before the start date of services
                MsgBox("Status = preparing ,since current date is before the start date of service")
                FlowOutRequest1.lblStatus.Text = "Preparing..."
                FlowOutRequest1.pcbStatus.Image = My.Resources.icons8_blue_24
            End If
        End If
    End Sub

    Private Sub test1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'resetting the combo box to its title
        cboHourStart.SelectedItem = cboHourStart.Items(0)
        cboHourEnd.SelectedItem = cboHourEnd.Items(0)
        cboMinuteStart.SelectedItem = cboMinuteStart.Items(0)
        cboMinuteEnd.SelectedItem = cboMinuteEnd.Items(0)
        cboDayNightStart.SelectedItem = cboDayNightStart.Items(0)
        cboDayNightEnd.SelectedItem = cboDayNightEnd.Items(0)
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class