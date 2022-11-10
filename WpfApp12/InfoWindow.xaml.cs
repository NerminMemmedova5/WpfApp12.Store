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
using System.Windows.Shapes;

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for InfoWindow1.xaml
    /// </summary>
    public partial class InfoWindow1 : Window,INotifyPropertyChanged
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
        public ObservableCollection<InfoUserControl> InfoUserControls { get; set; }
        public InfoWindow1()
        {
            InitializeComponent();
            Mobiles = new ObservableCollection<Mobile>
            {
                new Mobile
                {
                    Name="Ipone 11",
                    Image="Image/iphone11.jpg",
                    Price=1500,
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="12 ay 125 AZN ",
                    System="IOS 13",
                    Memory="64 GB",
                    OperativeMemory="4 GB",
                    Color="White",
                    Year=2019,
                },
                new Mobile
                {
                    Name="Ipone 13 Mini",
                    Price=2100,
                    Image="Image/apple13mini.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="24 ay 87.50 AZN ",
                    System="IOS 15",
                    Memory="128 GB",
                    OperativeMemory="4 GB",
                    Color="Blue",
                    Year=2021,
                },
                 new Mobile
                {
                    Name="Ipone 13 Pro",
                    Price=3000,
                    Image="Image/ipone13pro.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="12 ay 250 AZN ",
                    System="IOS 15",
                    Memory="128 GB",
                    OperativeMemory="4 GB",
                    Color="White",
                    Year=2021,
                },
                 new Mobile
                {
                    Name="Ipone 14 ",
                    Price=3250,
                    Image="Image/iphone14_.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="18 ay 180.60 AZN ",
                    System="IOS 16",
                    Memory="512 GB",
                    OperativeMemory="6 GB",
                    Color="Red",
                    Year=2022,
                },

                 new Mobile
                {
                    Name="Ipone 14 Pro Max",
                    Price=3500,
                    Image="Image/ipone14promax.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="12 ay 146 AZN ",
                    System="IOS 16",
                    Memory="256 GB",
                    OperativeMemory="6 GB",
                    Color="Deep Purple",
                    Year=2022,
                },
                 new Mobile
                {
                    Name="Macbook Pro 16",
                    Price=6300,
                    Image="Image/macbookpro16.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="24 ay 263 AZN ",
                    System="MacOs",
                    Memory="512 GB",
                    OperativeMemory="16 GB",
                    Color="Space Grey",
                    
                },
                  new Mobile
                {
                    Name="Monoblok Apple",
                    Price=3500,
                    Image="Image/monoblok.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="12 ay 146 AZN ",
                    System="MacOS",
                    Memory="256 GB",
                    OperativeMemory="-",
                    Color="Gray",
                    
                },
                   new Mobile
                {
                    Name="Airpods Pro",
                    Price=500,
                    Image="Image/airpodspro.jpg",
                    MoneyImage="Image/manat_icon.PNG",
                    CardImage="Image/card_icon.PNG",
                    CardContent="6 ay 84 AZN ",
                    System="-",
                    Memory="-",
                    OperativeMemory="-",
                    Color="White",
                    Year=2022,
                },

            };
            this.DataContext = this;

            foreach (var mobile in Mobiles)
            {
                var IUC = new InfoUserControl(mobile);
                infowrappanel.Children.Add(IUC);
            }
        }

    }
}
