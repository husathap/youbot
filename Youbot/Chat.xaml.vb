Imports Windows.Phone.Speech.Synthesis

Partial Public Class Chat
    Inherits PhoneApplicationPage

    Public Shared currentBot As Bot = Nothing

    Private synth As SpeechSynthesizer = New SpeechSynthesizer()

    Private Sub txtReply_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReply.KeyDown
        If e.Key = Key.Enter Then
            Dim yourText = txtReply.Text
            txtReply.Text = ""
            Focus()

            Me.txtConvo.Text += "You:" + vbNewLine + yourText + vbNewLine + vbNewLine

            Dim wArray = yourText.ToLower.Split()
            Dim fList As List(Of String) = New List(Of String)()

            For Each w In wArray
                If currentBot.Contexts.Keys.Contains(w) Then
                    fList.Add(w)
                End If
            Next

            If fList.Count = 0 Then
                Dim r = New Random()
                Dim ir = r.Next(currentBot.Contexts.Keys.Count)

                Dim rSentence = currentBot.Contexts(currentBot.Contexts.Keys.ElementAt(ir))
                Me.txtConvo.Text += currentBot.Name + ":" + vbNewLine + rSentence + vbNewLine + vbNewLine
                SpeakOutLoud(rSentence)
            ElseIf fList.Count = 1 Then
                Dim sentence = currentBot.Contexts(fList(0))
                Me.txtConvo.Text += currentBot.Name + ":" + vbNewLine + sentence + vbNewLine + vbNewLine
                SpeakOutLoud(sentence)
            Else
                Dim r = New Random()
                Dim ir = r.Next(fList.Count)

                Dim sentence = currentBot.Contexts(fList(ir))
                Me.txtConvo.Text += currentBot.Name + ":" + vbNewLine + sentence + vbNewLine + vbNewLine
                SpeakOutLoud(sentence)
            End If
        End If
    End Sub

    Private Async Sub SpeakOutLoud(ByVal Input As String)
        If VoiceOverAllowed Then
            Await synth.SpeakTextAsync(Input)
        End If
    End Sub

    Public Sub New()
        InitializeComponent()

        chkVoiceOver.IsChecked = VoiceOverAllowed

        Me.txtTalkTo.Text = "Talking to: " + currentBot.Name
        Me.txtConvo.Text = currentBot.Name + ":" + vbNewLine + currentBot.Greet + vbNewLine + vbNewLine

        If currentBot.Voice = "" Then
            synth.SetVoice(InstalledVoices.Default)
        Else
            synth.SetVoice(InstalledVoices.All(Integer.Parse(currentBot.Voice)))
        End If

        SpeakOutLoud(currentBot.Greet)

    End Sub

    Private Sub chkVoiceOver_Click(sender As Object, e As RoutedEventArgs) Handles chkVoiceOver.Click
        VoiceOverAllowed = chkVoiceOver.IsChecked
    End Sub

    Private Sub txtConvo_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles txtConvo.SizeChanged
        scrollViewer.ScrollToVerticalOffset(txtConvo.ActualHeight)
    End Sub
End Class
