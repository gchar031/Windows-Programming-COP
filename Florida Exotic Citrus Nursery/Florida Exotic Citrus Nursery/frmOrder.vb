Public Class frmOrder
    Private arrRbTrees(2) As RadioButton 'array of three radio buttons
    Private arrChkOp(1) As CheckBox ' array of two check boxes
    Private strtree As String 'the tree selected by the user
    Private Summary As frmSummary

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loading the controls for the array
        arrRbTrees(0) = rbKeyL
        arrRbTrees(1) = rbPersianL
        arrRbTrees(2) = rbMeyerL
        arrChkOp(0) = chkbDelivery
        arrChkOp(1) = chkbPlanting

    End Sub

    Private Sub rbRadTree_CheckedChanged(sender As Object, e As EventArgs) Handles rbKeyL.CheckedChanged,
        rbMeyerL.CheckedChanged, rbPersianL.CheckedChanged
        'we have wired in all of the 3 color radio button to this single event procedure
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then  'this occurs when a user selects a radion button
            strtree = rad.Text
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strResult As String
        Dim blErr As Boolean
        Dim i As Integer
        errP().Clear()    'clear any previous errors there might be

        If txtbFirstN.Text = "" Then
            errP.SetError(txtbFirstN, "You must enter your first name.")
            blErr = True
        End If
        If txtbLastN.Text = "" Then
            errP.SetError(txtbLastN, "You must enter your lasst name.")
            blErr = True
        End If
        If txtbAddress.Text = "" Then
            errP.SetError(txtbAddress, "You must enter your address.")
            blErr = True
        End If
        If mskPhoneNum.Text = "" Then  'if a phone number is not inserted
            errP.SetError(mskPhoneNum, "You must enter your phone number.")
            blErr = True
        End If
        If mskZip.Text = "" Then
            errP.SetError(mskZip, "You must enter your zip code.")
            blErr = True
        End If
        strResult = "Customer Information" & vbCrLf
        strResult = "First Name:" & txtbFirstN.Text & vbCrLf
        strResult = "Last Name:" & txtbLastN.Text & vbCrLf
        strResult = "Address:" & txtbAddress.Text & " " & txtbState.Text &
            " ," & mskZip.Text & vbCrLf
        strResult = "Phone Number: " & mskPhoneNum.Text & vbCrLf
        strResult = "Order:" & vbCr
        strResult = "Tree:" & strtree & vbCrLf
        'MessageBox.Show(strResult, "Your choices", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Summary.lblSummary.Text = strResult
        Summary.ShowDialog()
    End Sub
End Class
