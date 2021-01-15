namespace CBA.Features.Entity
{
    public class Account
    {
        private double _balance = 0.00;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance 
        { 
            get 
            {
                return _balance;
            } 
        }
        public void Deposit(double number)
        {
            _balance += number;
        }

        public void Withdraw(double number)
        {
            _balance -= number;
        }
    }
}
