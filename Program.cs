using System;

namespace Converter
{
    class Converter
    {
        private decimal EURO_RATE;
        private decimal DOLLAR_RATE;

        // Constructor 
        public Converter(decimal EURO_RATE, decimal DOLLAR_RATE)
        {
            this.EURO_RATE = EURO_RATE;
            this.DOLLAR_RATE = DOLLAR_RATE;
        }
        public decimal ConvertUAHtoEURO(decimal UAH)
        {
            try
            {
                if (EURO_RATE == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return UAH / EURO_RATE;
        }
        public decimal ConvertUAHtoDOLLAR(decimal UAH)
        {
            try
            {
                if (DOLLAR_RATE == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return UAH / DOLLAR_RATE;
        }
        public decimal ConvertEUROtoUAH(decimal EURO)
        {
            
            return EURO * EURO_RATE;
        }
        public decimal ConvertDOLLARtoUAH(decimal USD)
        {
            
            return USD * DOLLAR_RATE;
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal EUR_RATE, DOLLAR_RATE, amountUAH;
            decimal amountEURO, amountDOLLAR;
            try
            {
                Console.WriteLine("Enter UAH to EUR rate: ");
                EUR_RATE = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter UAH to USD rate: ");
                DOLLAR_RATE = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter amount of UAH in your pocket: ");
                amountUAH = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter amount of EUR in your pocket: ");
                amountEURO = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter amount of USD in your pocket: ");
                amountDOLLAR = Convert.ToDecimal(Console.ReadLine());
                try
                {
                    if((EUR_RATE == 0 && DOLLAR_RATE == 0) || (EUR_RATE == 0 || DOLLAR_RATE == 0))
                    {
                        throw new DivideByZeroException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Converter converter = new Converter(EUR_RATE, DOLLAR_RATE);
                decimal UAHToEURO = converter.ConvertUAHtoEURO(amountUAH);
                decimal UAHToDOLLAR = converter.ConvertUAHtoDOLLAR(amountUAH);
                decimal EUROToUAH = converter.ConvertEUROtoUAH(amountEURO);
                decimal DOLLARToUAH = converter.ConvertDOLLARtoUAH(amountDOLLAR);
                Console.WriteLine($"Convert {amountUAH} UAH -> EUR: {UAHToEURO} \n");
                Console.WriteLine($"Convert {amountUAH} UAH -> USD: {UAHToDOLLAR}");
                Console.WriteLine($"Convert {amountEURO} EUR -> UAH: {EUROToUAH}");
                Console.WriteLine($"Convert {amountDOLLAR} USD -> UAH: {DOLLARToUAH}");
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Input should be only decimal!!!");
                Console.ReadKey(true);
            }

            Console.ReadKey(true);



        }
    }

}