<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblChooseYourPizza = New System.Windows.Forms.Label()
        Me.lblEnjoyYourPizza = New System.Windows.Forms.Label()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(155, 15)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'picDeepDish
        '
        Me.picDeepDish.Image = Global.W2PizzaOrder.My.Resources.Resources.DeepDish
        Me.picDeepDish.Location = New System.Drawing.Point(23, 67)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(198, 196)
        Me.picDeepDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeepDish.TabIndex = 1
        Me.picDeepDish.TabStop = False
        Me.picDeepDish.Visible = False
        '
        'picThinCrust
        '
        Me.picThinCrust.Image = CType(resources.GetObject("picThinCrust.Image"), System.Drawing.Image)
        Me.picThinCrust.Location = New System.Drawing.Point(258, 67)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(198, 196)
        Me.picThinCrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThinCrust.TabIndex = 2
        Me.picThinCrust.TabStop = False
        Me.picThinCrust.Visible = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Location = New System.Drawing.Point(85, 269)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(75, 23)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnThinCrust
        '
        Me.btnThinCrust.Location = New System.Drawing.Point(320, 269)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(75, 23)
        Me.btnThinCrust.TabIndex = 4
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(202, 269)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select Pizza"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblChooseYourPizza
        '
        Me.lblChooseYourPizza.AutoSize = True
        Me.lblChooseYourPizza.Location = New System.Drawing.Point(92, 318)
        Me.lblChooseYourPizza.Name = "lblChooseYourPizza"
        Me.lblChooseYourPizza.Size = New System.Drawing.Size(294, 13)
        Me.lblChooseYourPizza.TabIndex = 9
        Me.lblChooseYourPizza.Text = "Choose a pizza type and then click the ""Select Pizza"" button"
        '
        'lblEnjoyYourPizza
        '
        Me.lblEnjoyYourPizza.AutoSize = True
        Me.lblEnjoyYourPizza.Location = New System.Drawing.Point(196, 344)
        Me.lblEnjoyYourPizza.Name = "lblEnjoyYourPizza"
        Me.lblEnjoyYourPizza.Size = New System.Drawing.Size(86, 13)
        Me.lblEnjoyYourPizza.TabIndex = 10
        Me.lblEnjoyYourPizza.Text = "Enjoy your pizza!"
        Me.lblEnjoyYourPizza.Visible = False
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 439)
        Me.Controls.Add(Me.lblEnjoyYourPizza)
        Me.Controls.Add(Me.lblChooseYourPizza)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents picDeepDish As System.Windows.Forms.PictureBox
    Friend WithEvents picThinCrust As System.Windows.Forms.PictureBox
    Friend WithEvents btnDeepDish As System.Windows.Forms.Button
    Friend WithEvents btnThinCrust As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblChooseYourPizza As System.Windows.Forms.Label
    Friend WithEvents lblEnjoyYourPizza As System.Windows.Forms.Label

End Class
