namespace BankAccountSystem
{
    internal class CheckingAcct : BankAccount
    {
        public CheckingAcct(string firstname, string lastname, decimal balance) : base(firstname, lastname, balance)
        {
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Overdrawn! Extra $35.00 charge applied.");
                Balance -= 35.0m;
            }
            base.Withdraw(amount);
        }
    }
}