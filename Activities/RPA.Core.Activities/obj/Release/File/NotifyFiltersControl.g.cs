﻿#pragma checksum "..\..\..\File\NotifyFiltersControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3BF39FCFF7A4F4E54EFEA72F75FD9ED88D1D4D55EEF4389B1A8FB2562C73E3DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using RPA.Core.Activities.FileActivity;
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


namespace RPA.Core.Activities.FileActivity {
    
    
    /// <summary>
    /// NotifyFiltersControl
    /// </summary>
    public partial class NotifyFiltersControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbFileName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbDirectoryName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAttributes;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSize;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbLastWrite;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbLastAccess;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbCreationTime;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\File\NotifyFiltersControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSecurity;
        
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
            System.Uri resourceLocater = new System.Uri("/RPA.Core.Activities;component/file/notifyfilterscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\File\NotifyFiltersControl.xaml"
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
            
            #line 10 "..\..\..\File\NotifyFiltersControl.xaml"
            ((System.Windows.Controls.ComboBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.ComboBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbFileName = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbFileName.Checked += new System.Windows.RoutedEventHandler(this.FileName_Checked);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbFileName.Unchecked += new System.Windows.RoutedEventHandler(this.FileName_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbDirectoryName = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbDirectoryName.Checked += new System.Windows.RoutedEventHandler(this.DirectoryName_Checked);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbDirectoryName.Unchecked += new System.Windows.RoutedEventHandler(this.DirectoryName_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbAttributes = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbAttributes.Checked += new System.Windows.RoutedEventHandler(this.Attributes_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbAttributes.Unchecked += new System.Windows.RoutedEventHandler(this.Attributes_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbSize = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbSize.Checked += new System.Windows.RoutedEventHandler(this.Size_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbSize.Unchecked += new System.Windows.RoutedEventHandler(this.Size_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbLastWrite = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbLastWrite.Checked += new System.Windows.RoutedEventHandler(this.LastWrite_Checked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbLastWrite.Unchecked += new System.Windows.RoutedEventHandler(this.LastWrite_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbLastAccess = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbLastAccess.Checked += new System.Windows.RoutedEventHandler(this.LastAccess_Checked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbLastAccess.Unchecked += new System.Windows.RoutedEventHandler(this.LastAccess_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbCreationTime = ((System.Windows.Controls.CheckBox)(target));
            
            #line 24 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbCreationTime.Checked += new System.Windows.RoutedEventHandler(this.CreationTime_Checked);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbCreationTime.Unchecked += new System.Windows.RoutedEventHandler(this.CreationTime_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbSecurity = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbSecurity.Checked += new System.Windows.RoutedEventHandler(this.Security_Checked);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\File\NotifyFiltersControl.xaml"
            this.cbSecurity.Unchecked += new System.Windows.RoutedEventHandler(this.Security_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
