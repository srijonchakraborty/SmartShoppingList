﻿#pragma checksum "E:\Projects\Local Database Sample\C#\sdkLocalDatabaseCS\setListName.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B25E3CBAA44E5810E77CB34E0428DA6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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


namespace sdkLocalDatabaseCS {
    
    
    public partial class setListName : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Okdone;
        
        internal System.Windows.Controls.ScrollViewer info;
        
        internal System.Windows.Controls.TextBox ListName;
        
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/sdkLocalDatabaseCS;component/setListName.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Okdone = ((System.Windows.Controls.Button)(this.FindName("Okdone")));
            this.info = ((System.Windows.Controls.ScrollViewer)(this.FindName("info")));
            this.ListName = ((System.Windows.Controls.TextBox)(this.FindName("ListName")));
            this.Cancel = ((System.Windows.Controls.Button)(this.FindName("Cancel")));
        }
    }
}

