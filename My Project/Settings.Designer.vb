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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("prueba")>  _
        Public Property CorreoCumpleaños() As String
            Get
                Return CType(Me("CorreoCumpleaños"),String)
            End Get
            Set
                Me("CorreoCumpleaños") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("prueba")>  _
        Public Property UserCredenciales() As String
            Get
                Return CType(Me("UserCredenciales"),String)
            End Get
            Set
                Me("UserCredenciales") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("prueba")>  _
        Public Property PwdCredenciales() As String
            Get
                Return CType(Me("PwdCredenciales"),String)
            End Get
            Set
                Me("PwdCredenciales") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("rsCOASPAE")>  _
        Public Property CarpetaRS() As String
            Get
                Return CType(Me("CarpetaRS"),String)
            End Get
            Set
                Me("CarpetaRS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property PRODUCCION() As String
            Get
                Return CType(Me("PRODUCCION"),String)
            End Get
            Set
                Me("PRODUCCION") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property saldosCC() As String
            Get
                Return CType(Me("saldosCC"),String)
            End Get
            Set
                Me("saldosCC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property saldosCCConnectionString() As String
            Get
                Return CType(Me("saldosCCConnectionString"),String)
            End Get
            Set
                Me("saldosCCConnectionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SIFConnectionString() As String
            Get
                Return CType(Me("SIFConnectionString"),String)
            End Get
            Set
                Me("SIFConnectionString") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=SVRCOASPAE;Initial Catalog=SIF;User ID=sa")>  _
        Public ReadOnly Property SIFConnectionString2() As String
            Get
                Return CType(Me("SIFConnectionString2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.1.3;Initial Catalog=SIF;User ID=sa")>  _
        Public ReadOnly Property SIFConnectionString1() As String
            Get
                Return CType(Me("SIFConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-H5QPF2OG\SQLEXPRESS;Initial Catalog=SIF;Integrated Security=Tr"& _ 
            "ue")>  _
        Public ReadOnly Property TestLocal() As String
            Get
                Return CType(Me("TestLocal"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-H5QPF2OG\SQLEXPRESS;Initial Catalog=SIF;Integrated Security=Tr"& _ 
            "ue")>  _
        Public ReadOnly Property CONNPLANILLAS() As String
            Get
                Return CType(Me("CONNPLANILLAS"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibAdmin.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrAdmin_wsLibAdmin() As String
            Get
                Return CType(Me("SIF_ERP_wrAdmin_wsLibAdmin"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibAhorro.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrAhorro_wsLibAhorro() As String
            Get
                Return CType(Me("SIF_ERP_wrAhorro_wsLibAhorro"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibAsoc.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrAsociados_wsLibAsoc() As String
            Get
                Return CType(Me("SIF_ERP_wrAsociados_wsLibAsoc"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibBancos.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrBancos_wsLibBancos() As String
            Get
                Return CType(Me("SIF_ERP_wrBancos_wsLibBancos"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibContab.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrConta_wsLibContab() As String
            Get
                Return CType(Me("SIF_ERP_wrConta_wsLibContab"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibCred.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrCredito_wsLibCred() As String
            Get
                Return CType(Me("SIF_ERP_wrCredito_wsLibCred"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibPlanilla.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrPlanilla_wsLibPlanilla() As String
            Get
                Return CType(Me("SIF_ERP_wrPlanilla_wsLibPlanilla"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibPrest.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrPrestamo_wsLibPrest() As String
            Get
                Return CType(Me("SIF_ERP_wrPrestamo_wsLibPrest"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://192.168.1.115:9100/wsLibCaja.asmx")>  _
        Public ReadOnly Property SIF_ERP_wrCaja_wsLibCaja() As String
            Get
                Return CType(Me("SIF_ERP_wrCaja_wsLibCaja"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SIF_ERP.My.MySettings
            Get
                Return Global.SIF_ERP.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
