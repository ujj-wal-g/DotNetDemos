namespace FirstDemoApp
{
    class Program1
    {
        static void Main(string[] args)
        {

            string uName, city, street;
            int pin, houseNo;
            Console.WriteLine("Please enter your name/n");
            uName = Console.ReadLine();

            Console.WriteLine("Please enter your city/n");
            city = Console.ReadLine();
            Console.WriteLine("Please enter your street");
            street = Console.ReadLine();
            Console.WriteLine("Please enter your pin");
            pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your houseNo");
            houseNo = int.Parse(Console.ReadLine());
           // display your details
             Console.WriteLine("Name={0}", uName);
            Console.WriteLine("city={0}", city);
            Console.WriteLine("street={0}", street);

            /*int n1, n2;
            int addition;
            Console.WriteLine("Enter n1");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            n2=int.Parse(Console.ReadLine());
            addition = n1 + n2;*/

            //area of rectangle 
            /*int width, height,area;
            Console.WriteLine("Enter the width");
            width =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height =Convert.ToInt32(Console.ReadLine());
            area = width * height;
            Console.WriteLine("Area is {0}",area);*/

            //calculate (a+b)^2

            /* int a, b;
             Console.WriteLine("Enter the value of a");
            a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the value of b");
             b=Convert.ToInt32(Console.ReadLine());
             int result;
             int t1, t2, t3;
             t1 = a * a;
             t2 = b * b;
             t3 = 2 * a * b;
             result = t1 + t2+t3;
             Console.WriteLine("result{0} ",result);*/

            //calculate 3.14*r^2 or Area of Circle
            /*int r;
            double area;
            float pi= 3.141592f;
            Console.WriteLine("Enter the Radius");
            r= Convert.ToInt32(Console.ReadLine());
            area = pi * r * r;
            Console.WriteLine("Area is {0}",area);*/

            //Check number is even or odd

            /*int no;
            Console.WriteLine("Enter the number");
            no = Convert.ToInt32(Console.ReadLine());
            if (no%2==0)
            {
                Console.WriteLine("Given no is even");

            }
            else
            {
                Console.WriteLine("Given no is odd");
            }
            */

            //calculate the area of triangle 
            /* int b, h;
             double area;
             Console.WriteLine("Enter the base of triangle ");
             b=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the height of triangle");
             h=Convert.ToInt32(Console.ReadLine());
             float f = 0.5f;
             area = f * b * h;
             Console.WriteLine("Area is {0}",area);*/

            //Write a program to calculate the TAX
            /* m=money
             * if m<10,000                 (tax 5%)
             * else if 10k<m<100k          (tax 8%)
             * else if m>100k              (tax 8.5%)
             */
            /*
            int m;
            float tax;
            Console.WriteLine("Enter the Money to calculate tax on it: ");
            m= int.Parse(Console.ReadLine());
            if(m<10000)
            {
                tax = (m * 5) / 100;
                Console.WriteLine("Tax Amount is Rs{0}",tax);
            }
            else if(m>10000&&m>100000)
            {
                tax = (m * 8) / 100;
                Console.WriteLine("Tax amount is Rs{0}", tax);
            }
            else
            {
                tax =(float) (m * 8.5) / 100;
                Console.WriteLine("Tax amount is Rs{0}", tax);

            }
            Console.ReadLine();
            */

            //Library Management app
            /*
            char opt;
            label:
            Console.WriteLine("Enter the c-computer,h-history,m-mathematics,e-english  Books");
            opt=char.Parse(Console.ReadLine());

            switch (opt)
            {
                case 'c':
                    Console.WriteLine("computer books are available");
                    break;
                case 'h':
                    Console.WriteLine("History books are available");
                    break;
                case 'm':
                    Console.WriteLine("Mathematics books are available");
                    break;
                case 'e':
                    Console.WriteLine("English books are available");
                    break;

                deafault:
                    Console.WriteLine("Invalid Input,Sorry");
                    goto label;

            }
            Console.ReadLine();
            */

            //calculating the percentage value of given number
            /*
            int n, perVal,opt;
            float res;
            label:
            Console.WriteLine("Enter the no");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the percentage value");
            perVal=Convert.ToInt32(Console.ReadLine());
            res = (float)(n*perVal)/100;
            Console.WriteLine("The Percentage value is{0}", res);
            Console.WriteLine("Calculate again enter 1 either 2");
            opt = Convert.ToInt32(Console.ReadLine());                                              
            if(n==1)
            {
                goto label;
            }
            else
            {
                return;
            }
            */
            //int number, percentage, option;
            //float result;

            //label:
            //    Console.Write("\n\nEnter a number:\t");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("\nEnter Percentage Value:\t");
            //    percentage = Convert.ToInt32(Console.ReadLine());

            //    result = (float)(number * percentage) / 100;
            //    Console.WriteLine("Percentage value is:\t{0}", result);
            //    Console.Write("\nCalculate again press 1. To quit press digit:\t");
            //    option = Convert.ToInt32(Console.ReadLine());
            //    if (option == 1)
            //    {
            //        goto label;
            //    }
            //    Console.WriteLine("Press Enter for quit");
            //Console.ReadLine();














                }
        }
    }