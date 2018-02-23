/*Shane MacDonald
 * Feb. 23, 2018
 * Computer Parts
 * Displays parts of for my cumputer including the cost and the link to the product
 */

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

namespace u1_03_ShaneComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { if (slider1.Value == 0)
            {
                imgCPU.Visibility = Visibility.Visible;
                lbl_caption.Content = "AMD - FX-8370 4.0GHz 8-Core Processor";
            }
          if (slider1.Value != 0) {
                    imgCPU.Visibility = Visibility.Hidden;
                }
          if (slider1.Value == 1) {
                imgMotherboard.Visibility = Visibility.Visible;
                lbl_caption.Content = "ASRock - X79 Extreme9 ATX LGA2011 Motherboard";
           
                }
          if (slider1.Value != 1)
            {
                imgMotherboard.Visibility = Visibility.Hidden;
           
            }
           
               if (slider1.Value == 2)
                {
                imgCase.Visibility = Visibility.Visible;
                         lbl_caption.Content = "Raidmax - Vampire ATX Full Tower Case";
            }
                if (slider1.Value != 2)
                {
                    imgCase.Visibility = Visibility.Hidden;
                }
             if (slider1.Value == 3)
            {
                imgPowerSupply.Visibility = Visibility.Visible;
                lbl_caption.Content = "";
            }
            if (slider1.Value != 3)
            {
                imgPowerSupply.Visibility = Visibility.Hidden;
            }
            if (slider1.Value == 4)
            {
                imgRAM.Visibility = Visibility.Visible;
                lbl_caption.Content = "";
            }
            if (slider1.Value != 4)
            {
                imgRAM.Visibility = Visibility.Hidden;
            }
            if (slider1.Value == 5)
            {
                imgVideoCard.Visibility = Visibility.Visible;
                lbl_caption.Content = "";
            }
            if (slider1.Value != 5)
            {
                imgVideoCard.Visibility = Visibility.Hidden;
            }
            if (slider1.Value == 6)
            {
                imgStorage.Visibility = Visibility.Visible;
                lbl_caption.Content = "";
            }
            if (slider1.Value != 6)
            {
                imgStorage.Visibility = Visibility.Hidden;
            }
            if (slider1.Value == 7)
            {
                imgMonitor.Visibility = Visibility.Visible;
                lbl_caption.Content = "";
            }
            if (slider1.Value != 7)
            {
                imgMonitor.Visibility = Visibility.Hidden;
            }
        }

        private void LinkCPU_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }
    }
    }

