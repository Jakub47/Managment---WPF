﻿#pragma checksum "..\..\..\Views\AddingTask.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98846AA630FD6E63F01C02FBD7CB0CBE2531F38B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using System.Windows.Shell;
using Zadania.Views;


namespace Zadania.Views {
    
    
    /// <summary>
    /// AddingTask
    /// </summary>
    public partial class AddingTask : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdZero;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTemat;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBPriorytet;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar cldData;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chBSwitch;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBStatus;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOpis;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\AddingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZapisz;
        
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
            System.Uri resourceLocater = new System.Uri("/Zadania;component/views/addingtask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddingTask.xaml"
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
            this.gdZero = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtTemat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cBPriorytet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cldData = ((System.Windows.Controls.Calendar)(target));
            return;
            case 5:
            this.chBSwitch = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\..\Views\AddingTask.xaml"
            this.chBSwitch.Checked += new System.Windows.RoutedEventHandler(this.chBSwitch_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cBStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtOpis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnZapisz = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Views\AddingTask.xaml"
            this.btnZapisz.Click += new System.Windows.RoutedEventHandler(this.btnZapisz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

