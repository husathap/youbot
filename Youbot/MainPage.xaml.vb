Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Imports System.IO
Imports System.Threading.Tasks
Imports Windows.Storage
Imports System.Xml.Linq

Public Module Settings
    Public VoiceOverAllowed As Boolean = False
End Module

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait

        ' Sample code to localize the ApplicationBar
        'BuildLocalizedApplicationBar()

    End Sub

    ' Sample code for building a localized ApplicationBar
    'Private Sub BuildLocalizedApplicationBar()
    '    ' Set the page's ApplicationBar to a new instance of ApplicationBar.
    '    ApplicationBar = New ApplicationBar()

    '    ' Create a new button and set the text value to the localized string from AppResources.
    '    Dim appBarButton As New ApplicationBarIconButton(New Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative))
    '    appBarButton.Text = AppResources.AppBarButtonText
    '    ApplicationBar.Buttons.Add(appBarButton)

    '    ' Create a new menu item with the localized string from AppResources.
    '    Dim appBarMenuItem As New ApplicationBarMenuItem(AppResources.AppBarMenuItemText)
    '    ApplicationBar.MenuItems.Add(appBarMenuItem)
    'End Sub

    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        chkVoiceOver.IsChecked = VoiceOverAllowed
        Dim You = XDocument.Load("you.xml")

        'Disable TalkYouBot if it does not exist.
        If You.Root.Attribute("Blank") = "True" Then
            btnTalkYoubot.IsEnabled = False
            btnDestroyYoubot.IsEnabled = False
        Else
            btnTalkYoubot.IsEnabled = True
            btnDestroyYoubot.IsEnabled = True
        End If
    End Sub

    Private Sub btnELIZAdoge_Click(sender As Object, e As RoutedEventArgs) Handles btnELIZAdoge.Click
        Chat.currentBot = New Bot("ELIZADoge.xml")
        NavigationService.Navigate(New Uri("/Chat.xaml", UriKind.Relative))
    End Sub

    Private Sub btnCreateYoubot_Click(sender As Object, e As RoutedEventArgs) Handles btnCreateYoubot.Click
        NavigationService.Navigate(New Uri("/Create.xaml", UriKind.Relative))
    End Sub

    Private Sub btnTalkYoubot_Click(sender As Object, e As RoutedEventArgs) Handles btnTalkYoubot.Click
        Chat.currentBot = New Bot("you.xml")
        NavigationService.Navigate(New Uri("/Chat.xaml", UriKind.Relative))
    End Sub

    Private Sub btnDestroyYoubot_Click(sender As Object, e As RoutedEventArgs) Handles btnDestroyYoubot.Click
        Dim xroot = <Contexts Blank="True"></Contexts>

        Dim xdoc = New XDocument(xroot)
        Dim stream = File.Open("you.xml", FileMode.Create)
        xdoc.Save(stream)
        stream.Close()

        btnTalkYoubot.IsEnabled = False
        btnDestroyYoubot.IsEnabled = False
    End Sub

    Private Sub chkVoiceOver_Click(sender As Object, e As RoutedEventArgs) Handles chkVoiceOver.Click
        VoiceOverAllowed = chkVoiceOver.IsChecked
    End Sub
End Class