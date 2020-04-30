namespace Aula39.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}