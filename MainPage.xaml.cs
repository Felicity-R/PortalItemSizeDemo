using Esri.ArcGISRuntime.Portal;

namespace PortalItemSizeDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var portal = await ArcGISPortal.CreateAsync();
            var portalItem = await PortalItem.CreateAsync(portal, "8c6ad98330ec4e10b15990c810d234ff");

            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time.";
            else
                CounterBtn.Text = $"Clicked {count} times.";

            CounterBtn.Text += $" Portal item size is { portalItem.Size }.";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
