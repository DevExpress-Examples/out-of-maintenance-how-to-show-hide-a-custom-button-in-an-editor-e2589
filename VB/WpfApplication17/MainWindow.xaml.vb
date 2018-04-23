Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors

Namespace WpfApplication17
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim bi As MyButtonInfo = TryCast(comboBoxEdit1.Buttons(0), MyButtonInfo)
			If bi.ButtonInfoVisibility = System.Windows.Visibility.Visible Then
				bi.ButtonInfoVisibility = System.Windows.Visibility.Hidden
			Else
				bi.ButtonInfoVisibility = System.Windows.Visibility.Visible
			End If
		End Sub
	End Class


	Public Class MyButtonInfo
		Inherits ButtonInfo
		Public Property ButtonInfoVisibility() As Visibility
			Get
				Return CType(GetValue(ButtonInfoVisibilityProperty), Visibility)
			End Get
			Set(ByVal value As Visibility)
				SetValue(ButtonInfoVisibilityProperty, value)
			End Set
		End Property

		' Using a DependencyProperty as the backing store for ButtonInfoVisibility.  This enables animation, styling, binding, etc...
		Public Shared ReadOnly ButtonInfoVisibilityProperty As DependencyProperty = DependencyProperty.Register("ButtonInfoVisibility", GetType(Visibility), GetType(MyButtonInfo), New UIPropertyMetadata(Visibility.Visible))


	End Class
End Namespace
