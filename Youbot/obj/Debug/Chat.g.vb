﻿#ExternalChecksum("C:\Users\Hubert\documents\visual studio 2012\Projects\Youbot\Youbot\Chat.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","AFF9BF2BF0DD4B2F1911029A7766EE89")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34011
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Chat
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents txtTalkTo As System.Windows.Controls.TextBlock
    
    Friend WithEvents scrollViewer As System.Windows.Controls.ScrollViewer
    
    Friend WithEvents txtConvo As System.Windows.Controls.TextBlock
    
    Friend WithEvents chkVoiceOver As System.Windows.Controls.CheckBox
    
    Friend WithEvents txtReply As System.Windows.Controls.TextBox
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/Youbot;component/Chat.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.txtTalkTo = CType(Me.FindName("txtTalkTo"),System.Windows.Controls.TextBlock)
        Me.scrollViewer = CType(Me.FindName("scrollViewer"),System.Windows.Controls.ScrollViewer)
        Me.txtConvo = CType(Me.FindName("txtConvo"),System.Windows.Controls.TextBlock)
        Me.chkVoiceOver = CType(Me.FindName("chkVoiceOver"),System.Windows.Controls.CheckBox)
        Me.txtReply = CType(Me.FindName("txtReply"),System.Windows.Controls.TextBox)
    End Sub
End Class

