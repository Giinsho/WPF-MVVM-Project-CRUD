﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF68EECE91424EBEA5E53AE6DCC77CA93738948E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ColorModes;
using ColorModes.Model;
using ColorModes.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ColorModes {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listPracownikByIloscZaslug;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView pracownikList;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dodaj;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edytuj;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BlackMode;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DarkMode;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton LightkMode;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton WhiteMode;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ColorModes;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 54 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TabControl)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listPracownikByIloscZaslug = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.pracownikList = ((System.Windows.Controls.ListView)(target));
            
            #line 132 "..\..\..\MainWindow.xaml"
            this.pracownikList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pracownikList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Dodaj = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\MainWindow.xaml"
            this.Dodaj.Click += new System.Windows.RoutedEventHandler(this.Dodaj_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Edytuj = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\MainWindow.xaml"
            this.Edytuj.Click += new System.Windows.RoutedEventHandler(this.Edytuj_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BlackMode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 190 "..\..\..\MainWindow.xaml"
            this.BlackMode.Checked += new System.Windows.RoutedEventHandler(this.BlackMode_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DarkMode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 191 "..\..\..\MainWindow.xaml"
            this.DarkMode.Checked += new System.Windows.RoutedEventHandler(this.DarkMode_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LightkMode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 192 "..\..\..\MainWindow.xaml"
            this.LightkMode.Checked += new System.Windows.RoutedEventHandler(this.LightkMode_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.WhiteMode = ((System.Windows.Controls.RadioButton)(target));
            
            #line 193 "..\..\..\MainWindow.xaml"
            this.WhiteMode.Checked += new System.Windows.RoutedEventHandler(this.WhiteMode_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

