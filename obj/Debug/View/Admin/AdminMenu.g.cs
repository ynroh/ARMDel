﻿#pragma checksum "..\..\..\..\View\Admin\AdminMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA1A3DC4755439D7A50FE000674A1EDC42DAFDE3ADFFA9EBC425E51C6FB1E4CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ARMDel.View;
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


namespace ARMDel.View {
    
    
    /// <summary>
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddingOrderBorder;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdminName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ExitButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewOperator;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewProduct;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeProduct;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewDistrict;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\View\Admin\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeDistrict;
        
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
            System.Uri resourceLocater = new System.Uri("/ARMDel;component/view/admin/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Admin\AdminMenu.xaml"
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
            this.AddingOrderBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.AdminName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ExitButton = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.AddNewOperator = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\View\Admin\AdminMenu.xaml"
            this.AddNewOperator.Click += new System.Windows.RoutedEventHandler(this.AddOperator_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddNewProduct = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\View\Admin\AdminMenu.xaml"
            this.AddNewProduct.Click += new System.Windows.RoutedEventHandler(this.AddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ChangeProduct = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\View\Admin\AdminMenu.xaml"
            this.ChangeProduct.Click += new System.Windows.RoutedEventHandler(this.ChangeProduct_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddNewDistrict = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\View\Admin\AdminMenu.xaml"
            this.AddNewDistrict.Click += new System.Windows.RoutedEventHandler(this.AddNewDistrict_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChangeDistrict = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\View\Admin\AdminMenu.xaml"
            this.ChangeDistrict.Click += new System.Windows.RoutedEventHandler(this.ChangeDistrict_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
