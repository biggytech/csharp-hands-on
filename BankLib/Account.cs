namespace BankLib {
    public abstract class Account : IAccount {
        protected internal event AccountStateHandler Withdrawed;
        protected internal event AccountStateHandler Added;
        protected internal event AccountStateHandler Opened;
        protected internal event AccountStateHandler Closed;
        protected internal event AccountStateHandler Calculated;

        static int counter = 0;
        protected int days = 0;

        public decimal Sum { get; private set; }
        public decimal Percentage { get; private set; }
        public int Id { get; private set; }

        public Account(decimal sum, decimal percentage) {
            Sum = sum;
            Percentage = percentage;
            Id = ++counter;
        }

        private void CallEvent(AccountEventArgs e, AccountStateHandler handler) {
            if (e != null) {
                handler?.Invoke(this, e);
            }
        }

        protected virtual void OnOpened(AccountEventArgs e) {
            CallEvent(e, Opened);
        }
        protected virtual void OnClosed(AccountEventArgs e) {
            CallEvent(e, Closed);
        }
        protected virtual void OnAdded(AccountEventArgs e) {
            CallEvent(e, Added);
        }
        protected virtual void OnWithdrawed(AccountEventArgs e) {
            CallEvent(e, Withdrawed);
        }
        protected virtual void OnCalculated(AccountEventArgs e) {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum) {
            Sum += sum;
            OnAdded(new AccountEventArgs($"На счет поступило {sum}", sum));
        }

        public virtual decimal Withdraw(decimal sum) {
            decimal result = 0;
            
            if (Sum >= sum) {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs($"Сумма {result} снята со счета {Id}", result));
            } else {
                OnWithdrawed(new AccountEventArgs($"Недостаточно денег на счете {Id}", result));
            }

            return result;
        }

        protected internal virtual void Open() {
            OnOpened(new AccountEventArgs($"Открыт новый счет! Id: {Id}", Sum));
        }
        protected internal virtual void Close() {
            OnClosed(new AccountEventArgs($"Счет {Id} закрыт. Итоговая сумма: {Sum}", Sum));
        }

        protected internal virtual void IncrementDays() {
            days++;
        }

        protected internal virtual void Calculate() {
            decimal increment = Sum * Percentage;
            Sum += increment;
            OnCalculated(new AccountEventArgs($"Начислены проценты в размере: {increment}", increment));
        }
    }
}