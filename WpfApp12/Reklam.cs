using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12
{
    public class Reklam: INotifyPropertyChanged
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
        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged(); }
		}

		private string iconimage;

		public string IconImage
		{
			get { return iconimage; }
			set { iconimage = value; OnPropertyChanged(); }
		}

		private string content;

		public string Content
		{
			get { return content; }
			set { content = value; OnPropertyChanged(); }
		}

		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; OnPropertyChanged(); }
		}

		private string moneyimage;

		public string MoneyImage
		{
			get { return moneyimage; }
			set { moneyimage = value; OnPropertyChanged(); }
		}

		private string cardimage;

		public string CardImage
		{
			get { return cardimage; }
			set { cardimage = value; OnPropertyChanged(); }
		}
		private string cardcontent;

		public string CardContent
		{
			get { return cardcontent; }
			set { cardcontent = value; OnPropertyChanged(); }
		}

		private string image;

		public string Image
		{
			get { return image; }
			set { image = value; OnPropertyChanged(); }
		}


	}
}
