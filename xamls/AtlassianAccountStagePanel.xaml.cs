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
