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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double driveCapacityValue = Convert.ToDouble(Capacity.Text);
                int driveCapacity = capacityCombobox.SelectedIndex;
                double CloningSpeed = sliderSpeed.Value;
                int CloningCapacity = cloningComboBox.SelectedIndex;

                double convertSpaceToMBps = 0;
                double convertCloneToMBps = 0;
                switch (driveCapacity)
                {
                    case 0:
                        convertSpaceToMBps = driveCapacityValue;
                        break;
                    case 1:
                        convertSpaceToMBps = driveCapacityValue * 1000;
                        break;
                    case 2:
                        convertSpaceToMBps = driveCapacityValue * 1000 * 1000;
                        break;
                }

                switch (CloningCapacity)
                {
                    case 0:
                        convertCloneToMBps = CloningSpeed / 8;
                        break;
                    case 1:
                        convertCloneToMBps = CloningSpeed / 1000;
                        break;
                    case 2:
                        convertCloneToMBps = CloningSpeed;
                        break;
                    case 3:
                        convertCloneToMBps = CloningSpeed * 1000;
                        break;
                }

                if (capacityCombobox.SelectedIndex == -1 || cloningComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Kérem minden mezőt töltsön ki!");
                }


                calculateResultTextBlock.Text = Convert.ToString(convertSpaceToMBps / convertCloneToMBps);
                
            }               
            catch {
                MessageBox.Show("Kérem minden mezőt töltsön ki!");
            }     

        }

    }
}
