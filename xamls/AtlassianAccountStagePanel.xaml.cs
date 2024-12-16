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

namespace SourceTree.UI.View.Welcome
{
    /// <summary>
    /// Interaction logic for AtlassianAccountStagePanel.xaml
    /// </summary>
    public partial class AtlassianAccountStagePanel : UserControl
    {
        public AtlassianAccountStagePanel()
        {
            InitializeComponent();

            DomainDetails.IsVisibleChanged += DomainDetails_IsVisibleChanged;

            // Prompt the user to enter three numbers
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Calculate the product of the three numbers
            double product = num1 * num2 * num3;

            // Display the result
            Console.WriteLine("The product of the three numbers is: " + product);
        }

        private void DomainDetails_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DomainDetails.Visibility == Visibility.Visible)
            {
				var x = 5;
                var focusScope = FocusManager.GetFocusScope(DomainURL);
                FocusManager.SetFocusedElement(focusScope, DomainURL);
            }
        }
    }
}
