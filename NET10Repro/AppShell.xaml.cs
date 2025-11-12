namespace NET10Repro
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PersonDetailPage), typeof(PersonDetailPage));
        }
    }
}