﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61C4FB1549C1ED91F9558FF250877D4C2F1ED42A34B852A8C125BE3696035E12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GTAWorld_Screenshot_Editor;
using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using QuickConverter;
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
using System.Windows.Interactivity;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace GTAWorld_Screenshot_Editor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem EditorHeader;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ControlsScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown ImageWidth;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown ImageHeight;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontCombo;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontWeightCombo;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander ChatFilterExpander;
        
        #line default
        #line hidden
        
        
        #line 277 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.RichTextBox ParsedChatSmall;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider CanvasZoom;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ScreenshotCanvas;
        
        #line default
        #line hidden
        
        
        #line 331 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ScreenshotTextControl;
        
        #line default
        #line hidden
        
        
        #line 350 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveLocally;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CopyClipboard;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.RichTextBox ParsedChatBig;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ScreenCacheListView;
        
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
            System.Uri resourceLocater = new System.Uri("/GTAWorld Screenshot Editor;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 12 "..\..\..\Views\MainWindow.xaml"
            ((GTAWorld_Screenshot_Editor.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_OnLoaded);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Views\MainWindow.xaml"
            ((GTAWorld_Screenshot_Editor.MainWindow)(target)).Drop += new System.Windows.DragEventHandler(this.MainWindow_OnDrop);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.EditorHeader = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            this.ControlsScrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.ImageWidth = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 6:
            this.ImageHeight = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 7:
            this.FontCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.FontWeightCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ChatFilterExpander = ((System.Windows.Controls.Expander)(target));
            
            #line 229 "..\..\..\Views\MainWindow.xaml"
            this.ChatFilterExpander.Expanded += new System.Windows.RoutedEventHandler(this.ChatFilterExpander_OnExpanded);
            
            #line default
            #line hidden
            
            #line 229 "..\..\..\Views\MainWindow.xaml"
            this.ChatFilterExpander.Collapsed += new System.Windows.RoutedEventHandler(this.ChatFilterExpander_OnExpanded);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ParsedChatSmall = ((Xceed.Wpf.Toolkit.RichTextBox)(target));
            return;
            case 11:
            this.CanvasZoom = ((System.Windows.Controls.Slider)(target));
            
            #line 310 "..\..\..\Views\MainWindow.xaml"
            this.CanvasZoom.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.CanvasZoom_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ScreenshotCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 322 "..\..\..\Views\MainWindow.xaml"
            this.ScreenshotCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.ScreenshotCanvas_OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ScreenshotTextControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 14:
            this.SaveLocally = ((System.Windows.Controls.Button)(target));
            
            #line 350 "..\..\..\Views\MainWindow.xaml"
            this.SaveLocally.Click += new System.Windows.RoutedEventHandler(this.SaveLocally_OnClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this.CopyClipboard = ((System.Windows.Controls.Button)(target));
            
            #line 351 "..\..\..\Views\MainWindow.xaml"
            this.CopyClipboard.Click += new System.Windows.RoutedEventHandler(this.SaveLocally_OnClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.ParsedChatBig = ((Xceed.Wpf.Toolkit.RichTextBox)(target));
            return;
            case 17:
            this.ScreenCacheListView = ((System.Windows.Controls.ListView)(target));
            
            #line 372 "..\..\..\Views\MainWindow.xaml"
            this.ScreenCacheListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ScreenCacheListView_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

