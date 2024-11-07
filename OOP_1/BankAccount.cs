namespace OOP_1
{
    public class BankAccount
    {
        private int _balance = 0;
        private string? _ownerName;

        public BankAccount(int startBalance)
        {
            Balance = startBalance;
        }

        public BankAccount(int startBalance, string owner)
        {
            Balance = startBalance;
            OwnerName = owner;
        }

        public int Balance
        {
            get => _balance;
            private set
            {
                if ((value >= 0) && (value <= int.MaxValue))
                {
                    _balance = value;
                }
                else if (value < 0)
                {
                    _balance = 0;
                }
            }
        }

        public void AddRubles(int rubles)
        {
            if (rubles <= 0)
                return;

            Balance += rubles;
        }

        public void WithdrawRubles(int rubles)
        {
            if (rubles <= 0)
                return;

            Balance -= rubles;
        }

        public string OwnerName
        {
            get => _ownerName ?? "NoName";
            set { _ownerName = value; }
        }
    }
}
