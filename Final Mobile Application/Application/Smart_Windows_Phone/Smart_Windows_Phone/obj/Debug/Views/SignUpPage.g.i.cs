﻿#pragma checksum "C:\Users\Aron\documents\visual studio 2013\Projects\Smart_Windows_Phone\Smart_Windows_Phone\Views\SignUpPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC8AB8564232C8BC087E5694D759FC77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Smart_Windows_Phone.Views {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock UserName;
        
        internal System.Windows.Controls.TextBlock Password;
        
        internal System.Windows.Controls.Button BtnSubmit;
        
        internal System.Windows.Controls.TextBox TxtUserName;
        
        internal System.Windows.Controls.TextBox TxtAddr;
        
        internal System.Windows.Controls.PasswordBox TxtPwd;
        
        internal System.Windows.Controls.TextBlock Password_Copy;
        
        internal System.Windows.Controls.PasswordBox TxtPwd_Copy;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Smart_Windows_Phone;component/Views/SignUpPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.UserName = ((System.Windows.Controls.TextBlock)(this.FindName("UserName")));
            this.Password = ((System.Windows.Controls.TextBlock)(this.FindName("Password")));
            this.BtnSubmit = ((System.Windows.Controls.Button)(this.FindName("BtnSubmit")));
            this.TxtUserName = ((System.Windows.Controls.TextBox)(this.FindName("TxtUserName")));
            this.TxtAddr = ((System.Windows.Controls.TextBox)(this.FindName("TxtAddr")));
            this.TxtPwd = ((System.Windows.Controls.PasswordBox)(this.FindName("TxtPwd")));
            this.Password_Copy = ((System.Windows.Controls.TextBlock)(this.FindName("Password_Copy")));
            this.TxtPwd_Copy = ((System.Windows.Controls.PasswordBox)(this.FindName("TxtPwd_Copy")));
        }
    }
}

