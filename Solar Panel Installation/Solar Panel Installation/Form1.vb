Public Class Form1
    
    ' Class Level Variables

    Dim decPanels As Decimal
    Dim decDeposit As Decimal

    Function ValidateInputFields(ByVal strFirstName As String, ByVal strLastName As String, ByVal strPhone As String, ByVal decPanels As Decimal, ByVal decDeposit As Decimal) As Boolean

        ' ValidateInputFields accepts 5 arguments - strFirstName, strLastName, strPhone, decPanels, and decDeposit
        ' Check all inputs
        ' Return True or False

        If txtFirstName.Text = "" Or txtFirstName.Text = Nothing Then

            MessageBox.Show("Please enter a first name.")
            Return False

        End If

        If txtLastName.Text = "" Or txtLastName.Text = Nothing Then

            MessageBox.Show("Please enter a last name.")
            Return False

        End If

        If txtPhone.Text = "" Or txtPhone.Text = Nothing Then

            MessageBox.Show("Please enter a phone number.")
            Return False

        End If

        If decPanels < 1 Or decPanels > 1000 Then

            MessageBox.Show("Customers are only allowed to purchase an amount of panels within the range of 1-1000.")
            Return False

        End If

        If decDeposit < 1 Then

            MessageBox.Show("Deposit amount must be greater than zero.")
            Return False

        End If

        Return True

    End Function

    Function CalculateCharges(ByVal decPanels As Decimal, ByVal decDeposit As Decimal) As Decimal

        ' CalculateCharges accepts 2 arguments - decPanels and decDeposit
        ' Calculate charges
        ' Substract deposit amount
        ' Show Balance Due

        Dim decTotalCost As Decimal

        If decPanels <= 2 Then

            lblBaseCharge.Text = "2000"
            lblAddPanels.Text = "0"

            decTotalCost = 2000

            lblTotalCost.Text = "2000"

        Else

            lblBaseCharge.Text = "2000"
            lblAddPanels.Text = (300 * (decPanels - 2)).ToString()

            decTotalCost = (300 * (decPanels - 2)) + 2000

            lblTotalCost.Text = decTotalCost.ToString()

        End If

        If chkExpress.Checked Then

            decTotalCost = CDec(decTotalCost * 1.05)

        End If

        decTotalCost = decTotalCost - decDeposit

        lblDeposit.Text = decDeposit.ToString()
        lblBalance.Text = decTotalCost.ToString()

    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If Decimal.TryParse(txtNumOfPanels.Text, decPanels) Then

            If Decimal.TryParse(txtDeposit.Text, decDeposit) Then

                If ValidateInputFields(txtFirstName.Text, txtLastName.Text, txtPhone.Text, decPanels, decDeposit) = True Then

                    lblVerify.Visible = True
                    mnuInstallationCharges.Enabled = True

                End If

            Else

                MessageBox.Show("Please enter a valid number of panels.")

            End If

        Else

            MessageBox.Show("Please enter a valid value for your deposit.")

        End If

    End Sub

    Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click

        ' Clear all textboxes and labels
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtNumOfPanels.Clear()
        txtDeposit.Clear()
        lblBaseCharge.Text = Nothing
        lblAddPanels.Text = Nothing
        lblTotalCost.Text = Nothing
        lblDeposit.Text = Nothing
        lblBalance.Text = Nothing

        ' Make the other groupboxes disappear
        grpCharges.Visible = False
        grpInstallation.Visible = False

        ' Return the focus the first textbox
        txtFirstName.Focus()

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        ' Close the form
        Me.Close()

    End Sub

    Private Sub mnuCostumerInformation_Click(sender As Object, e As EventArgs) Handles mnuCostumerInformation.Click

        If grpInfo.Visible = False Then
            grpInfo.Visible = True
        Else
            grpInfo.Visible = False
        End If

    End Sub

    Private Sub mnuInstallationOptions_Click(sender As Object, e As EventArgs) Handles mnuInstallationOptions.Click

        ' Check if the info groupbox is visible or not
        If grpInfo.Visible = True Then
            grpInstallation.Visible = True
        Else
            MessageBox.Show("Please make sure youve entered your information first")
        End If

    End Sub

    Private Sub mnuInstallationCharges_Click(sender As Object, e As EventArgs) Handles mnuInstallationCharges.Click

        ' Calculate charges
        CalculateCharges(decPanels, decDeposit)

        ' Make the charges groupbox visible
        grpCharges.Visible = True

    End Sub
End Class
