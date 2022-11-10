using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public ObservableCollection<Mobile> Mobiles { get; set; }
        public ObservableCollection<Reklam> Reklams { get; set; }
        public ObservableCollection<UserControl1> UserControls { get; set; }
        public ObservableCollection<UserControl2> UserControls2 { get; set; }
        public ObservableCollection<InfoUserControl> InfoUserControls { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Mobiles = new ObservableCollection<Mobile>
            {
                new Mobile
                {
                    Name="Ipone 11",
                    Price=1500,
                    Image="Image/iphone11.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                new Mobile
                {
                    Name="Ipone 13 Mini",
                    Price=2100,
                    Image="Image/apple13mini.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                 new Mobile
                {
                    Name="Ipone 13 Pro",
                    Price=3000,
                    Image="Image/ipone13pro.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                 new Mobile
                {
                    Name="Ipone 14 ",
                    Price=3250,
                    Image="Image/iphone14_.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },

                 new Mobile
                {
                    Name="Ipone 14 Pro Max",
                    Price=3500,
                    Image="Image/ipone14promax.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                 new Mobile
                {
                    Name="Macbook Pro 16",
                    Price=6300,
                    Image="Image/macbookpro16.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                  new Mobile
                {
                    Name="Monoblok Apple",
                    Price=3500,
                    Image="Image/monoblok.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },
                   new Mobile
                {
                    Name="Airpods Pro",
                    Price=500,
                    Image="Image/airpodspro.jpg",
                    MoneyImage="Image/manat_icon.PNG"
                },

            };

            Reklams = new ObservableCollection<Reklam>
            {
                new Reklam
                {
                    IconImage="Image/apple_icon.png",
                    Name="iPhone 14 Plus",
                    Content="Artiq satisda",
                    Price=2650,
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="24 ay 111 AZN",
                    Image="Image/ipone_reklam.PNG"
     
                },
                new Reklam
                {
                    IconImage="Image/apple_icon.png",
                    Name="iPhone 13",
                    Content="Yalniz 20 noyabradek",
                    Price=1900,
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="24 ay 80 AZN",
                    Image="Image/iphone13reklam.PNG"

                }
            };
            this.DataContext = this;
            

            foreach (var mobile in Mobiles)
            {
                var UC1 = new UserControl1(mobile);
                wrappanel.Children.Add(UC1);
            }

            foreach (var reklam in Reklams)
            {
                var UC2 = new UserControl2(reklam);
                wrappanel1.Children.Add(UC2);
            }
        }

        private void searchTxtB_MouseEnter(object sender, MouseEventArgs e)
        {
            if(searchTxtB.Text == "Search")
            {
                searchTxtB.Text = String.Empty;
            }
        }

        private void searchTxtB_MouseLeave(object sender, MouseEventArgs e)
        {
            if (searchTxtB.Text == String.Empty)
            {
                searchTxtB.Text = "Search";
            }
        }
    }

}
