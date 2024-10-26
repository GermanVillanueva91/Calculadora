namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
       private MathOperations mathOps = new MathOperations();

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Entry1.Text);
            double num2 = Convert.ToDouble(Entry2.Text);
            var result = mathOps.Add(num1, num2);
            await Navigation.PushAsync(new ResultPage(result));
        }



    }

}
