﻿#ExternalChecksum("C:\Users\Hubert\documents\visual studio 2012\Projects\Youbot\Youbot\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","5220C9C90162E0BCA2277BD39AA4CC76")
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
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents btnELIZAdoge As System.Windows.Controls.Button
    
    Friend WithEvents btnTalkYoubot As System.Windows.Controls.Button
    
    Friend WithEvents btnCreateYoubot As System.Windows.Controls.Button
    
    Friend WithEvents btnDestroyYoubot As System.Windows.Controls.Button
    
    Friend WithEvents chkVoiceOver As System.Windows.Controls.CheckBox
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/Youbot;component/MainPage.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.btnELIZAdoge = CType(Me.FindName("btnELIZAdoge"),System.Windows.Controls.Button)
        Me.btnTalkYoubot = CType(Me.FindName("btnTalkYoubot"),System.Windows.Controls.Button)
        Me.btnCreateYoubot = CType(Me.FindName("btnCreateYoubot"),System.Windows.Controls.Button)
        Me.btnDestroyYoubot = CType(Me.FindName("btnDestroyYoubot"),System.Windows.Controls.Button)
        Me.chkVoiceOver = CType(Me.FindName("chkVoiceOver"),System.Windows.Controls.CheckBox)
    End Sub
End Class
