namespace CalculateInterest.API.Model.Interface
{
    public interface ICalculateInterest {
        decimal CalculateInterest(decimal initialValue, int timeInMonth);

        string ShowMeTheCode();
    }
}