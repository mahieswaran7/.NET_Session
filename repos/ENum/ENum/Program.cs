using System.Net.Http.Headers;

enum PaymentOptions
{
    CreditCard, DebitCard, NetBanking, Wallet
}
class Payment
{
    public string invoicename { get; set; }
    public PaymentOptions options;
    public override string ToString()
    {
        System.Console.WriteLine(base.GetHashCode());
        return "Class1.ToString";
    }
}
class Program
{
    private static void Main(string[] args)
    {
        Payment p1, p2;

        p1 = new Payment();
        p2 = new Payment();

        bool b = p1.Equals(p2);

        Console.WriteLine((b));

        int t1 = p1.GetHashCode();
        Console.WriteLine(t1);

        string c = t1.ToString();
        Console.WriteLine(c);

    }
    //override the ToString() method, which is the virtual method in System.Object class
    public override string ToString()
    {
        System.Console.WriteLine(base.GetHashCode());
        return "ToString";
    }


    /*
    Payment p = new Payment();
    p.invoicename = "BroadBandBill";
    p.options = PaymentOptions.CreditCard;
 
    Console.WriteLine(p.invoicename + " is paid by " +p.options);
    p.invoicename = "AmazonShopping";
    p.options = PaymentOptions.Wallet;
    Console.WriteLine(p.invoicename + " is paid by " + p.options);
}*/
}