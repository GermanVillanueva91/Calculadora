namespace Calculadora;

public partial class ResultPage : ContentPage
{
    public ResultPage(double result)
    {

     
        InitializeComponent();


        ResultLabel.Text = $"Resultado: {result}";
    }
}