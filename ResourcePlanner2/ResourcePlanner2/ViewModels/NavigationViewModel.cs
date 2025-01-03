using ResourcePlanner.Views;

namespace ResourcePlanner.ViewModels;

public partial class NavigationViewModel : ObservableObject
{
    [ObservableProperty]
    private FrameworkElement content;

    public ICommand Issues_OpenNewIssueViewCommand { get; private set; }

    public ICommand Issues_ExportIssueViewCommand { get; private set; }

    public ICommand Issues_OpenAllIssuesCommand { get; private set; }

    public ICommand Issues_OpenTrainIssuesCommand { get; private set; }

    public ICommand Issues_OpenStationIssuesCommand { get; private set; }

    public ICommand Issues_OpenOtherIssuesCommand { get; private set; }

    public NavigationViewModel()
    {
        Issues_OpenNewIssueViewCommand = new RelayCommand(() => 
        {
            Content = new CreateIssueView(new CreateIssueViewModel(this));
        });
        Issues_ExportIssueViewCommand = new RelayCommand(() => { });
        Issues_OpenAllIssuesCommand = new RelayCommand(() => { });
        Issues_OpenTrainIssuesCommand = new RelayCommand(() => { });
        Issues_OpenStationIssuesCommand = new RelayCommand(() => { });
        Issues_OpenOtherIssuesCommand = new RelayCommand(() => { });
    }

}
