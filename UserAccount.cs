namespace DebitAndCredit
{
    class UserAccounts
    {
        decimal _customerAmount = 1000M;
        decimal _amountToCredit;

        decimal _amountToDebit;

        //creating the medthods for the class
        public decimal credit(decimal amountToCredit)
        {
            _amountToCredit = amountToCredit;
            return _customerAmount += amountToCredit;
        }

        public decimal debit(decimal amountToDebit)
        {
            this._amountToDebit = amountToDebit;
            return _customerAmount -= amountToDebit;
        }
        public decimal balance()
        {
            return this._customerAmount;
        }
    }

        }
    
