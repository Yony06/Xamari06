namespace Xamari06
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasado = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string text= ((Entry)sender).Text;
        }
    }

}
