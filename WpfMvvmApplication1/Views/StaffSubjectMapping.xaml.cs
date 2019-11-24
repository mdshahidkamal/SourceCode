using HospitalManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for StaffSubjectMapping.xaml
    /// </summary>
    public partial class StaffSubjectMapping : UserControl
    {
        StaffSubjectMappingViewModel objviewmodel = null;
        public StaffSubjectMapping()
        {
            InitializeComponent();
            objviewmodel = new StaffSubjectMappingViewModel();
            this.DataContext = objviewmodel;
        }
    }
}
