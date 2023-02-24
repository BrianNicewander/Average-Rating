Public Class AverageRating
	'Application figures the Average Ratining of 5 hotel items.
	'Application uses varibales and constants to do math based on user input.
	'Last Updated: 2/12/19
	'By: Brian Nicewander

	Const decfive As Decimal = 5

    Private Sub AverageRating1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads the current date and time onto the form when the application is launched
        lblLiveDate.Text = Now.ToString("D")
        lblLiveTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        'Figures charges based on user input and isplays output in labels.
        '5 user ratings and displays the average

        'Variables
        Dim decService As Decimal
        Dim decTV As Decimal
        Dim decParking As Decimal
        Dim decPool As Decimal
        Dim decInternet As Decimal
        Dim decAverage As Decimal
        Dim decAverage_Rating As Decimal


        'Gets the info entered by the user
        Try
            decService = CDec(txtService.Text)
            decTV = CDec(txtTv.Text)
            decParking = CDec(txtParking.Text)
            decPool = CDec(txtPool.Text)
            decInternet = CDec(txtInternet.Text)

            'Adds up the rating for all the inputs
            decAverage_Rating = decService + decTV + decParking + decPool + decInternet

            'Calculate the average rating
            decAverage = decAverage_Rating / decfive

            'Displays the average rating
            lblAverage.Text = decAverage.ToString

        Catch ex As Exception
            'Display a message to the user to use correct input
            lblStatus.Text = "All boxes must have a number rating"
            txtService.Focus()
        End Try
    End Sub

    Private Sub rbBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlue.CheckedChanged
        'This turns the word Average results in the average lable box Blue
        lblAverage.ForeColor = Color.Blue
    End Sub

    Private Sub rbRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbRed.CheckedChanged
        'This turns the word Average results in the average lable box Red
        lblAverage.ForeColor = Color.Red
    End Sub

    Private Sub rbPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbPurple.CheckedChanged
        'This turns the word Average results in the average lable box Purple
        lblAverage.ForeColor = Color.Purple
    End Sub

    Private Sub rbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged
        'This turns the word Average results in the average lable box Green
        lblAverage.ForeColor = Color.Green
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        'Resets the application for a new Average Rating figure. Resets Date/Time. Clears input.
        'This button does not clear variables, it only obfuscates their values until new calculations are made.

        'Resets Date/Time
        lblLiveDate.Text = Now.ToString("D")
        lblLiveTime.Text = Now.ToString("T")

        'Resets Input
        txtService.Text = String.Empty
        txtTv.Text = String.Empty
        txtParking.Text = String.Empty
        txtPool.Text = String.Empty
        txtInternet.Text = String.Empty

        'Reset color and Error message and set up for values for next use 
        lblAverage.Text = "Average Results"
        lblAverage.ForeColor = Color.Black

        'Set focus on Room Service textbox
        txtService.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Me.Close()
    End Sub

End Class
