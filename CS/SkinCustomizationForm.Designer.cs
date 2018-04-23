namespace SchedulerSkinAttributes {
    partial class SkinCustomizationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbSkinElements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgSkinElementItem = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.cbElementAttributes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSkinElementImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkinElementImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSkinElements
            // 
            this.lbSkinElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSkinElements.FormattingEnabled = true;
            this.lbSkinElements.Location = new System.Drawing.Point(15, 35);
            this.lbSkinElements.Name = "lbSkinElements";
            this.lbSkinElements.Size = new System.Drawing.Size(208, 290);
            this.lbSkinElements.TabIndex = 0;
            this.lbSkinElements.SelectedIndexChanged += new System.EventHandler(this.selectionUI_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skin Elements:";
            // 
            // pgSkinElementItem
            // 
            this.pgSkinElementItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pgSkinElementItem.HelpVisible = false;
            this.pgSkinElementItem.Location = new System.Drawing.Point(229, 62);
            this.pgSkinElementItem.Name = "pgSkinElementItem";
            this.pgSkinElementItem.Size = new System.Drawing.Size(215, 263);
            this.pgSkinElementItem.TabIndex = 2;
            this.pgSkinElementItem.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgSkinElementItem_PropertyValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Element attributes:";
            // 
            // cbElementAttributes
            // 
            this.cbElementAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElementAttributes.FormattingEnabled = true;
            this.cbElementAttributes.Location = new System.Drawing.Point(229, 35);
            this.cbElementAttributes.Name = "cbElementAttributes";
            this.cbElementAttributes.Size = new System.Drawing.Size(215, 21);
            this.cbElementAttributes.TabIndex = 4;
            this.cbElementAttributes.SelectedIndexChanged += new System.EventHandler(this.selectionUI_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image:";
            // 
            // pbSkinElementImage
            // 
            this.pbSkinElementImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSkinElementImage.Location = new System.Drawing.Point(450, 35);
            this.pbSkinElementImage.Name = "pbSkinElementImage";
            this.pbSkinElementImage.Size = new System.Drawing.Size(182, 167);
            this.pbSkinElementImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSkinElementImage.TabIndex = 6;
            this.pbSkinElementImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(450, 209);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(87, 23);
            this.btnLoadImage.TabIndex = 7;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(543, 209);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(89, 23);
            this.btnClearImage.TabIndex = 8;
            this.btnClearImage.Text = "Clear";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(579, 302);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(53, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SkinCustomizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 343);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbSkinElementImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbElementAttributes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgSkinElementItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSkinElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SkinCustomizationForm";
            this.Text = "SkinCustomizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSkinElementImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSkinElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid pgSkinElementItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbElementAttributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSkinElementImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Button btnOk;
    }
}