<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.CardetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvechname = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.cmbfueltype = New System.Windows.Forms.ComboBox()
        Me.cmbbrand = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.CardetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardetailsDataGridView
        '
        Me.CardetailsDataGridView.AllowUserToAddRows = False
        Me.CardetailsDataGridView.AllowUserToDeleteRows = False
        Me.CardetailsDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        Me.CardetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CardetailsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.CardetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CardetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.CardetailsDataGridView.Location = New System.Drawing.Point(63, 325)
        Me.CardetailsDataGridView.Name = "CardetailsDataGridView"
        Me.CardetailsDataGridView.ReadOnly = True
        Me.CardetailsDataGridView.RowHeadersWidth = 51
        Me.CardetailsDataGridView.RowTemplate.Height = 29
        Me.CardetailsDataGridView.Size = New System.Drawing.Size(679, 230)
        Me.CardetailsDataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "VechileNo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Brand"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Mode"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "FuelType"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sitka Text", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(63, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Vechile No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Sitka Text", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(433, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Brand"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Sitka Text", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(433, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 33)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Model"
        '
        'txtvechname
        '
        Me.txtvechname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvechname.Location = New System.Drawing.Point(204, 90)
        Me.txtvechname.MaxLength = 10
        Me.txtvechname.Name = "txtvechname"
        Me.txtvechname.Size = New System.Drawing.Size(128, 27)
        Me.txtvechname.TabIndex = 1
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(539, 145)
        Me.txtmodel.MaxLength = 5
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(132, 27)
        Me.txtmodel.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Sitka Text", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(63, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 33)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Color"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Sitka Text", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(63, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 33)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fuel Type"
        '
        'txtcolor
        '
        Me.txtcolor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcolor.Location = New System.Drawing.Point(204, 152)
        Me.txtcolor.MaxLength = 6
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(128, 27)
        Me.txtcolor.TabIndex = 2
        '
        'cmbfueltype
        '
        Me.cmbfueltype.FormattingEnabled = True
        Me.cmbfueltype.Items.AddRange(New Object() {"PETROL", "DIESEL", "CNG", "HYBRID"})
        Me.cmbfueltype.Location = New System.Drawing.Point(200, 208)
        Me.cmbfueltype.Name = "cmbfueltype"
        Me.cmbfueltype.Size = New System.Drawing.Size(132, 28)
        Me.cmbfueltype.TabIndex = 3
        '
        'cmbbrand
        '
        Me.cmbbrand.BackColor = System.Drawing.Color.White
        Me.cmbbrand.FormattingEnabled = True
        Me.cmbbrand.Items.AddRange(New Object() {"TATA", "SUZUKI", "M&M", "FORD", "KIA"})
        Me.cmbbrand.Location = New System.Drawing.Point(539, 88)
        Me.cmbbrand.Name = "cmbbrand"
        Me.cmbbrand.Size = New System.Drawing.Size(132, 28)
        Me.cmbbrand.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Sitka Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(433, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 38)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add Car"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Sitka Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(582, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 38)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(723, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 54)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 581)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbbrand)
        Me.Controls.Add(Me.cmbfueltype)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtvechname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CardetailsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Fuel Type"
        CType(Me.CardetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CardetailsDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvechname As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents cmbfueltype As ComboBox
    Friend WithEvents cmbbrand As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
