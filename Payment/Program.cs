double ProcessPayment(Enum paymentType, double amount) 
{
    if(paymentType is not PaymentType)
        return 0;
    if(paymentType is PaymentType.CreditCard)
    {
        
        return amount*98/100;
    }
    if(paymentType is PaymentType.BankTransfer)
        return amount;
    if(paymentType is PaymentType.Crypto)
        return amount*99/100;
    if(paymentType is PaymentType.PayPal)
        return amount*96/100;
    return 0;
}
Console.WriteLine(ProcessPayment(PaymentType.CreditCard, 100));
Console.WriteLine(ProcessPayment(PaymentType.BankTransfer, 100));
Console.WriteLine(ProcessPayment(PaymentType.Crypto, 100));
Console.WriteLine(ProcessPayment(PaymentType.PayPal, 100));