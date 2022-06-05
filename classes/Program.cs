using Classes;

namespace classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Rizky Adhi Nugroho", 1000);
            Console.WriteLine($"You have been created new bank account with the number {account.Number} and name {account.Owner} with Balance : {account.Balance}");
            account.MakeWithdrawal(500, DateTime.Now, "I need money");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(200, DateTime.Now, "For Daddy");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get a starbuck");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Buy groceries");
            giftCard.PerformMonthEndTransaction();

            giftCard.MakeDeposit(27.50m, DateTime.Now, "Add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransaction();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransaction();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
    }
}

