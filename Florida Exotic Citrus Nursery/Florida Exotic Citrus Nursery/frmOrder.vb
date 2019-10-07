'Name: Gilda Charles 6071352
'Date: 10/06/2019
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Public Class frmOrder
    Private arrRbTrees(2) As RadioButton 'array of three radio buttons
    Private arrChkOp(1) As CheckBox ' array of two check boxes
    Private strtree As String 'the tree selected by the user
    Private totalSum As Double 'the total sum of the order
    Private tax As Double 'the tax calculated for the sales
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

    Private Function TotalCost() As Double
        Dim tprice As Double
        Dim optionalp As Double

        If strtree.Contains("Key Lime") Then
            tprice = 15.95
        ElseIf strtree.Contains("Persian Lime") Then
            tprice = 12.95
        ElseIf strtree.Contains("Meyer Lime") Then
            tprice = 13.95
        End If
        If arrChkOp(0).Checked = True Then
            optionalp += 10.0
        End If
        If arrChkOp(1).Checked = True Then
            optionalp += 8
        End If
        Dim quant = Val(txtbQuantity.Text)
        totalSum = (tprice * quant) + optionalp
        tax = totalSum * 0.07
        totalSum = totalSum + tax
        Return totalSum
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strResult As String
        Dim blErr As Boolean
        Dim i As Integer
        Dim total = TotalCost()
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
        If txtbCity.Text = "" Then
            errP.SetError(txtbCity, "You must input a city for the address.")
            blErr = True
        End If
        If txtbState.Text = "" Then
            errP.SetError(txtbState, "You must enter your state name.")
            blErr = True
        End If

        If Not IsNumeric(txtbQuantity.Text) Then
            errP.SetError(txtbQuantity, "You must enter a number.")
            blErr = True
        End If
        'check if the quantity is entered and if it is check to see if the quantity exceeds five
        If txtbQuantity.Text = "" Then
            errP.SetError(txtbQuantity, "You must enter the qunatity of trees you wish to purchase.")
            blErr = True
        End If
        If Val(txtbQuantity.Text) > 5 Then  ' val returns the numbers in the string as a numeric value
            errP.SetError(txtbQuantity, "You cannot purchase more than five trees.")
            blErr = True
        End If

        If mskPhoneNum.MaskCompleted = False Then
            errP.SetError(mskPhoneNum, "You must enter your phone number.")
            blErr = True
        End If
        If mskZip.MaskCompleted = False Then
            errP.SetError(mskZip, "You must enter your zip code.")
            blErr = True
        End If
        If blErr Then 'can't go forward, some of the data is missing or bad
            Exit Sub  'early jump out of this procedure
        End If
        strResult = "Customer Information" & vbCrLf
        strResult &= "First Name:  " & txtbFirstN.Text & vbCrLf
        strResult &= "Last Name:  " & txtbLastN.Text & vbCrLf
        strResult &= "Address:  " & vbCrLf & txtbAddress.Text & vbCrLf
        strResult &= txtbCity.Text & " , " & txtbState.Text & " , " & mskZip.Text & vbCrLf
        strResult &= "Phone Number: " & mskPhoneNum.Text & vbCrLf
        strResult &= "Order:  " & vbCr
        strResult &= "Tree:  " & strtree & vbCrLf
        strResult &= "Quanity:  " & txtbQuantity.Text & vbCrLf
        strResult &= "Optional Services: " & vbCrLf
        For i = 0 To arrChkOp.Length - 1
            If arrChkOp(i).Checked Then
                strResult &= "  " & arrChkOp(i).Text
            End If
        Next
        strResult &= vbCrLf & "Tax: " & FormatCurrency(tax) & vbCrLf
        strResult &= "Total: " & FormatCurrency(totalSum) & vbCrLf
        strResult &= "Your order has been placed."
        If blErr = False Then
            'MessageBox.Show(strResult, "Your choices", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Summary = New frmSummary
            Summary.lblSummary.Text = strResult
            Summary.ShowDialog()
            ' btnClear.PerformClick()   ' simulate the clicking of the clear button
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtbFirstN.Text = ""
        txtbLastN.Text = ""
        txtbAddress.Text = ""
        txtbState.Text = ""
        txtbQuantity.Text = ""
        txtbCity.Text = ""
        mskZip.Clear()
        mskPhoneNum.Clear()
        errP.Clear()
        strtree = " "
        tax = 0
        totalSum = 0
        For i = 0 To arrChkOp.Length - 1
            arrChkOp(i).Checked = False
        Next
        For i = 0 To arrRbTrees.Length - 1
            arrRbTrees(i).Checked = False
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
