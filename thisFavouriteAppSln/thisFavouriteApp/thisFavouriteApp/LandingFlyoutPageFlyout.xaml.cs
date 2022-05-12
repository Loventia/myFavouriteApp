using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thisFavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public LandingFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new LandingFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class LandingFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<LandingFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public LandingFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<LandingFlyoutPageFlyoutMenuItem>(new[]
                {
                    new LandingFlyoutPageFlyoutMenuItem { Id = 0, Title = "Spotify",TargetType = typeof(MainPage), },
                    new LandingFlyoutPageFlyoutMenuItem { Id = 1, Title = "Create playlist", TargetType = typeof(DemoPage) },
                    new LandingFlyoutPageFlyoutMenuItem { Id = 2, Title = "Your Library" },
                    new LandingFlyoutPageFlyoutMenuItem { Id = 3, Title = "liked songs" },
                    new LandingFlyoutPageFlyoutMenuItem { Id = 4, Title = "your episodes" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}