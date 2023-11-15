using CommunityToolkit.Maui.Views;

namespace TestMauidotnet8;

public partial class MyPopup : Popup
{
    public MyPopup(MyViewModel myViewModel)
    {
        InitializeComponent();

        BindingContext = myViewModel;
    }
}