Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins

Namespace SchedulerSkinAttributes
    Partial Public Class SkinCustomizationForm
        Inherits Form

        Private targetControl As ISupportLookAndFeel = Nothing
        Private targetSkin As Skin = Nothing
        Private targetSkinElementNames As List(Of String) = Nothing

        Public Sub New(ByVal targetSkin As Skin, ByVal targetControl As ISupportLookAndFeel)
            InitializeComponent()

            Me.targetControl = targetControl
            Me.targetSkin = targetSkin
            targetSkinElementNames = ExtractTargetSkinElementNamesHelper()
            Me.Text = String.Format("SkinCustomizationForm ('{0}' Skin)", targetSkin.Name)

            PopulateSkinElements()
            PopulateElementAttributes()
            cbElementAttributes.SelectedIndex = 0
        End Sub

        Private Sub PopulateElementAttributes()
            ' Static items (SkinElement property names)
            cbElementAttributes.BeginUpdate()
            cbElementAttributes.Items.Add("Offset")
            cbElementAttributes.Items.Add("ContentMargins")
            cbElementAttributes.Items.Add("Size")
            cbElementAttributes.Items.Add("Border")
            cbElementAttributes.Items.Add("Color")
            cbElementAttributes.Items.Add("Image")
            cbElementAttributes.Items.Add("Properties")
            cbElementAttributes.EndUpdate()
        End Sub

        Private Sub PopulateSkinElements()
            lbSkinElements.DataSource = targetSkinElementNames
        End Sub

        Private Function ExtractTargetSkinElementNamesHelper() As List(Of String)
            Dim result As New List(Of String)()
            Dim type As Type = targetSkin.GetType()
            Dim targetSkinElements As Hashtable = DirectCast(type.InvokeMember("Elements", BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.GetProperty, Nothing, targetSkin, New Object() { }), Hashtable)

            For Each dictionaryEntry As DictionaryEntry In targetSkinElements
                result.Add(dictionaryEntry.Key.ToString())
            Next dictionaryEntry

            result.Sort()

            Return result
        End Function

        Private Sub selectionUI_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbSkinElements.SelectedIndexChanged, cbElementAttributes.SelectedIndexChanged
            If lbSkinElements.Items.Count > 0 AndAlso cbElementAttributes.Items.Count > 0 Then
                BindPropertyGrid()
            End If
        End Sub

        Private Sub pgSkinElementItem_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs) Handles pgSkinElementItem.PropertyValueChanged
            DirectCast(targetControl, Control).Refresh()
        End Sub

        Private Sub btnLoadImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadImage.Click
            Using openFileDialog As New OpenFileDialog()
                If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Try
                        Dim element As SkinElement = targetSkin(targetSkinElementNames(lbSkinElements.SelectedIndex))

                        element.Image.Image = Image.FromFile(openFileDialog.FileName)
                        UpdateSkinElementImage(element)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Erorr")
                    End Try
                End If
            End Using
        End Sub

        Private Sub btnClearImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearImage.Click
            Dim element As SkinElement = targetSkin(targetSkinElementNames(lbSkinElements.SelectedIndex))

            element.Image.Image = Nothing
            UpdateSkinElementImage(element)
        End Sub

        Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
            Me.Close()
        End Sub

        Private Sub BindPropertyGrid()
            Dim element As SkinElement = targetSkin(targetSkinElementNames(lbSkinElements.SelectedIndex))
            Dim attribute As Object = element.GetType().InvokeMember(cbElementAttributes.SelectedItem.ToString(), BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.GetProperty, Nothing, element, New Object() { })

            pgSkinElementItem.SelectedObject = attribute
            UpdateSkinElementImage(element)
        End Sub

        Private Sub UpdateSkinElementImage(ByVal element As SkinElement)
            If element.Image IsNot Nothing Then
                pbSkinElementImage.Image = element.Image.Image
                btnLoadImage.Enabled = True
                btnClearImage.Enabled = True
            Else
                pbSkinElementImage.Image = Nothing
                btnLoadImage.Enabled = False
                btnClearImage.Enabled = False
            End If
            DirectCast(targetControl, Control).Refresh()
        End Sub
    End Class
End Namespace
