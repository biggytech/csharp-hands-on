namespace BankLib {
    public enum AccountType {
        Demand,
        Deposit
    }
    
    public class Bank<T> where T : Account {
        public T[] Accounts { get; private set; }

        public string Name { get; private set; }

        public Bank(string name) {
            Name = name;
        }

        public void Open(AccountType type, decimal sum, AccountStateHandler addHandler,
            AccountStateHandler withdrawHandler, AccountStateHandler calculateHandler,
            AccountStateHandler closeHandler, AccountStateHandler openHandler
        ) {
            T account = null;

            switch(type) {
                case AccountType.Demand:
                    account = new DemandAccount(sum, 0.01m) as T;
                    break;
                case AccountType.Deposit:
                    account = new DepositAccount(sum, 0.4m) as T;
                    break;
            }

            if (account is null) {
                throw new System.Exception("Ошибка создания счета");
            }

            if (Accounts is null) {
                Accounts = new T[] { account };
            } else {
                T[] newAccounts = new T[Accounts.Length + 1];
                for(int i = 0; i < Accounts.Length; i++) {
                    newAccounts[i] = Accounts[i];
                }
                newAccounts[^1] = account;
                Accounts = newAccounts;
            }

            account.Added += addHandler;
            account.Withdrawed += withdrawHandler;
            account.Calculated += calculateHandler;
            account.Closed += closeHandler;
            account.Opened += openHandler;

            account.Open();
        }

        public T GetAccountOrThrowNotFound(int id) {
            T account = FindAccount(id);
            if (account is null) {
                throw new System.Exception("Счет не найден");
            }
            return account;
        }

        public (T, int) GetAccountAndIndexOrThrowNotFound(int id) {
            int index;
            T account = FindAccount(id, out index);
            if (account is null) {
                throw new System.Exception("Счет не найден");
            }
            return ( account, index );
        }

        public void Put(decimal sum, int id) {
            T account = GetAccountOrThrowNotFound(id);
            account.Put(sum);
        }

        public decimal Withdraw(decimal sum, int id) {
            T account = GetAccountOrThrowNotFound(id);
            return account.Withdraw(sum);
        }

        public void Close(int id) {
            var (account, index) = GetAccountAndIndexOrThrowNotFound(id);
            account.Close();

            if (Accounts.Length <= 1) {
                Accounts = null;
            } else {
                T[] newAccounts = new T[Accounts.Length - 1];
                for (int i = 0, j = 0; i < Accounts.Length; i++) {
                    if (i != index) {
                        newAccounts[j++] = Accounts[i];
                    }
                }
                Accounts = newAccounts;
            }
        }

        public void CalculatePercentage() {
            if (Accounts is null) {
                return;
            }

            foreach(T account in Accounts) {
                account.IncrementDays();
                account.Calculate();
            }
        }

        public T FindAccount(int id) {
            foreach(T account in Accounts) {
                if (account.Id == id) {
                    return account;
                }
            }
            return null;
        }

        public T FindAccount(int id, out int index) {
            for (int i = 0; i < Accounts.Length; i++) {
                if (Accounts[i].Id == id) {
                    index = i;
                    return Accounts[i];
                }
            }

            index = -1;
            return null;
        }
    }
}