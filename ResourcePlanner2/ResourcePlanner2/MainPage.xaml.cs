using ResourcePlanner.ViewModels;

namespace ResourcePlanner;

public sealed partial class MainPage : Page
{
    public NavigationViewModel NavigationViewModel { get; private set; } = new NavigationViewModel();

    public MainPage()
    {
        this.InitializeComponent();
    }
}
