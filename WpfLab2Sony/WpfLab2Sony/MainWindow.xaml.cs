using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
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
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

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
            newDriver();
            grid.DataContext = driver;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
                       MessageBox.Show(driver.ToString());
        }

        private void newDriver()
        {
            driver.Name = "Severus Snape";
            driver.Clas1 = 'A';
            driver.Address = "Hogwarts";
            driver.Number = "123456789";
            driver.Hgt = 0123456789;
            driver.Gender = GENDER.male;
            driver.Eyes = COLOREYES.gray;
            driver.Dob = new DateTime(1968, 5, 1);
            driver.Iss = new DateTime(2008, 10, 22);
            driver.Exp = new DateTime(2038, 10, 22);
            driver.Donor = true;
            driver.UriImage = "images/arny.jpg";
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            driver.Name = "Pushkin";
            driver.Clas1 = 'B';
            driver.Address = "London";
            driver.Number = "777777777";
            driver.Hgt = 168;
            driver.Gender = GENDER.variant;
            driver.Eyes = COLOREYES.blue;
            driver.Dob = new DateTime(1968, 5, 1);
            driver.Dob = new DateTime(1922, 1, 1);
            driver.Iss = new DateTime(2008, 10, 22);
            driver.Exp = new DateTime(2020, 10, 22);
            driver.Donor = false;
            driver.UriImage = "images/Pushkin.jpg";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxName.Clear();
            textBoxName.Text = "";
            textBoxNumber.Text = string.Empty;
            textBoxNumber.Clear();
            textBoxNumber.Text = "";
            textBoxAddress.Text = string.Empty;
            textBoxAddress.Clear();
            textBoxAddress.Text = "";
            textBoxClass.Text = string.Empty;
            textBoxClass.Clear();
            datePickerDOB.Text = "";
            datePickerISS.Text = "";
            radioButtonMale.IsChecked = false;
            radioButtonFemale.IsChecked = false;
            radioButtonVariant.IsChecked = false;
            datePickerEXP.SelectedDate = null;
            comboBoxEyes.Text = "";
            checkBoxDonor.IsChecked = false;
            driver.Hgt = sliderHGT.Value = 0;
            driver.UriImage = "images/no.png";
            image.Source = new BitmapImage(new Uri(driver.UriImage, UriKind.RelativeOrAbsolute));



        }

        private void radioButtonFemale_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Фалы(jpg)|*.jpg|Все файлы|*.*";
            if(dialog.ShowDialog() == true)
            {
                driver.UriImage = dialog.FileName;
                image.Source = new BitmapImage(new Uri(driver.UriImage)); 
            }
        }

        private void textBoxNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void radioButtonMale_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sliderHGT_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void textBoxClass_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
