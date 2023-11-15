using CommunityToolkit.Mvvm.ComponentModel;

namespace TestMauidotnet8;

public partial class MyViewModel : ObservableObject
{
    [ObservableProperty]
    private string text;

    public MyViewModel()
    {
        text = "Default text";
    }
}
