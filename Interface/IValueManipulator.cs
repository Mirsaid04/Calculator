namespace Calculator.Classes;

internal interface IValueManipulator
{
    public decimal GetUserValueByMessage(string message);
    public string GetInputByMessageToAction(string message);

    public void ShowMenu();
}