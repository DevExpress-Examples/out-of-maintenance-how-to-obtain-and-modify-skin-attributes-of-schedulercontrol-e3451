Namespace SchedulerSkinAttributes
    Partial Public Class SkinCustomizationForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.lbSkinElements = New System.Windows.Forms.ListBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.pgSkinElementItem = New System.Windows.Forms.PropertyGrid()
            Me.label2 = New System.Windows.Forms.Label()
            Me.cbElementAttributes = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.pbSkinElementImage = New System.Windows.Forms.PictureBox()
            Me.btnLoadImage = New System.Windows.Forms.Button()
            Me.btnClearImage = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            DirectCast(Me.pbSkinElementImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lbSkinElements
            ' 
            Me.lbSkinElements.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.lbSkinElements.FormattingEnabled = True
            Me.lbSkinElements.Location = New System.Drawing.Point(15, 35)
            Me.lbSkinElements.Name = "lbSkinElements"
            Me.lbSkinElements.Size = New System.Drawing.Size(208, 290)
            Me.lbSkinElements.TabIndex = 0
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(77, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Skin Elements:"
            ' 
            ' pgSkinElementItem
            ' 
            Me.pgSkinElementItem.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
            Me.pgSkinElementItem.HelpVisible = False
            Me.pgSkinElementItem.Location = New System.Drawing.Point(229, 62)
            Me.pgSkinElementItem.Name = "pgSkinElementItem"
            Me.pgSkinElementItem.Size = New System.Drawing.Size(215, 263)
            Me.pgSkinElementItem.TabIndex = 2
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(226, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(94, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Element attributes:"
            ' 
            ' cbElementAttributes
            ' 
            Me.cbElementAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbElementAttributes.FormattingEnabled = True
            Me.cbElementAttributes.Location = New System.Drawing.Point(229, 35)
            Me.cbElementAttributes.Name = "cbElementAttributes"
            Me.cbElementAttributes.Size = New System.Drawing.Size(215, 21)
            Me.cbElementAttributes.TabIndex = 4
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(447, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(39, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Image:"
            ' 
            ' pbSkinElementImage
            ' 
            Me.pbSkinElementImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbSkinElementImage.Location = New System.Drawing.Point(450, 35)
            Me.pbSkinElementImage.Name = "pbSkinElementImage"
            Me.pbSkinElementImage.Size = New System.Drawing.Size(182, 167)
            Me.pbSkinElementImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pbSkinElementImage.TabIndex = 6
            Me.pbSkinElementImage.TabStop = False
            ' 
            ' btnLoadImage
            ' 
            Me.btnLoadImage.Location = New System.Drawing.Point(450, 209)
            Me.btnLoadImage.Name = "btnLoadImage"
            Me.btnLoadImage.Size = New System.Drawing.Size(87, 23)
            Me.btnLoadImage.TabIndex = 7
            Me.btnLoadImage.Text = "Load"
            Me.btnLoadImage.UseVisualStyleBackColor = True
            ' 
            ' btnClearImage
            ' 
            Me.btnClearImage.Location = New System.Drawing.Point(543, 209)
            Me.btnClearImage.Name = "btnClearImage"
            Me.btnClearImage.Size = New System.Drawing.Size(89, 23)
            Me.btnClearImage.TabIndex = 8
            Me.btnClearImage.Text = "Clear"
            Me.btnClearImage.UseVisualStyleBackColor = True
            ' 
            ' btnOk
            ' 
            Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOk.Location = New System.Drawing.Point(579, 302)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(53, 23)
            Me.btnOk.TabIndex = 9
            Me.btnOk.Text = "OK"
            Me.btnOk.UseVisualStyleBackColor = True
            ' 
            ' SkinCustomizationForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(644, 343)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.btnClearImage)
            Me.Controls.Add(Me.btnLoadImage)
            Me.Controls.Add(Me.pbSkinElementImage)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.cbElementAttributes)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pgSkinElementItem)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.lbSkinElements)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "SkinCustomizationForm"
            Me.Text = "SkinCustomizationForm"
            DirectCast(Me.pbSkinElementImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents lbSkinElements As System.Windows.Forms.ListBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents pgSkinElementItem As System.Windows.Forms.PropertyGrid
        Private label2 As System.Windows.Forms.Label
        Private WithEvents cbElementAttributes As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private pbSkinElementImage As System.Windows.Forms.PictureBox
        Private WithEvents btnLoadImage As System.Windows.Forms.Button
        Private WithEvents btnClearImage As System.Windows.Forms.Button
        Private WithEvents btnOk As System.Windows.Forms.Button
    End Class
End Namespace