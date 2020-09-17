namespace chapterFourteenProjectOne
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double CurrentBalance { get; set; }

        public Account(int accountNumber, string firstName, string lastName, double currentBalance)
        {
            this.AccountNumber = accountNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CurrentBalance = currentBalance;
        }
    }
}
