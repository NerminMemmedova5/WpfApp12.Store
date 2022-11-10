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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for InfoUserControl.xaml
    /// </summary>
    public partial class InfoUserControl : UserControl
    {
       
        public Mobile  Mobile { get; set; }
        public InfoUserControl(Mobile mobile)
        {
            InitializeComponent();
            this.DataContext = this;
            this.Mobile = mobile;
        }

        
    }
}
