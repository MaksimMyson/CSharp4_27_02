namespace CSharp4_27_02
{
    public class CreditCard
    {
        private string cardNumber;
        private int cvc;
        private decimal balance;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int CVC
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CreditCard(string cardNumber, int cvc, decimal balance)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            if (card.Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null))
                return ReferenceEquals(card2, null);
            if (ReferenceEquals(card2, null))
                return false;

            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is CreditCard))
                return false;

            CreditCard other = (CreditCard)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return cardNumber.GetHashCode() ^ cvc.GetHashCode() ^ balance.GetHashCode();
        }
    }
}

