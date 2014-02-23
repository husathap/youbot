Imports System.Xml.Linq
Imports System.Text
Imports System.IO

Partial Public Class Create
    Inherits PhoneApplicationPage

    Private Contexts As New Dictionary(Of String, String)
    Private textBankI As Integer = 0
    Private textBank As String() = {
        "Derp! An evil kangaroo has appeared.",
        "What do you think about the politics?",
        "Do you like cat?",
        "If an alien wants to destroy the world, what would you do?",
        "A genius is ninety-nine percent talent and our percent effort",
        "Jim has a girlfriend and he has cheated on his previous one!",
        "Angus likes Angus burger!",
        "The calculus professor professes that all professors are confessors!",
        "The passivity is put in this sentence when the sentence is put into the text. The text is written with naunced!",
        "Do you want to give up?",
        "Winners do not do...",
        "When you are depressed, you want to...",
        "There are five people. They are all married. However, there are only nine spouses. What happened?"
        }

    Private Sub txtReply_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtReply.GotFocus
        btnDone.IsEnabled = False
    End Sub

    Private Sub txtReply_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReply.KeyDown

        If e.Key = Key.Enter Then
            Dim yourText = txtReply.Text
            txtReply.Text = ""
            Focus()

            Me.txtConvo.Text += vbNewLine + vbNewLine + "You:" + vbNewLine + yourText + vbNewLine + vbNewLine

            If textBankI < textBank.Length Then

                Dim r As New Random()
                Dim wList = textBank(textBankI).Split()
                Dim ir = r.Next(wList.Length)

                If Contexts.Keys.Contains(wList(ir)) Then
                    Contexts(wList(ir)) = yourText
                Else
                    Contexts.Add(wList(ir), yourText)
                End If

                Me.txtConvo.Text += textBank(textBankI)
                textBankI += 1
            Else
                Me.txtConvo.Text += "The modifiction has run its full length! Press Done to proceed!"
                Me.txtReply.IsEnabled = False
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        Dim xdoc = XDocument.Load("you.xml")

        If xdoc.Root.Attribute("Blank") <> "True" Then
            For Each n In xdoc.Root.Elements
                Contexts.Add(n.Attribute("Words"), n.Value)
            Next
        End If

        Me.txtConvo.Text = "Create or modify Youbot by responding to the following texts. Tap Done when you are done! Reply to this text to begin."
        btnDone.IsEnabled = False
    End Sub

    Private Sub btnDone_Click(sender As Object, e As RoutedEventArgs) Handles btnDone.Click

        Dim xroot = New XElement("Contexts")
        xroot.SetAttributeValue("Name", "Youbot")
        xroot.SetAttributeValue("Blank", "False")
        xroot.SetAttributeValue("Voice", "")
        xroot.SetAttributeValue("Greet", "Youbot Initialized...")

        For Each p In Contexts
            Dim toBeAdded = New XElement("Context")
            toBeAdded.SetAttributeValue("Words", p.Key)
            toBeAdded.SetValue(p.Value)
            xroot.Add(toBeAdded)
        Next

        Dim xdoc = New XDocument(xroot)
        Dim stream = File.Open("you.xml", FileMode.Create)
        xdoc.Save(stream)
        stream.Close()

        'Dim isoFile = IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication()
        'Dim isoStream = New IsolatedStorage.IsolatedStorageFileStream("you.xml", FileMode.OpenOrCreate, isoFile)
        'Dim xw = XmlWriter.Create(isoStream)
        'xdoc.Save(xw)

        NavigationService.Navigate(New Uri("/MainPage.xaml", UriKind.Relative))
        'NavigationService.RemoveBackEntry()
    End Sub

    Private Sub txtReply_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtReply.LostFocus
        btnDone.IsEnabled = True
    End Sub

    Private Sub txtConvo_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles txtConvo.SizeChanged
        scrollViewer.ScrollToVerticalOffset(txtConvo.ActualHeight)
    End Sub
End Class
