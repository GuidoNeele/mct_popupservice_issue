using CommunityToolkit.Maui.Core;

namespace TestMauidotnet8
{
    public partial class MainPage : ContentPage
    {
        private readonly IPopupService popupService;
        int count = 0;

        public MainPage(IPopupService popupService)
        {
            InitializeComponent();
            this.popupService=popupService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            popupService.ShowPopup<MyViewModel>();
        }
    }

}
