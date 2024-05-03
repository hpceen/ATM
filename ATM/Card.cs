namespace ATM;

public struct Card
{
    public string CardNumber { init; get; }
    public string PinCode { init; get; }
    public double Balance { get; set; }
    public string ClientName { init; get; }

    public Card(string cardNumber, string pinCode, double balance, string clientName)
    {
        CardNumber = cardNumber;
        PinCode = pinCode;
        Balance = balance;
        ClientName = clientName;
    }
}