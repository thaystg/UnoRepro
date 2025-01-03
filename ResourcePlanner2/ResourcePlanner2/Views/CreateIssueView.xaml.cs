using ResourcePlanner.ViewModels;
using UnoBookRail.Common.Issues;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ResourcePlanner.Views;

public sealed partial class CreateIssueView : UserControl
{
    public CreateIssueViewModel CreateIssueViewModel { get; private set; }

    public CreateIssueView(CreateIssueViewModel viewModel)
    {
        CreateIssueViewModel = viewModel;
        this.InitializeComponent();
    }

    private void TitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        EvaluateFieldsValid(sender);
    }

    private bool EvaluateFieldsValid(object sender)
    {
        bool allValid = true;

        if (sender == TitleTextBox || sender == null)
        {
            if (TitleTextBox.Text.Length == 0)
            {
                allValid = false;
                TitleErrorNotification.Text = "Title must not be empty";
            }
            else
            {
                TitleErrorNotification.Text = string.Empty;
            }
        }

        return allValid;
    }

    private void CreateIssueButton_Click(object sender, RoutedEventArgs e)
    {
        if (EvaluateFieldsValid(null))
        {
            CreateIssueViewModel.CreateIssueCommand.Execute(null);
        }
    }

    private void TrainNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}
