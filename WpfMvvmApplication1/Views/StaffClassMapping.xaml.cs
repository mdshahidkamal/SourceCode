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
    /// Interaction logic for StaffClassMapping.xaml
    /// </summary>
    public partial class StaffClassMapping : UserControl
    {
        StaffClassMappingViewModel objviewmodel = null;
        public StaffClassMapping()
        {
            InitializeComponent();
            objviewmodel = new StaffClassMappingViewModel();
            this.DataContext = objviewmodel;
        }
    }
}
