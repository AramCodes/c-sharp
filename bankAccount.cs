namespace MySuperBank
 {
        class Program
        {
            static void Main(string[] args)
            {
                var account = new BankAccount("Aram", 1000000);
                console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Amount}")

                account.MakeWithdrawl(120, DateTime.Now, "Hamilton")
                account.MakeWithdrawl(70, DateTime.Now, "PS5 Game")
                account.MakeWithdrawl(50, DateTime.Now, "SkullCandy Headphones")
                account.MakeWithdrawl(700, DateTime.Now, "4k monitor")

                console.WriteLine(account.GetAccountHistory());

            }
        }
 }

 //very much like java