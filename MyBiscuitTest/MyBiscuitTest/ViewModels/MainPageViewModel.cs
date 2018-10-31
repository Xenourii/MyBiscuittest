using Prism.Navigation;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace MyBiscuitTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _text;
        private Color _bgColor;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public Color BgColor
        {
            get => _bgColor;
            set => SetProperty(ref _bgColor, value);
        }

        public Command ChangeColorToBurnCommand { get; }
        public Command GoToCornichonPageCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Text = "Welcome Biscuit";
            BgColor = Color.SandyBrown;

            ChangeColorToBurnCommand = new Command(ChangeColorToBurn);
            GoToCornichonPageCommand = new Command(NavigateToCornichonPage);
        }

        private void ChangeColorToBurn()
        {
            BgColor = Color.Black;
        }

        private void NavigateToCornichonPage()
        {
            NavigationService.NavigateAsync("CornichonPage?text=" + Text);
        }
    }
}
