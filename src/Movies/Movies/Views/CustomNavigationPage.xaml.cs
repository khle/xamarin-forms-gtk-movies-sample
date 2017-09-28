using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Movies.Views
{
    public partial class CustomNavigationPage : Xamarin.Forms.NavigationPage
    {
        public CustomNavigationPage() : base()
        {
            InitializeComponent();
        }

        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}