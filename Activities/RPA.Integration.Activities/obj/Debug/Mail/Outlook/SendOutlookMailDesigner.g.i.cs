﻿#pragma checksum "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2493A827F464A82BC597944909CC4A01E2729BD70E6C9180C97544FEE4B52895"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Plugins.Shared.Library.Attached;
using Plugins.Shared.Library.Controls;
using System;
using System.Activities.Presentation;
using System.Activities.Presentation.View;
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


namespace RPA.Integration.Activities.Mail {
    
    
    /// <summary>
    /// SendOutlookMailDesigner
    /// </summary>
    public partial class SendOutlookMailDesigner : System.Activities.Presentation.ActivityDesigner, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AttachFiles;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ToLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SubjectLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BodyLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox ToTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox SubjectTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox BodyTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/RPA.Integration.Activities;component/mail/outlook/sendoutlookmaildesigner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
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
            this.AttachFiles = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\..\..\Mail\Outlook\SendOutlookMailDesigner.xaml"
            this.AttachFiles.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AttachFiles_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ToLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.SubjectLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BodyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ToTextBox = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 6:
            this.SubjectTextBox = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 7:
            this.BodyTextBox = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

