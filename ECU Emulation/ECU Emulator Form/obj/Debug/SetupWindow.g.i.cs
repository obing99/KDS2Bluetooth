﻿#pragma checksum "..\..\SetupWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42AAAF9694747EE071A6AF5009471309"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EcuEmulator.Data;
using EcuEmulatorForm.Converter;
using SerialComPort.Data;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace EcuEmulatorForm {
    
    
    /// <summary>
    /// SetupWindow
    /// </summary>
    public partial class SetupWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridComPort;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox baudRateComboBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox dataBitsComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox dtrEnableCheckBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox encodingComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox handshakeComboBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox parityComboBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbComPort;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rtsEnableCheckBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox stopBitsComboBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeOutMsTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEcuSetup;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ecuAdressTextBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senderAdressTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox isoRequestDelayTextBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox positiveReplyTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox initSequenceTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox errorSequenceTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox offsetMinTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox offsetMaxTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ecu Emulator Form;component/setupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SetupWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\SetupWindow.xaml"
            ((EcuEmulatorForm.SetupWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 7 "..\..\SetupWindow.xaml"
            ((EcuEmulatorForm.SetupWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridComPort = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.baudRateComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dataBitsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dtrEnableCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.encodingComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.handshakeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.parityComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cbComPort = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.rtsEnableCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.stopBitsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.timeOutMsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.gridEcuSetup = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            this.ecuAdressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.senderAdressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.isoRequestDelayTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.positiveReplyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.initSequenceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.errorSequenceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.offsetMinTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.offsetMaxTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

