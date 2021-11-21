Public Class Pizza104
    'set up a record or "class" for a student
    Class STUDENT
        Public studID As Int16
        Public firstName As String
        Public lastName As String
        Public deliveryDate As Date
        Public postcode As String  'even though postcode is a number, we store it as a string
        Public quantity As Byte    'Max quantity is 255 Pizzas
        Public phoneNo As String   'Phone numbers are NEVER used to calculate, so saved as text
        Public street As String
        Public suburb As String
        Public hour As Byte        '# between 0 and 23 - it can never be > 255
        Public minute As Byte      '# between 0 and 59 - it can never be > 255
        Public pizzaBase As String 'short name for base
        Public paid As Boolean
        Public top1 As Boolean
        Public top2 As Boolean
        Public top3 As Boolean
        Public top4 As Boolean
        Public Pflav As String    'Flavour of the pizza

        ' The constructor method called when an object is initialised
        ' This is similar to Python's __init__
        Public Sub New(studId As Int16, firstName As String, lastName As String, deliveryDate As Date,
                       postcode As String, quantity As Byte, phoneNo As String, street As String,
                       suburb As String, hour As Byte, minute As Byte, pizzaBase As String,
                       paid As Boolean, top1 As Boolean, top2 As Boolean, top3 As Boolean,
                       top4 As Boolean, Pflav As String)
            Me.studID = studId
            Me.firstName = firstName
            Me.lastName = lastName
            Me.deliveryDate = deliveryDate
            Me.postcode = postcode
            Me.quantity = quantity
            Me.phoneNo = phoneNo
            Me.street = street
            Me.suburb = suburb
            Me.hour = hour
            Me.minute = minute
            Me.pizzaBase = pizzaBase
            Me.paid = paid
            Me.top1 = top1
            Me.top2 = top2
            Me.top3 = top3
            Me.top4 = top4
            Me.Pflav = Pflav
        End Sub
    End Class

    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0
    Dim basePrice As Single
    Dim top1price As Single
    Dim top2price As Single
    Dim top3price As Single
    Dim top4price As Single
    Dim toppedPrice As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load default prices
        basePrice = 10
        top1price = 0.3
        top2price = 0.45
        top3price = 0.9
        top4price = 1.3

        'display prices
        txtBasePrice.Text = FormatCurrency(basePrice)
        txtTop1.Text = FormatCurrency(top1price)
        txtTop2.Text = FormatCurrency(top2price)
        txtTop3.Text = FormatCurrency(top3price)
        txtTop4.Text = FormatCurrency(top4price)

        'load 4 test records
        ' The order of values passed is the same as the order in the
        ' initialisation method definition (lines 25-29)
        students(0) = New STUDENT(1, "Hungry", "Harry", "28/10/21 6:30:00 PM", "2037", 2, "0243-232-232",
                                  "25 Taylor St", "Glebe", 6, 30, "Fat", True, True, False, True, True, "Pepperoni")
        students(1) = New STUDENT(2, "Bart", "Simpson", "29/10/21 8:45:00 PM", "2037", 3, "0243-444-555",
                                  "20 Taylor St", "Glebe", 8, 45, "Thin", True, False, True, True, True, "TATFTUAE")
        students(2) = New STUDENT(3, "Homer", "Simpson", "29/10/21 7:30:00 PM", "2037", 4, "0243-666-777",
                                  "19 Taylor St", "Glebe", 7, 30, "Thin", False, False, True, True, True, "Hawaiian")
        students(3) = New STUDENT(4, "Lisa", "Simpson", "29/10/21 6:00:00 PM", "2037", 4, "0243-666-777",
                                  "20 Taylor St", "Glebe", 6, 0, "Thin", False, False, True, True, True, "Meatlovers")

        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = "" Then ' First Name Check
            MsgBox("Please enter a First Name", MsgBoxStyle.Exclamation, "First Name Check")
            txtFirstName.Focus()
            Exit Sub
        End If
        If txtLastName.Text = "" Then 'Last Name Check
            MsgBox("Please enter a Last Name", MsgBoxStyle.Exclamation, "Last Name Check")
            txtLastName.Focus()
            Exit Sub
        End If
        If txtPhone.Text = "" Then 'Phone no. Check
            MsgBox("Ensure your phone number has 10 digits", MsgBoxStyle.Exclamation, "Phone # Check")
            txtPhone.Focus()
            Exit Sub
        End If
        Dim spaceCount As Integer
        spaceCount = 0
        For Each c As Char In txtPhone.Text
            If c = " " Then
                spaceCount += 1
            End If
        Next
        If spaceCount > 0 Then
            MsgBox("There are " & spaceCount & " spaces in the phone number. Please ensure there are 10 numbers.", MsgBoxStyle.Exclamation, "Phone # Check")
        End If
        If txtStreet.Text = "" Then 'Street Check
            MsgBox("Please enter a Number and Street", MsgBoxStyle.Exclamation, "Street Name Check")
            txtStreet.Focus()
            Exit Sub
        End If
        If txtSuburb.Text = "" Then 'Suburb Check
            MsgBox("Please enter a Suburb", MsgBoxStyle.Exclamation, "Suburb Name Check")
            txtSuburb.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtPostcode.Text) Then 'Postcode Check
            MsgBox("Please ensure that postcode is numeric", MsgBoxStyle.Exclamation, "Postcode Check")
            txtPostcode.Focus()
            Exit Sub
        Else
            If CInt(txtPostcode.Text) < 999 Or CInt(txtPostcode.Text) > 9999 Then
                MsgBox("Please enter a 4 digit postcode", MsgBoxStyle.Exclamation, "Postcode Check")
                txtPostcode.Focus()
            End If
        End If

        ' Use a SELECT structure to pick out selected crust type
        ' This works because we know only one radio button can be
        ' selected at once. Consider making one of them selected
        ' by default, as if one isn't selected, this block of code
        ' here will cause an error
        Dim selectedType = ""

        Select Case True
            Case radThin.Checked
                selectedType = "Thin"
            Case radCrispy.Checked
                selectedType = "Crispy"
            Case radFat.Checked
                selectedType = "Fat"
        End Select

        ' Create a new element and fill it in with our details
        ' Note: paid checkbox needs to be renamed from the default CheckBox5
        students(studentCount) = New STUDENT(studentCount + 1, txtFirstName.Text, txtLastName.Text, dteDelivery.Text & " " & cboHour.Text & ":" & cboMinute.Text,
                                             txtPostcode.Text, txtQuantity.Text, txtPhone.Text, txtStreet.Text, txtSuburb.Text, cboHour.Text, cboMinute.Text,
                                             selectedType, CheckBox5.Checked, chkTop1.Checked, chkTop2.Checked, chkTop3.Checked, chkTop4.Checked, CBOPFlav.Text)
        studentCount += 1

        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtStreet.Text = ""
        txtSuburb.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = 1
        dteDelivery.Text = ""
        cboHour.Text = "01"
        cboMinute.Text = "00"
        radThin.Checked = False
        radCrispy.Checked = False
        radFat.Checked = False
        chkTop1.Checked = False
        chkTop2.Checked = False
        chkTop3.Checked = False
        chkTop4.Checked = False
        displayList()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        txtStList.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & "-" & students(i).firstName & " " &
                              UCase(students(i).lastName) & "-" & students(i).phoneNo & "- a" &
                              students(i).street & "-" & students(i).suburb & "-" &
                              students(i).postcode & "-q" & students(i).quantity & "-" &
                              students(i).pizzaBase & students(i).Pflav & "-A " & students(i).top1 & ": O " &
                              students(i).top2 & ": C " & students(i).top3 & ": P " &
                              students(i).top4 & ": Del " & students(i).deliveryDate)
        Next
    End Sub

    Private Sub CalcToppedPrice()
        toppedPrice = basePrice
        If chkTop1.Checked Then 'later theese 4 IF statements could be replaced with a loop
            toppedPrice += top1price
        End If
        If chkTop2.Checked Then
            toppedPrice += top2price
        End If
        If chkTop3.Checked Then
            toppedPrice += top3price
        End If
        If chkTop4.Checked Then
            toppedPrice += top4price
        End If
        txtToppedPrice.Text = FormatCurrency(toppedPrice)
    End Sub

    Private Sub chkTop1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop1.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop2.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop3_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop3.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop4_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop4.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub
    Private Sub CalcTotalPrice()
        txtTotalPrice.Text = FormatCurrency(toppedPrice * CInt(txtQuantity.Text))
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.Leave
        CalcTotalPrice()
    End Sub

    Private Sub txtBasePrice_TextChanged(sender As Object, e As EventArgs) Handles txtBasePrice.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub txtToppedPrice_TextChanged(sender As Object, e As EventArgs) Handles txtToppedPrice.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
