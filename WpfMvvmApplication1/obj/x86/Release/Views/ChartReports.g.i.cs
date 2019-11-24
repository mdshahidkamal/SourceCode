﻿#pragma checksum "..\..\..\..\Views\ChartReports.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386E13256A068E4AA694BBBDD11C77646AD61570"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HospitalManagementSystem.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace HospitalManagementSystem.Views {
    
    
    /// <summary>
    /// ChartReports
    /// </summary>
    public partial class ChartReports : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbAcademicYear;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart mcChart;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.ColumnSeries Income;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.ColumnSeries Expense;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart expenseChart;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\ChartReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.PieSeries ExpenseData;
        
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
            System.Uri resourceLocater = new System.Uri("/SMS;component/views/chartreports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ChartReports.xaml"
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
            this.cmbAcademicYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            
            #line 27 "..\..\..\..\Views\ChartReports.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSearch);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mcChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 4:
            this.Income = ((System.Windows.Controls.DataVisualization.Charting.ColumnSeries)(target));
            return;
            case 5:
            this.Expense = ((System.Windows.Controls.DataVisualization.Charting.ColumnSeries)(target));
            return;
            case 6:
            this.expenseChart = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 7:
            this.ExpenseData = ((System.Windows.Controls.DataVisualization.Charting.PieSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

