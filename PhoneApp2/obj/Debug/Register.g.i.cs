﻿#pragma checksum "c:\users\invalid\documents\visual studio 2013\Projects\cmt 307 .NET Project\PhoneApp2\Register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE5C5CAA705C96E81E38305B6E399DB1"
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
    
    
    public partial class Register : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtUsername;
        
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        internal System.Windows.Controls.PasswordBox txtConfirmPassword;
        
        internal System.Windows.Controls.Button btnRegister;
        
        internal System.Windows.Controls.HyperlinkButton lnkLogin;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp2;component/Register.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtUsername = ((System.Windows.Controls.TextBox)(this.FindName("txtUsername")));
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("txtPassword")));
            this.txtConfirmPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("txtConfirmPassword")));
            this.btnRegister = ((System.Windows.Controls.Button)(this.FindName("btnRegister")));
            this.lnkLogin = ((System.Windows.Controls.HyperlinkButton)(this.FindName("lnkLogin")));
        }
    }
}
