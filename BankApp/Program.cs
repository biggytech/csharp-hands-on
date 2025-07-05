using System;
using BankLib;

namespace Program {

class Program {
        static void Main(string[] args) {
            Console.WriteLine("test");
            Bank<Account> bank = new Bank<Account>("ЮнитБанк");

            ProcessCommands(bank);
        }

        public static void ProcessCommands(Bank<Account> bank) {
            bool alive = true;
            while (alive) {
                UseConsoleWithColor(ConsoleColor.DarkGreen, () => {
                    Console.WriteLine("1. Открыть счет \t 2. Вывести средства \t 3. Добавить на счет");
                    Console.WriteLine("4. Закрыть счет \t 5. Пропустить день \t 6. Выйти из программы");
                });
                // ConsoleColor color = Console.ForegroundColor;
                // Console.ForegroundColor = ConsoleColor.DarkGreen;
                // Console.WriteLine("1. Открыть счет \t 2. Вывести средства \t 3. Добавить на счет");
                // Console.WriteLine("4. Закрыть счет \t 5. Пропустить день \t 6. Выйти из программы");
                // Console.ForegroundColor = color;
                
                try {
                    int command = Convert.ToInt32(Console.ReadLine());

                    switch(command) {
                        case 1:
                            OpenAccount(bank);
                            break;
                        case 2:
                            Withdraw(bank);
                            break;
                        case 3:
                            Put(bank);
                            break;
                        case 4:
                            CloseAccount(bank);
                            break;
                        case 5:
                            break;
                        case 6:
                            alive = false;
                            continue;
                        default:
                            throw new Exception("Нет такой команды");
                    }
                } catch(Exception ex) {
                    UseConsoleWithColor(ConsoleColor.Red, () => Console.WriteLine(ex.Message));
                    // color = Console.ForegroundColor;
                    // Console.ForegroundColor = ConsoleColor.Red;
                    // Console.WriteLine(ex.Message);
                    // Console.ForegroundColor = color;
                }
            }
        }

        public static void UseConsoleWithColor(ConsoleColor color, Action action) {
            ConsoleColor existingColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            action?.Invoke();
            Console.ForegroundColor = existingColor;
        }

        private static void OpenAccount(Bank<Account> bank) {
            Console.WriteLine("Укажите сумму для создания счета:");
            decimal sum = GetDecimalFromConsole();
            Console.WriteLine("Выберите тип счета: 1. До востребования 2. Депозит");
            AccountType accountType = GetAccountTypeFromConsole();
            bank.Open(accountType, sum, AddSumHandler, WithdrawHandler, CalculateHandler, CloseHandler, OpenHandler);
        }

        private static void Withdraw(Bank<Account> bank) {
            Console.WriteLine("Укажите сумму для вывода со счета:");
            decimal sum = GetDecimalFromConsole();
            Console.WriteLine("Введите id счета:");
            int id = GetIntFromConsole();
            bank.Withdraw(sum, id);
        }

        private static void Put(Bank<Account> bank) {
            Console.WriteLine("Укажите сумму, чтобы положить на счет:");
            decimal sum = GetDecimalFromConsole();
            Console.WriteLine("Введите id счета:");
            int id = GetIntFromConsole();
            bank.Put(sum, id);
        }

        private static void CloseAccount(Bank<Account> bank) {
            Console.WriteLine("Введите id счета, который надо закрыть:");
            int id = GetIntFromConsole();
            bank.Close(id);
        }

        private static void OpenHandler(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }
        private static void CloseHandler(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }
        private static void AddSumHandler(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }
        private static void WithdrawHandler(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }
        private static void CalculateHandler(object sender, AccountEventArgs e) {
            Console.WriteLine(e.Message);
        }

        public static AccountType GetAccountTypeFromConsole() {
            Console.WriteLine("Выберите тип счета: 1. До востребования 2. Депозит");
            AccountType accountType;

            int type = GetIntFromConsole();
            
            switch(type) {
                case 1:
                    accountType = AccountType.Demand;
                    break;
                case 2:
                    accountType = AccountType.Deposit;
                    break;
                default:
                    UseConsoleWithColor(ConsoleColor.Red, () => Console.WriteLine("Нет такого типа счета"));
                    return GetAccountTypeFromConsole();
            }

            return accountType;
        }

        public static decimal GetDecimalFromConsole() {
            try {
                decimal num = Convert.ToDecimal(Console.ReadLine());
                return num;
            } catch(Exception ex) {
                UseConsoleWithColor(ConsoleColor.Red, () => Console.WriteLine(ex.Message));
                return GetDecimalFromConsole();
            }
        }

        public static int GetIntFromConsole() {
            try {
                int num = Convert.ToInt32(Console.ReadLine());
                return num;
            } catch(Exception ex) {
                UseConsoleWithColor(ConsoleColor.Red, () => Console.WriteLine(ex.Message));
                return GetIntFromConsole();
            }
        }


    }
}
