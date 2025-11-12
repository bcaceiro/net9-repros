namespace NET10Repro
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            var person = new Person
            {
                Name = "John Doe",
                Id = 1
            };
            var navigationParameter = new ShellNavigationQueryParameters
                {
                    { "CurrentPerson", person }
                };

            Shell.Current.GoToAsync(nameof(PersonDetailPage), false, navigationParameter);

            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}