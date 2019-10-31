using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewFlowBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> items;

        public ObservableCollection<string> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Items = new ObservableCollection<string>();
            Items.Add("Item 1");
            Items.Add("Item 2");
            Items.Add("Item 3");
            Items.Add("Item 4");

        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
