Imports System.IO
Imports System.Threading.Tasks
Imports Windows.Storage
Imports System.Linq
Imports Windows.ApplicationModel
Imports System.Xml
Imports System.Xml.Linq

''' <summary>
''' This class contains required information for creating a bot.
''' </summary>
Public Class Bot

    Public Property Greet As String

    ''' <summary>
    ''' The name of the bot.
    ''' </summary>
    ''' <value>The new name.</value>
    ''' <returns>The name of the bot.</returns>
    Public Property Name As String

    ''' <summary>
    ''' The name of the string that the bot is using.
    ''' </summary>
    ''' <value>A new voice that the bot can use.</value>
    ''' <returns>The current voice that the bot is using.</returns>
    Public Property Voice As String

    ''' <summary>
    ''' This contains contexts (key words) and the word that the bot will utter back if
    ''' it hears the word.
    ''' </summary>
    Public Property Contexts As Dictionary(Of String, String)

    ''' <summary>
    ''' Create a new bot by importing strings from an xml file.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal fileName As String)
        Dim xd = XDocument.Load(fileName)
        Me.Name = xd.Root.Attribute("Name")
        Me.Voice = xd.Root.Attribute("Voice")
        Me.Greet = xd.Root.Attribute("Greet")

        Me.Contexts = New Dictionary(Of String, String)()

        For Each n In xd.Root.Elements
            Contexts.Add(n.Attribute("Words"), n.Value)
        Next
    End Sub
End Class
