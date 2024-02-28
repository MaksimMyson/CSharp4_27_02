namespace CSharp4_27_02
{
    public class Store
    {
        private string name;
        private double area;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public Store(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public static Store operator +(Store store, double increase)
        {
            store.Area += increase;
            return store;
        }

        public static Store operator -(Store store, double decrease)
        {
            if (store.Area - decrease < 0)
                throw new InvalidOperationException("Площа магазину не може стати від'ємною.");

            store.Area -= decrease;
            return store;
        }

        public static bool operator ==(Store store1, Store store2)
        {
            if (ReferenceEquals(store1, null))
                return ReferenceEquals(store2, null);
            if (ReferenceEquals(store2, null))
                return false;

            return store1.Area == store2.Area;
        }

        public static bool operator !=(Store store1, Store store2)
        {
            return !(store1 == store2);
        }

        public static bool operator >(Store store1, Store store2)
        {
            return store1.Area > store2.Area;
        }

        public static bool operator <(Store store1, Store store2)
        {
            return store1.Area < store2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Store))
                return false;

            Store other = (Store)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() ^ area.GetHashCode();
        }
    }
}

