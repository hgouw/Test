namespace AccessModifier
{
    enum Enumeration { enum1, enum2, enum3 } // Enumeration is public by default

    class Class // Class is internal by default
    {
        public Class() { } // Constructor is private by default
        public int field; // Field is private by default
        public int Property { get; set; } // Property is private by default
        public void Method() { } // Property is private by default
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class cls = new Class();
            cls.field = 0;
            cls.Property = 0;
            cls.Method();
        }
    }
}