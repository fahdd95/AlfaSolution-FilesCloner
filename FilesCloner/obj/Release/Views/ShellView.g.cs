﻿#pragma checksum "..\..\..\Views\ShellView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FCB58E297B8734457D57FDB8D2306874DF5547805D7EC177D28474237DEC376C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using FilesCloner.Views;
using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using ModernWpf.DesignTime;
using ModernWpf.Markup;
using ModernWpf.Media.Animation;
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


namespace FilesCloner.Views {
    
    
    /// <summary>
    /// ShellView
    /// </summary>
    public partial class ShellView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SourceBrowse;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CloneAllFilesBool;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DelAllFilesBool;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListOfExt;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EXTMNG;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TargetBrowse;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Subfolders;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox OverWriteBool;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox MainBool;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CopySubfoldersBool;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DeleteSubfoldersBool;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DelAllTargetFilesBefore;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DelAllSourceFilesAfter;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgBarVal;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsWindow;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartClone;
        
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
            System.Uri resourceLocater = new System.Uri("/FilesCloner;component/views/shellview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ShellView.xaml"
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
            
            #line 16 "..\..\..\Views\ShellView.xaml"
            ((FilesCloner.Views.ShellView)(target)).ContentRendered += new System.EventHandler(this.Window_OnContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SourceBrowse = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.CloneAllFilesBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.DelAllFilesBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.ListOfExt = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.EXTMNG = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.TargetBrowse = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Subfolders = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.OverWriteBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.MainBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.CopySubfoldersBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.DeleteSubfoldersBool = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            this.DelAllTargetFilesBefore = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 15:
            this.DelAllSourceFilesAfter = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 16:
            this.ProgBarVal = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 17:
            this.SettingsWindow = ((System.Windows.Controls.Button)(target));
            return;
            case 18:
            this.StartClone = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

