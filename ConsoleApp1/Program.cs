using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5 , b = 15;
            //function to print the prime numbers
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            //function to print the sum of the series
            Console.WriteLine("2 .The sum of the series is: " + r1);

            long n2 = 15;
            //function to convert decimal to binary
            long r2 = decimalToBinary(n2);
            Console.WriteLine("3 .Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.WriteLine();


            long n3 = 1111;
            //function to convert binary to decimal
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("4 .Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.WriteLine();


            int n4 = 5;
            //function to print the triangle.
            printTriangle(n4);

            int[] arr = new int[] { 2,3,4,2,3,4 };
            //funtion to count the frequency of numbers in an array.
            computeFrequency(arr);





            Console.Read();
        }
        //self reaction: while doing this assignment I could brush my basic alogorithmic skills and also could learn,
        // implement the basic problems in c#. i feel this is much needed to get into the right shoes to be able to do much complex
        // assignments in the future.
        public static void printPrimeNumbers(int x, int y)
        {
            
            try
            {

                if (x >y)
                {       // cannot   calculate the prime numbers if x > y
                    Console.WriteLine("1 . to print the Prime numbers Y cannot be greater the X");
                    return; 
                }
                Console.WriteLine(" 1. Prime numbers between " + x + " and " + y + " are");

                for (int i=x;i<y;i++)
                { //loping each value between x and y and check if the number is prime.
                    bool prime = true;
                    
                    for(int j=2;j<i;j++)
                    {
                        if (i != j && i % j == 0)  //check if i is not equal to j and  i divided by j eequal to 0
                            prime = false; // if the condition is satisfied assign the prime variable to false.
                    }
                    if (prime == true)
                        Console.WriteLine(i);// printing the number if it is a prime number.
                }
            }
            
            catch
            {
                // log for if any exception occured.
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");

            }
            Console.WriteLine();
        }
        public static double getSeriesResult(int n)
        {
            if(n<1)
            {// if the input is less than 1
                Console.WriteLine("input cannot be less than 1");
                return -1;
                
            }
            double mul = 0; //factor to multiply with  each term of the series
            double sum = 0;// variable to hold the sum of the series
            try
            {
               for(int i=1;i<=n;i++)
                {
                    if (i % 2 == 0) mul = -1; // if i is even then mul=-1
                    if (i % 2 != 0) mul = 1;// if i is even then mul=1
                    // calculate the factorial and hold in the variable fact
                    double fact = getfactorial(i);
                    //logic to calculate the sum
                    sum = sum + (mul*(fact / (i + 1)));
                    

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            Console.WriteLine();
            return sum;
        }
        //method to calculate the factorial
        public static double getfactorial(int n)
        {
          double  sum = 1;
            for(int i=n;i>=1;i--)
            {   //looping through 1 to n and multiplying it with sum and adding it to the sum.
                sum = sum * i;
               
            }
            return sum; 
        }

        //method to convert decimal to binary
        public static long decimalToBinary(long n)
        {
            long bin= 0;//initilizing the binary to 0.
            long rem = 0;// variable to hold the reminder
            long i = 1;// initilizing the multiplier to 1.
           
            if(n<0)
            {
                Console.WriteLine("input cannot be less than zero");
                return -1;
            }
            try
            {
                // Write your code here
                while (n != 0) // looping untill n is not equal to 0
                {
                    rem = n % 2;//calculate the reminder when n is divided ny 2
                    n = n / 2; //divide the number by 2
                    bin = bin + rem * i;//multiply the reminder with i and add it to the bin
                    i = i * 10;//multioly i with 10
                }
            }
            catch
            {   //log for any exception
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            Console.WriteLine();

            return bin;
        }

        public static long binaryToDecimal(long n)
        {
            long dec=0; //initializing the decimal to zero
            long rem = 0;// intializing the reminder to zero
            long i = 1;// initialzing the multiplier to 1.
            if (n < 0)
            {// if n is less than 0 print that input cannit be less than zero.
                Console.WriteLine("input cannot be less than zero");
                return -1;
            }
            try
            {
                // Write your code here
                while(n!=0) // loop while n is not equal to zero
                {
                    rem = n % 10; // calculate the reminder when n divided by 10
                    n = n / 10; // divide the number n by 10.
                    dec = dec + rem * i; //multiply  the reminder with i and add it to the dec variable.
                    i = i * 2; //multiply i with 2.
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return dec;
        }
        // method to print the triangle.
        public static void printTriangle(int n)
        {
            int rows = n;// variable to hold the number if rows
            int spaces = 0; // varible to hold the number of spaces.
            int stars = 0;// variable to hold the number of stars
            try
            {
                if (n < 0)
                {// if n is less than 0 print that input cannit be less than zero.
                    Console.WriteLine("input cannot be less than zero");
                    return ;
                }
                Console.WriteLine("5 .printing the triangle below");
                for (int i=1;i<=rows;i++)
                { //looping through each row
                    spaces = rows - i; //calculate the number of space
                    stars = 2 * i - 1;//calculate the number of stars.
                    while(spaces!=0)
                    {//looping until the spaces is equal to zero.
                        Console.Write(" "); // print the space.
                        spaces--; // decrement the spaces.
                    }
                    while(stars!=0)
                    {//looping until stars equal to zero.
                        Console.Write("*");//printing the stars
                        stars--;//decrement th stars.
                    }
                    Console.WriteLine();
                }
            }
            catch
            {  //log if any exception.
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
            Console.WriteLine();

        }
        //method to comppute the frequency
        public static void computeFrequency(int[] a)
        {
            try
            {
                if(a.Length==0)
                {// length of the array cannot be zero.
                    Console.WriteLine("length of the array cannot be zero");
                }
                Array.Sort(a);//sorting the array.
                int current = a[0];//initializing the first element of the array to the current variable
                int freq = 1;//initializing the frequency to 1
                Console.WriteLine("6. Printing the numbers and frequency below");
                for (int i = 1; i < a.Length;i++) 
                { //looping through the second elemnt of the array.
                    if (a[i] == current)// comparing if the ith element is equal to the current.
                    {
                        freq++;// if yes increment the frequency.
                    }
                    else

                    {   // if the ith element is not equal to the current element.
                        Console.WriteLine("number -->" + a[i - 1] + " frequency -->" + freq);
                        freq = 1; //initilize freq to 1.
                        current = a[i];// initilize the current variable to the ith element.
                    }

                }
                Console.Write("number -->" + a[a.Length - 2] + " frequency -->" + freq);
                //printing the number and frequency if the last element.
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }


    }
}
