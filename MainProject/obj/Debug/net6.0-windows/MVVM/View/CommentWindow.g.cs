﻿#pragma checksum "..\..\..\..\..\MVVM\View\CommentWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A9AD79E63860CB8C5CB295DB2E003DD7A0A101F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainProject.MVVM.View;
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


namespace MainProject.MVVM.View {
    
    
    /// <summary>
    /// CommentWindow
    /// </summary>
    public partial class CommentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl MyItemsControl;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senderTB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MainProject;component/mvvm/view/commentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.FrameworkElement_OnSizeChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
            ((System.Windows.Controls.ScrollViewer)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FrameworkElement_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MyItemsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 3:
            
            #line 84 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.senderTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 93 "..\..\..\..\..\MVVM\View\CommentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

