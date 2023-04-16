using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLab2Sony
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        driver driver = new driver();  
        public MainWindow()
        {
            InitializeComponent();
            foreach(COLOREYES color in Enum.GetValues(typeof(COLOREYES)))
            {
                comboBoxEyes.Items.Add(color);
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            driver.Name = textBoxName.Text;
            driver.Number = textBoxNumber.Text;
            driver.Address = textBoxAddress.Text;
            if(textBoxClass.Text.Length > 0 )
            {
                driver.Clas1 = textBoxClass.Text[0];
            }
            else
            {
                driver.Clas1 = 'A';
            }
            if (datePickerDOB.SelectedDate == null)
                driver.Dob = DateTime.Now;
            else
                driver.Dob = (DateTime)(datePickerDOB.SelectedDate);
            if (datePickerISS.SelectedDate == null)
                driver.Iss = DateTime.Now;
            else
                driver.Iss = (DateTime)(datePickerDOB.SelectedDate);
            if (datePickerEXP.SelectedDate == null)
                driver.Exp = DateTime.Now;
            else
                driver.Exp = (DateTime)(datePickerDOB.SelectedDate);
            driver.Hgt = sliderHGT.Value;
            if (checkBoxDonor.IsChecked == true)
                driver.Donor = true;
            else
                driver.Donor = false;
            if (comboBoxEyes.SelectedIndex > -1)
                driver.Eyes = (COLOREYES)comboBoxEyes.SelectedItem;
            if (radioButtonMale.IsChecked == true)  
                driver.Gender = GENDER.male;
            if (radioButtonFemale.IsChecked == true)
                driver.Gender = GENDER.female;
            if (radioButtonVariant.IsChecked == true)
                driver.Gender = GENDER.variant;

            MessageBox.Show(driver.ToString());
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void radioButtonFemale_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
