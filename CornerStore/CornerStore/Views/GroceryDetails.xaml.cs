using CornerStore.Models;
using CornerStore.Models.Api_Calls;
using CornerStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CornerStore.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroceryDetails : TabbedPage
	{
		public GroceryDetails ()
		{
			InitializeComponent ();
            this.Title = Models.Api_Calls.Helper.SubCategoryTitle;

        }

        private void TabbedPage_CurrentPageChanged(object sender, EventArgs e)
        {
            TabbedPage page =(TabbedPage) sender;
            GroceryModel data = (GroceryModel)page.SelectedItem;
            Helper.SubCategorybyGroupID = data.PROD_GRP_ID;
            

            SubCategoryByGroupID_VM groupID_VM = new SubCategoryByGroupID_VM();
            groupID_VM.refresh();
         
        }
    }
}