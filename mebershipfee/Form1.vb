Public Class Form1

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the radio button but leave yealry as checked for default
        rdYearly.Checked = True
        rdOneTimePurchase.Checked = False
        'checkboxes
        chkOn_site.Checked = False
        chkTechSupport.Checked = True
        chkCloudBackup.Checked = True

        'LABEL CLEARING

        lblOptionalCost.Text = ""
        lblSoftwareCost.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim SoftwareCost As Double
        Dim optionalCost As Double

                If rdOneTimePurchase.Checked = False Then
            SoftwareCost = 5000
            lblSoftwareCost.Text = SoftwareCost + ".00"
                ElseIf rdYearly.Checked = False Then
                    SoftwareCost = 20000
            lblSoftwareCost.Text = SoftwareCost + ".00"

        End If
                If chkTechSupport.Checked = True Then
            optionalCost = 3500
            lblOptionalCost.Text = optionalCost  
                ElseIf chkOn_site.Checked = True Then
            optionalCost = 2000
            lblOptionalCost.Text = optionalCost + ".00"
                ElseIf chkCloudBackup.Checked = True Then
            optionalCost = 300
            lblOptionalCost.Text = optionalCost + ".00"

        End If

                If chkTechSupport.Checked = True And chkOn_site.Checked = True And chkCloudBackup.Checked = True Then
            optionalCost = 3500 + 2000 + 300
            lblOptionalCost.Text = optionalCost + ".00"
                ElseIf chkTechSupport.Checked = True And chkCloudBackup.Checked = True Then
            optionalCost = 3500 + +300
            lblOptionalCost.Text = optionalCost + ".00"

                End If

    End Sub

    Private Sub lblOptional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label23.Click

    End Sub
End Class
