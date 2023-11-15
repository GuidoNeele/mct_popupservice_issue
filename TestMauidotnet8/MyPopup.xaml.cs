using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace TestMauidotnet8;

public partial class MyPopup : Popup
{
    readonly IPopupService popupService;
    
    public MyPopup(MyViewModel myViewModel, IPopupService popupService)
    {
        InitializeComponent();
        this.popupService = popupService;
        BindingContext = myViewModel;
    }
    
    void HandleButtonClicked(object? sender, EventArgs e)
    {
        popupService.ShowPopup((MyViewModel)BindingContext);
    }
}