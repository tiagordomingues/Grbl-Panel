﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrblPanel.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Connect.
        '''</summary>
        Friend ReadOnly Property Button_Connection_Text_Connect() As String
            Get
                Return ResourceManager.GetString("Button_Connection_Text_Connect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to And A Port Number In The Format.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_And_A_Port_Number_In_The_Format() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_And_A_Port_Number_In_The_Format", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Connect.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Connect() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Connect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Connect Error.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Connect_Error() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Connect_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Disconnect.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Disconnect() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Disconnect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Or Connect The Cable.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Or_Connect_The_Cable() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Or_Connect_The_Cable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Enter An IP Address.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Please_Enter_An_IP_Address() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Please_Enter_An_IP_Address", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Select A Com Port.
        '''</summary>
        Friend ReadOnly Property GrblGui_btnConnDisconnect_Click_Please_Select_A_Com_Port() As String
            Get
                Return ResourceManager.GetString("GrblGui_btnConnDisconnect_Click_Please_Select_A_Com_Port", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are You Certain That You Want To Close.
        '''</summary>
        Friend ReadOnly Property GrblGui_grblgui_unload_Are_You_Certain_That_You_Want_To_Close() As String
            Get
                Return ResourceManager.GetString("GrblGui_grblgui_unload_Are_You_Certain_That_You_Want_To_Close", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Start.
        '''</summary>
        Friend ReadOnly Property MsgFilter_PreFilterMessage_Start() As String
            Get
                Return ResourceManager.GetString("MsgFilter_PreFilterMessage_Start", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
