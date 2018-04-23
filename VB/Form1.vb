Imports System
Imports DevExpress.XtraScheduler

Namespace SchedulerSkinAttributes
    Partial Public Class Form1
        Inherits System.Windows.Forms.Form

        Private skinCustomizationForm As SkinCustomizationForm = Nothing

        Public Sub New()
            InitializeComponent()

            schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = False
            schedulerControl1.LookAndFeel.SkinName = "Blue"

            GenerateResources()
            GenerateAppointment()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            If skinCustomizationForm Is Nothing OrElse skinCustomizationForm.IsDisposed Then
                Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.SchedulerSkins.GetSkin(schedulerControl1.LookAndFeel)
                skinCustomizationForm = New SkinCustomizationForm(skin, schedulerControl1)
            End If

            If Not skinCustomizationForm.Visible Then
                skinCustomizationForm.Show(Me)
            End If
        End Sub

        Private Sub GenerateResources()
            schedulerControl1.Storage.BeginUpdate()
            Dim res As Resource = schedulerControl1.Storage.CreateResource(0)
            res.Caption = "First Resource"
            schedulerControl1.Storage.Resources.Add(res)
            res = schedulerControl1.Storage.CreateResource(1)
            res.Caption = "Second Resource"
            schedulerControl1.Storage.Resources.Add(res)
            schedulerControl1.Storage.EndUpdate()
        End Sub

        Private Sub GenerateAppointment()
            Dim schedulerStorage As SchedulerStorage = schedulerControl1.Storage
            Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
            Dim baseTime As Date = Date.Today

            apt.Start = baseTime.AddHours(0.5)
            apt.End = baseTime.AddHours(2)
            apt.Subject = "Test"
            apt.Location = "Office"
            apt.Description = "Test procedure"
            apt.ResourceId = 0

            schedulerStorage.Appointments.Add(apt)

            schedulerControl1.Start = baseTime
        End Sub
    End Class
End Namespace