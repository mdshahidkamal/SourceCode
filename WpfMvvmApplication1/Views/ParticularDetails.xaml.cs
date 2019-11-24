using IMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HospitalManagementSystem.ViewModels;
namespace IMS.Views
{
    /// <summary>
    /// Interaction logic for ParticularDetails.xaml
    /// </summary>
    public partial class ParticularDetails : Window
    {

        ParticularViewModel objParticularViewModel;
        public ParticularDetails(ParticularViewModel o)
        {
            InitializeComponent();
            objParticularViewModel =o;
            this.DataContext = objParticularViewModel;
        }
        private void TextBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

            int result;
            if (!IsTextAllowed(e.Text))
            {
                e.Handled = true;
            }

        }
        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //            this.Close();
        }
    }
}
