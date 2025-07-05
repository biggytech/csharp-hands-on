namespace BankLib {
    public class DepositAccount : Account {
        public DepositAccount(decimal sum, decimal percentage) : base(sum, percentage) {}

        protected internal bool IsTimeForOperations() {
            return days % 30 == 0;
        }
        protected internal override void Open() {
            OnOpened(new AccountEventArgs($"Открыт новый депозитный счет! Id: {Id}", Sum));
        }
        public override void Put(decimal sum)
        {
            if (IsTimeForOperations()) {
                base.Put(sum);
            } else {
                OnAdded(new AccountEventArgs($"На счет можно положить только после 30-ти дневного периода", 0));
            }
        }

        public override decimal Withdraw(decimal sum)
        {
            if (IsTimeForOperations()) {
                return base.Withdraw(sum);
            } else {
                OnWithdrawed(new AccountEventArgs($"Вывести средства можно только после 30-ти дневного периода", 0));
                return 0;
            }
        }

        protected internal override void Calculate()
        {
            if (IsTimeForOperations()) {
                base.Calculate();
            }
        }
    }
}