using GPlayMusicJbml.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GPlayMusicJbml.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}