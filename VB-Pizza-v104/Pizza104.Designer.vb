<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza104
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtStList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radCrispy = New System.Windows.Forms.RadioButton()
        Me.radFat = New System.Windows.Forms.RadioButton()
        Me.chkTop1 = New System.Windows.Forms.CheckBox()
        Me.chkTop2 = New System.Windows.Forms.CheckBox()
        Me.chkTop3 = New System.Windows.Forms.CheckBox()
        Me.chkTop4 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dteDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBasePrice = New System.Windows.Forms.TextBox()
        Me.txtTop1 = New System.Windows.Forms.TextBox()
        Me.txtTop2 = New System.Windows.Forms.TextBox()
        Me.txtTop3 = New System.Windows.Forms.TextBox()
        Me.txtTop4 = New System.Windows.Forms.TextBox()
        Me.txtToppedPrice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(96, 122)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(260, 38)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(379, 122)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(260, 38)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 294)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Delivery date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(661, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(661, 207)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(260, 38)
        Me.txtPostcode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1626, 339)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(1557, 376)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(260, 38)
        Me.txtQuantity.TabIndex = 15
        Me.txtQuantity.Text = "1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(827, 451)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(318, 72)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtStList
        '
        Me.txtStList.FormattingEnabled = True
        Me.txtStList.ItemHeight = 31
        Me.txtStList.Location = New System.Drawing.Point(96, 537)
        Me.txtStList.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtStList.Name = "txtStList"
        Me.txtStList.Size = New System.Drawing.Size(1721, 376)
        Me.txtStList.TabIndex = 15
        Me.txtStList.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 491)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 32)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of Orders"
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Location = New System.Drawing.Point(1261, 82)
        Me.radThin.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(107, 36)
        Me.radThin.TabIndex = 7
        Me.radThin.TabStop = True
        Me.radThin.Text = "Thin"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radCrispy
        '
        Me.radCrispy.AutoSize = True
        Me.radCrispy.Location = New System.Drawing.Point(1261, 137)
        Me.radCrispy.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radCrispy.Name = "radCrispy"
        Me.radCrispy.Size = New System.Drawing.Size(131, 36)
        Me.radCrispy.TabIndex = 8
        Me.radCrispy.TabStop = True
        Me.radCrispy.Text = "Crispy"
        Me.radCrispy.UseVisualStyleBackColor = True
        '
        'radFat
        '
        Me.radFat.AutoSize = True
        Me.radFat.Location = New System.Drawing.Point(1261, 192)
        Me.radFat.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.radFat.Name = "radFat"
        Me.radFat.Size = New System.Drawing.Size(92, 36)
        Me.radFat.TabIndex = 9
        Me.radFat.TabStop = True
        Me.radFat.Text = "Fat"
        Me.radFat.UseVisualStyleBackColor = True
        '
        'chkTop1
        '
        Me.chkTop1.AutoSize = True
        Me.chkTop1.Location = New System.Drawing.Point(1552, 40)
        Me.chkTop1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop1.Name = "chkTop1"
        Me.chkTop1.Size = New System.Drawing.Size(184, 36)
        Me.chkTop1.TabIndex = 10
        Me.chkTop1.Text = "Anchovies"
        Me.chkTop1.UseVisualStyleBackColor = True
        '
        'chkTop2
        '
        Me.chkTop2.AutoSize = True
        Me.chkTop2.Location = New System.Drawing.Point(1552, 92)
        Me.chkTop2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop2.Name = "chkTop2"
        Me.chkTop2.Size = New System.Drawing.Size(132, 36)
        Me.chkTop2.TabIndex = 11
        Me.chkTop2.Text = "Olives"
        Me.chkTop2.UseVisualStyleBackColor = True
        '
        'chkTop3
        '
        Me.chkTop3.AutoSize = True
        Me.chkTop3.Location = New System.Drawing.Point(1552, 145)
        Me.chkTop3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop3.Name = "chkTop3"
        Me.chkTop3.Size = New System.Drawing.Size(187, 36)
        Me.chkTop3.TabIndex = 12
        Me.chkTop3.Text = "Cabanossi"
        Me.chkTop3.UseVisualStyleBackColor = True
        '
        'chkTop4
        '
        Me.chkTop4.AutoSize = True
        Me.chkTop4.Location = New System.Drawing.Point(1552, 195)
        Me.chkTop4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkTop4.Name = "chkTop4"
        Me.chkTop4.Size = New System.Drawing.Size(181, 36)
        Me.chkTop4.TabIndex = 13
        Me.chkTop4.Text = "Parmesan"
        Me.chkTop4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1247, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 32)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pizza Base"
        '
        'cboHour
        '
        Me.cboHour.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22"})
        Me.cboHour.Location = New System.Drawing.Point(102, 425)
        Me.cboHour.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(177, 39)
        Me.cboHour.TabIndex = 17
        Me.cboHour.Text = "01"
        '
        'cboMinute
        '
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cboMinute.Location = New System.Drawing.Point(374, 425)
        Me.cboMinute.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(196, 39)
        Me.cboMinute.TabIndex = 18
        Me.cboMinute.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 394)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 32)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Hour (24 hr time)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(366, 394)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 32)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Minute"
        '
        'dteDelivery
        '
        Me.dteDelivery.Location = New System.Drawing.Point(102, 332)
        Me.dteDelivery.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dteDelivery.Name = "dteDelivery"
        Me.dteDelivery.Size = New System.Drawing.Size(527, 38)
        Me.dteDelivery.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(379, 176)
        Me.Label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 32)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Subub"
        '
        'txtSuburb
        '
        Me.txtSuburb.Location = New System.Drawing.Point(379, 207)
        Me.txtSuburb.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(260, 38)
        Me.txtSuburb.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(96, 176)
        Me.Label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 32)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Street address"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(96, 207)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(260, 38)
        Me.txtStreet.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(661, 122)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(252, 38)
        Me.txtPhone.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(661, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 32)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Phone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1577, 255)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 32)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Base Pizza Price"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(1557, 294)
        Me.txtBasePrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.ReadOnly = True
        Me.txtBasePrice.Size = New System.Drawing.Size(260, 38)
        Me.txtBasePrice.TabIndex = 36
        Me.txtBasePrice.TabStop = False
        '
        'txtTop1
        '
        Me.txtTop1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop1.Location = New System.Drawing.Point(1440, 42)
        Me.txtTop1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.ReadOnly = True
        Me.txtTop1.Size = New System.Drawing.Size(104, 31)
        Me.txtTop1.TabIndex = 38
        Me.txtTop1.TabStop = False
        Me.txtTop1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop2
        '
        Me.txtTop2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop2.Location = New System.Drawing.Point(1440, 95)
        Me.txtTop2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.ReadOnly = True
        Me.txtTop2.Size = New System.Drawing.Size(104, 31)
        Me.txtTop2.TabIndex = 38
        Me.txtTop2.TabStop = False
        Me.txtTop2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop3
        '
        Me.txtTop3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop3.Location = New System.Drawing.Point(1440, 147)
        Me.txtTop3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop3.Name = "txtTop3"
        Me.txtTop3.ReadOnly = True
        Me.txtTop3.Size = New System.Drawing.Size(104, 31)
        Me.txtTop3.TabIndex = 38
        Me.txtTop3.TabStop = False
        Me.txtTop3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop4
        '
        Me.txtTop4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop4.Location = New System.Drawing.Point(1440, 200)
        Me.txtTop4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTop4.Name = "txtTop4"
        Me.txtTop4.ReadOnly = True
        Me.txtTop4.Size = New System.Drawing.Size(104, 31)
        Me.txtTop4.TabIndex = 38
        Me.txtTop4.TabStop = False
        Me.txtTop4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtToppedPrice
        '
        Me.txtToppedPrice.Location = New System.Drawing.Point(1261, 294)
        Me.txtToppedPrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtToppedPrice.Name = "txtToppedPrice"
        Me.txtToppedPrice.ReadOnly = True
        Me.txtToppedPrice.Size = New System.Drawing.Size(260, 38)
        Me.txtToppedPrice.TabIndex = 36
        Me.txtToppedPrice.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1261, 258)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(180, 32)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Topped price"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(1261, 389)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(260, 38)
        Me.txtTotalPrice.TabIndex = 36
        Me.txtTotalPrice.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1261, 353)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 32)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Total price"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(1264, 458)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(110, 36)
        Me.CheckBox5.TabIndex = 19
        Me.CheckBox5.Text = "Paid"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Pizza104
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1941, 932)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.txtTop4)
        Me.Controls.Add(Me.txtTop3)
        Me.Controls.Add(Me.txtTop2)
        Me.Controls.Add(Me.txtTop1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtToppedPrice)
        Me.Controls.Add(Me.txtBasePrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSuburb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.dteDelivery)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkTop4)
        Me.Controls.Add(Me.chkTop3)
        Me.Controls.Add(Me.chkTop2)
        Me.Controls.Add(Me.chkTop1)
        Me.Controls.Add(Me.radFat)
        Me.Controls.Add(Me.radCrispy)
        Me.Controls.Add(Me.radThin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Pizza104"
        Me.Text = "v1.03 Pizza ordering app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button


    Friend WithEvents txtStList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents radThin As RadioButton
    Friend WithEvents radCrispy As RadioButton
    Friend WithEvents radFat As RadioButton
    Friend WithEvents chkTop1 As CheckBox
    Friend WithEvents chkTop2 As CheckBox
    Friend WithEvents chkTop3 As CheckBox
    Friend WithEvents chkTop4 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents cboMinute As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dteDelivery As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents txtTop1 As TextBox
    Friend WithEvents txtTop2 As TextBox
    Friend WithEvents txtTop3 As TextBox
    Friend WithEvents txtTop4 As TextBox
    Friend WithEvents txtToppedPrice As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CheckBox5 As CheckBox
End Class
