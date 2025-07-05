namespace BankLib {

    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs {
        public string Message { get; private set; }
        public decimal Sum { get; private set; }
        public AccountEventArgs(string mes, decimal sum) {
            Message = mes;
            Sum = sum;
        }
    }

//     public enum AccountType {
//         Demand,
//         Deposit
//     }
}