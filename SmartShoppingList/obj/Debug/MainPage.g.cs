﻿#pragma checksum "E:\Projects\Local Database Sample\C#\sdkLocalDatabaseCS\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "62D7560848398367B06A77456A52FADE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.Panorama mainitempage;
        
        internal System.Windows.Controls.ListBox allToDoItemsListBox;
        
        internal System.Windows.Controls.Grid gridCatinit;
        
        internal System.Windows.Controls.Image allcatimage;
        
        internal System.Windows.Controls.Button deleteListButton;
        
        internal System.Windows.Controls.ListBox cat;
        
        internal System.Windows.Controls.ListBox myalllistUI;
        
        internal System.Windows.Controls.Primitives.Popup srijonpopup;
        
        internal System.Windows.Controls.TextBlock poptextblock;
        
        internal System.Windows.Controls.TextBox quantity;
        
        internal System.Windows.Controls.Button btn_continue;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton newTaskAppBarButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton newcat;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton GridtestButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/sdkLocalDatabaseCS;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.mainitempage = ((Microsoft.Phone.Controls.Panorama)(this.FindName("mainitempage")));
            this.allToDoItemsListBox = ((System.Windows.Controls.ListBox)(this.FindName("allToDoItemsListBox")));
            this.gridCatinit = ((System.Windows.Controls.Grid)(this.FindName("gridCatinit")));
            this.allcatimage = ((System.Windows.Controls.Image)(this.FindName("allcatimage")));
            this.deleteListButton = ((System.Windows.Controls.Button)(this.FindName("deleteListButton")));
            this.cat = ((System.Windows.Controls.ListBox)(this.FindName("cat")));
            this.myalllistUI = ((System.Windows.Controls.ListBox)(this.FindName("myalllistUI")));
            this.srijonpopup = ((System.Windows.Controls.Primitives.Popup)(this.FindName("srijonpopup")));
            this.poptextblock = ((System.Windows.Controls.TextBlock)(this.FindName("poptextblock")));
            this.quantity = ((System.Windows.Controls.TextBox)(this.FindName("quantity")));
            this.btn_continue = ((System.Windows.Controls.Button)(this.FindName("btn_continue")));
            this.newTaskAppBarButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("newTaskAppBarButton")));
            this.newcat = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("newcat")));
            this.GridtestButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("GridtestButton")));
        }
    }
}

