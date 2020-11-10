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

namespace CornerStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMaster : ContentPage
    {
        public ListView ListView;

        public DashboardMaster()
        {
            InitializeComponent();

            BindingContext = new DashboardMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DashboardMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashboardMenuItem> MenuItems { get; set; }
            
            public DashboardMasterViewModel()
            {
                MenuItems = new ObservableCollection<DashboardMenuItem>(new[]
                {
                    new DashboardMenuItem { Id = 0, Title = "Home",Image="logo_0.png"  },
                    new DashboardMenuItem { Id = 1, Title = "My Profile",Image="logo_1.png"  },
                    new DashboardMenuItem { Id = 2, Title = "Shopping History",Image="logo_4.png"  },
                    new DashboardMenuItem { Id = 3, Title = "Online Offer",Image="logo_3.png"  },
                    new DashboardMenuItem { Id = 4, Title = "Wallet",Image="logo_3.png"  },
                    new DashboardMenuItem { Id = 5, Title = "Promotion",Image="logo_2.png"  },
                    new DashboardMenuItem { Id = 6, Title = "Locate US",Image="logo_5.png"  },
                    new DashboardMenuItem { Id = 7, Title = "Share app",Image="logo_9.png"  },
                    new DashboardMenuItem { Id = 8, Title = "About Us",Image="logo_8.png"  },
                    new DashboardMenuItem { Id = 9, Title = "Contact Us",Image="logo_7.png"  },
                    new DashboardMenuItem { Id = 10, Title = "Settings",Image="logo10_.png"  },
                    new DashboardMenuItem { Id = 11, Title = "Login/SignUp",Image="logo_11.png"  },

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