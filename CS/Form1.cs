using System;
using DevExpress.XtraScheduler;

namespace SchedulerSkinAttributes {
    public partial class Form1 : System.Windows.Forms.Form {
        private SkinCustomizationForm skinCustomizationForm = null;
        
        public Form1() {
            InitializeComponent();

            schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            schedulerControl1.LookAndFeel.SkinName = "Blue";

            GenerateResources();
            GenerateAppointment();
        }

        private void button1_Click(object sender, System.EventArgs e) {
            if (skinCustomizationForm == null || skinCustomizationForm.IsDisposed) {
                DevExpress.Skins.Skin skin = DevExpress.Skins.SchedulerSkins.GetSkin(schedulerControl1.LookAndFeel);
                skinCustomizationForm = new SkinCustomizationForm(skin, schedulerControl1);
            }

            if (!skinCustomizationForm.Visible)
                skinCustomizationForm.Show(this);
        }

        private void GenerateResources() {
            schedulerControl1.Storage.BeginUpdate();
            Resource res = schedulerControl1.Storage.CreateResource(0);
            res.Caption = "First Resource";
            schedulerControl1.Storage.Resources.Add(res);
            res = schedulerControl1.Storage.CreateResource(1);
            res.Caption = "Second Resource";
            schedulerControl1.Storage.Resources.Add(res);
            schedulerControl1.Storage.EndUpdate();
        }

        private void GenerateAppointment() {
            SchedulerStorage schedulerStorage = schedulerControl1.Storage;
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            DateTime baseTime = DateTime.Today;

            apt.Start = baseTime.AddHours(0.5);
            apt.End = baseTime.AddHours(2);
            apt.Subject = "Test";
            apt.Location = "Office";
            apt.Description = "Test procedure";
            apt.ResourceId = 0;

            schedulerStorage.Appointments.Add(apt);

            schedulerControl1.Start = baseTime;
        }
    }
}