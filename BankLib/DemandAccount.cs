namespace BankLib {
    public class DemandAccount : Account {
        public DemandAccount(decimal sum, decimal percentage) : base(sum, percentage) {}

        protected internal override void Open() {
            OnOpened(new AccountEventArgs($"Открыт новый счет до востребования! Id: {Id}", Sum));           
        }
    }
}