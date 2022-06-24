using System;

namespace Abstract_class_Abstract__method
{
    abstract class Bank
    {
        public Bank()
        {
            Console.WriteLine("Constructor Abstract Class :");
        }
       
        static Bank()
        {
            Console.WriteLine(" Static Constructor Abstract Class  :");
        }
        public abstract void interest();
        public void passbook()
        {
            Console.WriteLine("Non-Static Method  :");
        }
      public  static void S()
        {
            Console.WriteLine("Static Method  :");
        }
    }
    class PNB : Bank
    {
        public  override void interest()
        {
            Console.WriteLine("5%");
        }
    }
    class HDFC : Bank
    {
        public  override void interest()
        {
            Console.WriteLine("15%");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bank obj = new PNB();
            obj.interest();
            Bank H = new HDFC();
            H.interest();
            obj.passbook();
            Bank.S();

        }
    }
}
