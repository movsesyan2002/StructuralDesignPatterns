interface IPaymentService {
    void makePayment(int amount);
    void refundPayment(int amount);
}

class RealPaymentService : IPaymentService {

    public void makePayment(int amount) {
        Console.WriteLine($"paid ${amount}");
    }

    public void refundPayment(int amount) {
        Console.WriteLine($"refunded ${amount}");
    }

}


class User {
    public string UserName { get; set; }
    public string Role { get; set; }

    public User (string username, string role) {
        UserName = username;
        Role = role;
    }


}

class PaymentServiceProxy : IPaymentService {

    private RealPaymentService _realpaymentservice;
    private User _user;

    public PaymentServiceProxy(User user) {
        _user = user;
    }

    public void makePayment(int amount) {
        
        Console.Write($"{_user.UserName}");
        _realpaymentservice.makePayment(amount);

    }


    public void refundPayment(int amount) {
        
        if (string.Compare(_user.UserName,"admin",true) == 0) {
        
            Console.Write($"{_user.UserName}");
            _realpaymentservice.refundPayment(amount);
        
        }
        
        if (string.Compare(_user.UserName,"user",true) == 0) {
        
            throw new Exception($"Access Denied: {_user.UserName} is not authorized to refund.");
        
        }
        
    }
}