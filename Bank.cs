namespace bankprojekt
{
    public class Bank
    {
        Dictionary<string, int> accounts = new Dictionary<string, int>();
        public void NewAccount(string accountNumber)
        {
            if (string.IsNullOrWhiteSpace(accountNumber)) 
            {
                throw new ArgumentException("Érvénytelen számlaszám.");
            }

            accounts.Add(accountNumber, 0);
        }

        public int GetBalance(string accountNumber)
        {
            return accounts[accountNumber];
        }

        internal void Deposit(string accountNumber, int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be positive");
            }
            accounts[accountNumber] += amount;
        }
    }
}
