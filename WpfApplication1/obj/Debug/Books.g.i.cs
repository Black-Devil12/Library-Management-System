﻿#pragma checksum "..\..\Books.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB8CF028C2526AA9EC5CC41154C6EDFC400ADE47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApplication1;


namespace WpfApplication1 {
    
    
    /// <summary>
    /// Books
    /// </summary>
    public partial class Books : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Dashborad2;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_books_list;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add_book;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_book;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete_book;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_search;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_search;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/books.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Books.xaml"
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
            this.Dashborad2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btn_books_list = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Books.xaml"
            this.btn_books_list.Click += new System.Windows.RoutedEventHandler(this.btn_books_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_add_book = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Books.xaml"
            this.btn_add_book.Click += new System.Windows.RoutedEventHandler(this.btn_add_book_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dg_book = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btn_delete_book = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Books.xaml"
            this.btn_delete_book.Click += new System.Windows.RoutedEventHandler(this.btn_delete_book_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_search = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tbx_search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.bt_delete = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Books.xaml"
            this.bt_delete.Click += new System.Windows.RoutedEventHandler(this.bt_delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
