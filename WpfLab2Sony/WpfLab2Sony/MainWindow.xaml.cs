﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using Microsoft.Win32;

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
            driver.Name = "Severus Snape";
            driver.Clas1 = 'A';
            driver.Address = "Hogwarts";
            driver.Hgt = 0123456789;
            driver.Gender = GENDER.male;
            driver.Eyes = COLOREYES.gray;
            driver.Dob = new DateTime(1968, 5, 1);
            driver.Iss = new DateTime(2008, 10, 22);
            driver.Exp = new DateTime(2038, 10, 22);
            driver.Donor = true;
            driver.UriImage = "images/arny.jpg";
            textBoxName.Text = driver.Name;
            textBoxNumber.Text = driver.Number;
            textBoxAddress.Text = driver.Address;
            textBoxClass.Text = driver.Clas1.ToString();
            sliderHGT.Value = driver.Hgt;

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            
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
    }
}
