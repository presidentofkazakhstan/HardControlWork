﻿#pragma checksum "..\..\MoveDirectory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EBA229E0A2ABFA84B1C2D69725B9C4A04AB2ABEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp11;


namespace WpfApp11 {
    
    
    /// <summary>
    /// MoveDirectory
    /// </summary>
    public partial class MoveDirectory : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MoveDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fromTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MoveDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox toTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MoveDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fromFindDirectoryButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MoveDirectory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button toFindDirectoryButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp11;component/movedirectory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MoveDirectory.xaml"
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
            this.fromTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.toTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.fromFindDirectoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MoveDirectory.xaml"
            this.fromFindDirectoryButton.Click += new System.Windows.RoutedEventHandler(this.FromFindDirectoryButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.toFindDirectoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MoveDirectory.xaml"
            this.toFindDirectoryButton.Click += new System.Windows.RoutedEventHandler(this.ToFindDirectoryButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
