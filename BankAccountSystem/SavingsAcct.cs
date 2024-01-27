namespace BankAccountSystem
{
    internal class SavingsAcct : BankAccount
    {
        private decimal InterestRate = 0.025m;
        private const decimal WithdrawalCharge = 2.0m;
        private const int WithdrawalLimit = 3;

        private int withdrawalCount;

        public SavingsAcct(string firstname, string lastname, decimal interestrate, decimal balance) : base(firstname, lastname, balance)
        {
            InterestRate = interestrate;
            withdrawalCount = 0;
        }

        public void ApplyInterest()
        {
            Balance *= (1 + InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if (withdrawalCount >= WithdrawalLimit)
            {
                Console.WriteLine($"More than {WithdrawalLimit} withdrawals! Extra withdrawal charge applied.");
                Balance -= WithdrawalCharge;
            }
            withdrawalCount++;
            base.Withdraw(amount);
        }
    }
}