namespace Aula40.Entities
{
    sealed public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //sobrescrita de método WithDraw
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);

            Balance -= 2.0;
        }
    }
}