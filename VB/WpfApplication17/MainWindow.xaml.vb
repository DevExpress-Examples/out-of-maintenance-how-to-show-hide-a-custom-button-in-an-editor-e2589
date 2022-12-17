Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Editors

Namespace WpfApplication17

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim bi As MyButtonInfo = TryCast(Me.comboBoxEdit1.Buttons(0), MyButtonInfo)
            If bi.ButtonInfoVisibility = Visibility.Visible Then
                bi.ButtonInfoVisibility = Visibility.Hidden
            Else
                bi.ButtonInfoVisibility = Visibility.Visible
            End If
        End Sub
    End Class

    Public Class MyButtonInfo
        Inherits ButtonInfo

        Public Property ButtonInfoVisibility As Visibility
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
