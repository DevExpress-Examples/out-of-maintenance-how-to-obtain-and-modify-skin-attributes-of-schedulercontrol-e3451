using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace SchedulerSkinAttributes {
    public partial class SkinCustomizationForm : Form {
        private ISupportLookAndFeel targetControl = null;
        private Skin targetSkin = null;
        private List<string> targetSkinElementNames = null;

        public SkinCustomizationForm(Skin targetSkin, ISupportLookAndFeel targetControl) {
            InitializeComponent();

            this.targetControl = targetControl;
            this.targetSkin = targetSkin;
            targetSkinElementNames = ExtractTargetSkinElementNamesHelper();
            this.Text = string.Format("SkinCustomizationForm ('{0}' Skin)", targetSkin.Name);

            PopulateSkinElements();
            PopulateElementAttributes();
            cbElementAttributes.SelectedIndex = 0;
        }

        private void PopulateElementAttributes() {
            // Static items (SkinElement property names)
            cbElementAttributes.BeginUpdate();
            cbElementAttributes.Items.Add("Offset");
            cbElementAttributes.Items.Add("ContentMargins");
            cbElementAttributes.Items.Add("Size");
            cbElementAttributes.Items.Add("Border");
            cbElementAttributes.Items.Add("Color");
            cbElementAttributes.Items.Add("Image");
            cbElementAttributes.Items.Add("Properties");
            cbElementAttributes.EndUpdate();
        }

        private void PopulateSkinElements() {
            lbSkinElements.DataSource = targetSkinElementNames;
        }

        private List<string> ExtractTargetSkinElementNamesHelper() {
            return targetSkin.GetElements().OfType<SkinElement>().Select(e => e.ElementName).ToList();
        }

        private void selectionUI_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbSkinElements.Items.Count > 0 && cbElementAttributes.Items.Count > 0)
                BindPropertyGrid();
        }

        private void pgSkinElementItem_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            ((Control)targetControl).Refresh();
        }

        private void btnLoadImage_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        SkinElement element = targetSkin[targetSkinElementNames[lbSkinElements.SelectedIndex]];

                        element.Image.Image = Image.FromFile(openFileDialog.FileName);
                        UpdateSkinElementImage(element);
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Erorr");
                    }
                }
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e) {
            SkinElement element = targetSkin[targetSkinElementNames[lbSkinElements.SelectedIndex]];

            element.Image.Image = null;
            UpdateSkinElementImage(element);
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BindPropertyGrid() {
            SkinElement element = targetSkin[targetSkinElementNames[lbSkinElements.SelectedIndex]];
            object attribute = element.GetType().InvokeMember(cbElementAttributes.SelectedItem.ToString(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, element, new object[] { });

            pgSkinElementItem.SelectedObject = attribute;
            UpdateSkinElementImage(element);
        }

        private void UpdateSkinElementImage(SkinElement element) {
            if (element.Image != null) {
                pbSkinElementImage.Image = element.Image.Image;
                btnLoadImage.Enabled = true;
                btnClearImage.Enabled = true;
            } else {
                pbSkinElementImage.Image = null;
                btnLoadImage.Enabled = false;
                btnClearImage.Enabled = false;
            }
            ((Control)targetControl).Refresh();
        }
    }
}
