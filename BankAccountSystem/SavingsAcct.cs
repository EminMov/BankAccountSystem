namespace BankAccountSystem
{
    internal class SavingsAcct : BankAccount
    {
        private decimal InterestRate = 0.025m;
        private const decimal WithdrawalCharge = 2.0m;
        private const int WithdrawalLimit = 3;
        public SavingsAcct(string firstname, string lastname, decimal interestrate, decimal balance) : base(firstname, lastname, balance)
        {
            InterestRate = interestrate;
        }

        public void ApplyInterest()
        {
            Balance *= (1 + InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > WithdrawalLimit)
            {
                Console.WriteLine($"More than {WithdrawalLimit} withdrawals! Extra withdrawal charge applied.");
                Balance -= WithdrawalCharge;
            }

            base.Withdraw(amount);
        }
    }
}