namespace CSharp4_27_02
{
    public class Journal
    {
        private string name;
        private int numberOfEmployees;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public Journal(string name, int numberOfEmployees)
        {
            Name = name;
            NumberOfEmployees = numberOfEmployees;
        }

        public static Journal operator +(Journal journal, int increase)
        {
            journal.NumberOfEmployees += increase;
            return journal;
        }

        public static Journal operator -(Journal journal, int decrease)
        {
            if (journal.NumberOfEmployees - decrease < 0)
                throw new InvalidOperationException("Неможливо відняти від кількості працівників, що вже є нульовою або від'ємною.");

            journal.NumberOfEmployees -= decrease;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            if (ReferenceEquals(journal1, null))
                return ReferenceEquals(journal2, null);
            if (ReferenceEquals(journal2, null))
                return false;

            return journal1.NumberOfEmployees == journal2.NumberOfEmployees;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees < journal2.NumberOfEmployees;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Journal))
                return false;

            Journal other = (Journal)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() ^ numberOfEmployees.GetHashCode();
        }
    }
}
