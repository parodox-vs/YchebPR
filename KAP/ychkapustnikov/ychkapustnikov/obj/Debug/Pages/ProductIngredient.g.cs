﻿#pragma checksum "..\..\..\Pages\ProductIngredient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A87D696D84BF223ED0D383EA06D739260EE3DA4A28F1E094C14F3530E18DD7AF"
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
using ychkapustnikov.Pages;


namespace ychkapustnikov.Pages {
    
    
    /// <summary>
    /// ProductIngredient
    /// </summary>
    public partial class ProductIngredient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProDG;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Addbtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Obnbtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delbtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Backbtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\ProductIngredient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Poisktb;
        
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
            System.Uri resourceLocater = new System.Uri("/ychkapustnikov;component/pages/productingredient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProductIngredient.xaml"
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
            this.ProDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.Addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\ProductIngredient.xaml"
            this.Addbtn.Click += new System.Windows.RoutedEventHandler(this.Addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Obnbtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pages\ProductIngredient.xaml"
            this.Obnbtn.Click += new System.Windows.RoutedEventHandler(this.Obnbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Delbtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\ProductIngredient.xaml"
            this.Delbtn.Click += new System.Windows.RoutedEventHandler(this.Delbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\ProductIngredient.xaml"
            this.Backbtn.Click += new System.Windows.RoutedEventHandler(this.Backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Poisktb = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Pages\ProductIngredient.xaml"
            this.Poisktb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Poisktb_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 25 "..\..\..\Pages\ProductIngredient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Editbtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

