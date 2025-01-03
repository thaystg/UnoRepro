using ResourcePlanner.Models;
using UnoBookRail.Common.Auth;
using UnoBookRail.Common.Issues;

namespace ResourcePlanner.ViewModels;
public partial class CreateIssueViewModel : ObservableObject
{
    public readonly ICommand CreateIssueCommand;

    // General fields
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";

    [ObservableProperty]
    private IssueType issueType = IssueType.Train;
    
    public Urgency Urgency { get; set; }

    // Train fields
    public string TrainNumber { get; set; } = "";

    // Station fields
    public string StationName { get; set; } = "";

    // "Other" fields
    public string Location { get; set; } = "";

    public CreateIssueViewModel(NavigationViewModel navigationVM)
    {
        CreateIssueCommand = new RelayCommand(() =>
        {
            var issue = new Issue()
            {
                IssueType = IssueType,
                Title = Title,
                Description = Description,
                Urgency = Urgency,
                OpenDate = DateTime.Now,
                IsOpen = true,
                OpenedBy = Authentication.GetCurrentUser()
            };

            switch (IssueType)
            {
                case IssueType.Train:
                    issue.TrainNumber = TrainNumber;
                    break;
                case IssueType.Station:
                    issue.StationName = StationName;
                    break;
                case IssueType.Other:
                    issue.Location = Location;
                    break;
            }
            IssuesRepository.AddIssue(issue);
            navigationVM.Issues_OpenAllIssuesCommand.Execute(null);
        });
    }
}
