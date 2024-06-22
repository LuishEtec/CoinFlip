using System.Threading;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        String stringMoeda = String.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void moedaSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringMoeda = (String)moedaSelect.SelectedItem;
        }

        private void moedaBtn_Clicked(object sender, EventArgs e)
        {
            Random rnd = new();
            int rand = rnd.Next(2);

            if (stringMoeda == string.Empty)
            {
                DisplayAlert("Cara ou coroa", "Selecione cara ou coroa para jogar", "ok");
            }
            else
            {
                if (rand == moedaSelect.SelectedIndex)
                {
                    moedaOut.Text = "Parabens você acertou! ";
                    imgOut.Source = stringMoeda + ".png";
                }
                else
                {
                    if (moedaSelect.SelectedIndex == 0)
                    {
                        imgOut.Source = "coroa.png";
                        moedaOut.Text = "Que pena você errou!";
                    }
                    else
                    {
                        imgOut.Source = "cara.png";
                        moedaOut.Text = "Que pena você errou!";
                    }
                }
            }
        }
    }
}
