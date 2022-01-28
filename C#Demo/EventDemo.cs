namespace FirstDemoApp
{
    class EventDemo
    {
        // Subscriber class
        static void Main(string[] args)
        {
            AddTwoNum addtwonum = new AddTwoNum();
            addtwonum.ev_OddNumber += new AddTwoNum.dg_OddNumber(EventMessage);
            //a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            addtwonum.add();
          //  Console.ReadKey();

        }
        static void EventMessage()
        {
            Console.WriteLine("Event triggered Beacuse this is an odd number ");
        }
    }

    //Publisher class
    class AddTwoNum
    {
        public delegate void dg_OddNumber();
        public event dg_OddNumber ev_OddNumber;

        public void add()
        {
            int result;
            result = 5 + 4;
            if (result % 2 != 0 && ev_OddNumber != null)
                ev_OddNumber();
        }

    }


}
