﻿#pragma checksum "..\..\..\View\ViewContratType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09ECF3FBD2E5FD090559217400E00754F907FC6A2A9DCAD9B3B7E05470089CF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MegaCastingV2.WPF.View;
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


namespace MegaCastingV2.WPF.View {
    
    
    /// <summary>
    /// ViewContratType
    /// </summary>
    public partial class ViewContratType : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxContractType;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nom;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonManageInsert;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonManageDelete;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonManageUpdate;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\View\ViewContratType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonManageReset;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCastingV2.WPF;component/view/viewcontrattype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ViewContratType.xaml"
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
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ListBoxContractType = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.Nom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButtonManageInsert = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\View\ViewContratType.xaml"
            this.ButtonManageInsert.Click += new System.Windows.RoutedEventHandler(this.ButtonManageInsert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonManageDelete = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\View\ViewContratType.xaml"
            this.ButtonManageDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonManageDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonManageUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\View\ViewContratType.xaml"
            this.ButtonManageUpdate.Click += new System.Windows.RoutedEventHandler(this.ButtonManageUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonManageReset = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\..\View\ViewContratType.xaml"
            this.ButtonManageReset.Click += new System.Windows.RoutedEventHandler(this.ButtonManageReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

