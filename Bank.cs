namespace bankprojekt
{
    public class Bank
    {
        Dictionary<string, int> accounts = new Dictionary<string, int>();
        public void NewAccount(string accountNumber)
        {
            accounts.Add(accountNumber, 0);
        }

        public int GetBalance(string accountNumber)
        {
            return accounts[accountNumber];
        }

        internal void Deposit(string accountNumber, int amount)
        {
            accounts[accountNumber] += amount;
        }
    }
}
