using System;

// A bank account has a holder name (first name, middle name and last name), 
// available amount of money (balance), bank name, IBAN, 3 credit card numbers 
// associated with the account. Declare the variables needed to keep the information 
// for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string bankName = "RaiffeisenBank Bulgaria EAD";
        string firstName = "Ivan";
        string middleName = "Nikolov";
        string lastName = "Vyagov";
        object fullName = firstName + " " + middleName + " " + lastName;
        string iban = "BG12RZBB91551099966600";
        string bic = "RZBBBGSF";
        decimal balance = 6666.99M;
        ulong creditCardVisaNumber = 4143554466221133u;
        ulong creditCardMasterCardNumber = 5432101215163311u;
        ulong creditCardVisaGoldNumber = 4321889977458090u;

        Console.WriteLine(bankName);
        Console.WriteLine("\nWelcome, {0}!\n", fullName);
        Console.WriteLine("Welcome to Raiffeisen ONLINE!\n");
        Console.WriteLine("Accounts\nIBAN: {0} BIC: {1}\nBalance: {2}BGN\n", iban, bic, balance);
        Console.WriteLine("Credit card numbers\n    Visa   - {0}\nMasterCard - {1}\nVisa  Gold - {2}", creditCardVisaNumber, creditCardMasterCardNumber,
            creditCardVisaGoldNumber);
    }
}
