﻿#pragma checksum "..\..\dealer window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E259359A868B3E114C2AD25564B0DFED58D6A0C45B5ADF6878B3A0BCE6A52414"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_GAD_CW2;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Final_GAD_CW2 {
    
    
    /// <summary>
    /// dealer_window
    /// </summary>
    public partial class dealer_window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_open_menu;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close_menu;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_home;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_bill_paymeny;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_echanneling;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_mobile_reload;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\dealer window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem btn_transaction_history;
        
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
            System.Uri resourceLocater = new System.Uri("/Final GAD CW2;component/dealer%20window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\dealer window.xaml"
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
            
            #line 77 "..\..\dealer window.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.closeApp);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 78 "..\..\dealer window.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.minimizeAPP);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 79 "..\..\dealer window.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.maximizeApp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.btn_open_menu = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\dealer window.xaml"
            this.btn_open_menu.Click += new System.Windows.RoutedEventHandler(this.btn_open_menu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_close_menu = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\dealer window.xaml"
            this.btn_close_menu.Click += new System.Windows.RoutedEventHandler(this.btn_close_menu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 159 "..\..\dealer window.xaml"
            ((System.Windows.Controls.ListView)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_home = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 165 "..\..\dealer window.xaml"
            this.btn_home.Selected += new System.Windows.RoutedEventHandler(this.btn_home_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_bill_paymeny = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 10:
            this.btn_echanneling = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 11:
            this.btn_mobile_reload = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 12:
            this.btn_transaction_history = ((System.Windows.Controls.ListViewItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

