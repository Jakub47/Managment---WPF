﻿#pragma checksum "..\..\..\Views\ModifyTask.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C2A23FF9184FE74326348A4686F2CCDD65AADE05"
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
    /// ModifyTask
    /// </summary>
    public partial class ModifyTask : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gdZero;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTemat;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBPriorytet;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar cldData;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtNoDate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cBStatus;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOpis;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\ModifyTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZmodyfikuj;
        
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
            System.Uri resourceLocater = new System.Uri("/Zadania;component/views/modifytask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ModifyTask.xaml"
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
            this.txtNoDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.cBStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtOpis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnZmodyfikuj = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Views\ModifyTask.xaml"
            this.btnZmodyfikuj.Click += new System.Windows.RoutedEventHandler(this.btnZmodyfikuj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

