﻿#pragma checksum "..\..\..\NodeUI\tab_program.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B518EB42949790542E5A3ADA2805DE6ED937E120"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dynamo_TORO;
using Dynamo_TORO.NodeUI;
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


namespace Dynamo_TORO.NodeUI {
    
    
    /// <summary>
    /// tab_program
    /// </summary>
    public partial class tab_program : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Dynamo_TORO.NodeUI.tab_program remotePanelMain;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSendToRS;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSetProgramPtr;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btPlayFromPointer;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btStop;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProgramList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\NodeUI\tab_program.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbFileLoc;
        
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
            System.Uri resourceLocater = new System.Uri("/DYNAMO_ToRoUI;component/nodeui/tab_program.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NodeUI\tab_program.xaml"
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
            this.remotePanelMain = ((Dynamo_TORO.NodeUI.tab_program)(target));
            return;
            case 2:
            this.btSendToRS = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btSetProgramPtr = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btPlayFromPointer = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btStop = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.ProgramList = ((System.Windows.Controls.ListView)(target));
            
            #line 44 "..\..\..\NodeUI\tab_program.xaml"
            this.ProgramList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProgramList_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TbFileLoc = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

