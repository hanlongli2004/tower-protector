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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("人類大戰機器人.Resources", GetType(Resources).Assembly)
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
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _Exit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Exit", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _Next() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Next", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Back() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Back", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property EndBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("EndBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property GameBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("GameBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to [
        '''    {
        '''        &quot;robot&quot;: {
        '''            &quot;movement_speed&quot;: 3,
        '''            &quot;summon_time&quot;: 5,
        '''            &quot;properties&quot;: [
        '''                {
        '''                    &quot;health&quot;: 100,
        '''                    &quot;cp&quot;: 20
        '''                },
        '''                {
        '''                    &quot;health&quot;: 200,
        '''                    &quot;cp&quot;: 15
        '''                },
        '''                {
        '''                    &quot;health&quot;: 80,
        '''                    &quot;cp&quot;: 50
        '''                },
        '''                {
        '''                    &quot;health&quot;: 150,
        '''                    [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property levelParams() As String
            Get
                Return ResourceManager.GetString("levelParams", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Menu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Menu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property NewEndBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NewEndBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property NewPreviousBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NewPreviousBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property NewWarringBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NewWarringBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property New主選單背景() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("New主選單背景", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Play() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Play", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property PreviousBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("PreviousBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Restart() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Restart", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Robot() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Robot", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Setting() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Setting", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property SettingBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SettingBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WarringBackground() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WarringBackground", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 一顆星() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("一顆星", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 三顆星() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("三顆星", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property 主畫面music() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("主畫面music", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 主選單背景() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("主選單背景", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 主題_1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("主題_1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 主題_2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("主題_2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 人類大戰機器人() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("人類大戰機器人", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 人類贏機器人() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("人類贏機器人", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 兩顆星() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("兩顆星", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 兵馬俑() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("兵馬俑", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 劇情背景一() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("劇情背景一", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 劇情背景一1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("劇情背景一1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 劇情背景二() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("劇情背景二", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 和尚() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("和尚", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property 和尚1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("和尚1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property 失敗() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("失敗", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 夾夾怪() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("夾夾怪", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 對話框() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("對話框", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 巫婆() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("巫婆", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property 巫婆1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("巫婆1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 搥子() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("搥子", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 日本武士() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("日本武士", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property 日本武士1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("日本武士1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 木魚() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("木魚", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 橘色機器人() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("橘色機器人", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 機器人贏人類() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("機器人贏人類", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 步槍兵() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("步槍兵", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property 步槍兵1() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("步槍兵1", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 步槍兵子彈() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("步槍兵子彈", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 武士劍氣_彩色() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("武士劍氣_彩色", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 科技未來人_備案() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("科技未來人_備案", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 第一關() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("第一關", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 第二關() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("第二關", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 跳過() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("跳過", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property 遊戲中() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("遊戲中", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property 過關() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("過關", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 金幣數量() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("金幣數量", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 長腿怪() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("長腿怪", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 關卡選擇() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("關卡選擇", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 電擊怪() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("電擊怪", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 靜音_開() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("靜音_開", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 靜音_關() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("靜音_關", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 魔法藥水() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("魔法藥水", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property 魔王關() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("魔王關", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
