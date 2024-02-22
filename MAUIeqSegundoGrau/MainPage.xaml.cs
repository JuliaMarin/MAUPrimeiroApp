namespace MAUIeqSegundoGrau
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(etyValorA.Text);
                double b = Convert.ToDouble(etyValorB.Text);
                double c = Convert.ToDouble(etyValorC.Text);

                double delta = (b * b) - 4 * a * c;

                double raiz1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double raiz2 = (-b - Math.Sqrt(delta)) / 2 * a;

                string raizes = string.Format("As raízes são: ", raiz1, " e ", raiz2);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", "Ocorreu um erro: ", ex.Message, "Ok");
            }
        }
    }

}
