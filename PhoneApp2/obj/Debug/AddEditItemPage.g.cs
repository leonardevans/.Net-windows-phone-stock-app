﻿#pragma checksum "c:\users\invalid\documents\visual studio 2013\Projects\cmt 307 .NET Project\PhoneApp2\AddEditItemPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DEA647984F043F815CF6058BC8BB328"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp2 {
    
    
    public partial class AddItemPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.HyperlinkButton lnkLogout;
        
        internal System.Windows.Controls.TextBlock txtWelcome;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock txtAction;
        
        internal System.Windows.Controls.TextBox txtItemname;
        
        internal System.Windows.Controls.TextBox txtPrice;
        
        internal System.Windows.Controls.TextBox txtQuantity;
        
        internal System.Windows.Controls.Button btnAdd;
        
        internal System.Windows.Controls.HyperlinkButton lnkHome;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/AddEditItemPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lnkLogout = ((System.Windows.Controls.HyperlinkButton)(this.FindName("lnkLogout")));
            this.txtWelcome = ((System.Windows.Controls.TextBlock)(this.FindName("txtWelcome")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtAction = ((System.Windows.Controls.TextBlock)(this.FindName("txtAction")));
            this.txtItemname = ((System.Windows.Controls.TextBox)(this.FindName("txtItemname")));
            this.txtPrice = ((System.Windows.Controls.TextBox)(this.FindName("txtPrice")));
            this.txtQuantity = ((System.Windows.Controls.TextBox)(this.FindName("txtQuantity")));
            this.btnAdd = ((System.Windows.Controls.Button)(this.FindName("btnAdd")));
            this.lnkHome = ((System.Windows.Controls.HyperlinkButton)(this.FindName("lnkHome")));
        }
    }
}

