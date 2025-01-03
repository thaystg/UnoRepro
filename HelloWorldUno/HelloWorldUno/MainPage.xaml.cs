using HelloWorldUno.Helpers;

namespace HelloWorldUno;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
#if __IOS__
        helloWorldText.Text = "Hello from C# on IOS";
#elif HAS_UNO_WASM
    helloWorldText.Text = "Hello from C# on WASM";
#else
        helloWorldText.Text = Greetings.GetStandardGreeting();
#endif
    }
}
