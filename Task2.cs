// You are building a payment system that supports:
// Different types of payments:

// BasicPayment

// SubscriptionPayment

// Different payment methods (gateways):

// Stripe

// PayPal

// CryptoWallet

// You must use the Bridge Design Pattern to separate payment types from payment processors.
// ✅ Your code should allow adding new Payment types or new Processors without modifying existing classes.
//  ✅ Respect Open/Closed Principle (OCP).

// 🛠 Tasks:
// Create an interface IPaymentProcessor with a method to process a payment.

// Create three concrete processors:

// StripeProcessor

// PayPalProcessor

// CryptoWalletProcessor

// Create an abstract class Payment.

// Create two concrete payments:

// BasicPayment

// SubscriptionPayment

// Payments should use the processor via constructor injection

// Each Payment should delegate the payment action to the IPaymentProcessor.


// BasicPayment and SubscriptionPayment must not know the details of Stripe, PayPal, or CryptoWallet.


// IPaymentProcessor must have a method like processPayment(amount: number): void.



interface IPaymentProcessor {
    void payment(decimal pay);

}

class StripeProcessor : IPaymentProcessor {

    public void payment(decimal pay) {
        Console.WriteLine("Stripe processed payment of $" + pay);
    }

}

class CryptoProcessor : IPaymentProcessor {

    public void payment(decimal pay) {
        Console.WriteLine("Crypto processed payment of $" + pay);
    }

}

class PayPalProcessor : IPaymentProcessor {

    public void payment(decimal pay) {
        Console.WriteLine("Paypal processed payment of $" + pay);
    }

}

abstract class PaymentAbstaction {
    private IPaymentProcessor _paymentProcessor;

    public PaymentAbstaction(IPaymentProcessor paymentProcessor) {
        this._paymentProcessor = paymentProcessor;
    }

    public void payment(decimal pay) {
        Console.WriteLine("There is a Paymant result");
        this._paymentProcessor.payment(pay);
    }
}

class BasicPayment {

    private IPaymentProcessor _paymentProcessor;

    public BasicPayment(IPaymentProcessor paymentProcessor) {
        this._paymentProcessor = paymentProcessor;
    }

    public void payment(decimal pay) {
        Console.WriteLine("There is a Paymant result");
        this._paymentProcessor.payment(pay);
        Console.WriteLine("Good luck");
    }

}

class SubscriptionPayment {

    private IPaymentProcessor _paymentProcessor;

    public SubscriptionPayment(IPaymentProcessor paymentProcessor) {
        this._paymentProcessor = paymentProcessor;
    }

    public void payment(decimal pay) {
        Console.WriteLine("There is a Paymant result");
        this._paymentProcessor.payment(pay);
        Console.WriteLine("Subscription will automatically renew monthly.");    
    }

}