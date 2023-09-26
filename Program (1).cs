using System;
using System.Drawing;
using System.Xml.Linq;

namespace CSlabPrograms
{
    //1 Employee details
    class Employee
    {
        String name;
        int age;
        double salary;
        public void EmployeeDetails()
        {
            Console.Write("Enter the name :");
            name = Console.ReadLine();
            Console.Write("Enter the age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the salary :");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee Details");
            Console.WriteLine(name + " " + age + " " + salary);
        }
    }
    //2 Bank Account
    class BankAccount
    {
        int Account_Number;
        String AccountHolderName;
        double Balance = 0;
        internal void deposit()
        {
            Console.WriteLine("Enter the amount to deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            Balance += amount;
            Console.WriteLine("the amount is deposited sucessfully");

        }
        internal void widraw()
        {
            Console.WriteLine("Enter the amount to widraw");
            int amount = Convert.ToInt32(Console.ReadLine());
            Balance -= amount;
            Console.WriteLine("the amount is widraw sucessfully");

        }
        internal void display()
        {
            Console.WriteLine("Account Number :" + Account_Number);
            Console.WriteLine("Account Holder Name :" + AccountHolderName);
            Console.WriteLine("Account Balance :" + Balance);
        }
    }
    //5 partial class
    partial class person
    {
        String FirstName;
        String LastName;
        public void PersonDetails()
        {
            Console.Write("Enter the First name :");
            FirstName = Console.ReadLine();
            Console.Write("Enter the Last name :");
            LastName = Console.ReadLine();
        }
    }
    partial class person
    {
        public void PrintFullName()
        {
            PersonDetails();
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    //6 partial class
    partial class Employee1
    {
        String name;
        int age;
        double salary;
        public void EmployeeDetails()
        {
            Console.Write("Enter the name :");
            name = Console.ReadLine();
            Console.Write("Enter the age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the salary :");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee Details");
            Console.WriteLine(name + " " + age + " " + salary);
        }
    }
    partial class Employee1
    {
        public void SalaryFactor()
        {
            if (salary > 100000)
            {
                Console.WriteLine("you are a Manager");
            }
            else
            {
                Console.WriteLine("you are a Employee");
            }
        }
    }
    //3 Static class
    static class MathHelper
    {
        static void CalculateAvg()
        {
            int[] arr = new int[5];
            float sum = 0;
            float Avg = 0;
            Console.WriteLine("Enter the values:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Avg = sum / 10;
            Console.WriteLine("Average of array values:" + Avg);
            Console.ReadKey();

        }
    }


    //4.Program static class

    static class Logger
    {
        public static void Message()
        {
            Console.WriteLine("hello");
            Console.ReadKey();
        }

    }

    //7(A) program abstract class

    abstract class Shape
    {
        public double Height;
        public double width;
        public double Radius;
        public abstract double CalculateArea();
        
    }
    class Circle : Shape
    {
        public void show()
        {
            Console.WriteLine("Enter Radius of Circle");
            double Radius = Convert.ToInt32(Console.ReadLine());
            this.Radius = Radius;
        }
        public override double CalculateArea()
        {
            return (3.14) * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public void show1()
        {
            Console.WriteLine("Enter Height of Reactangle");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of Reactangle");
            double width = Convert.ToInt32(Console.ReadLine());
            this.Height = height;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return Height * width;
        }
    }
    // 8 program abstract class
    abstract class animals
    {
        public string name;
        public int age;
        public void show()
        {
            Console.WriteLine("these all are the animals of PetOwner");
        }

        
    }
    class Dog : animals
    {
        public void show1()
        {
            Console.WriteLine("Enter Dog Name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Dog age :");
            int Age = Convert.ToInt32(Console.ReadLine());
            this.name = Name;
            this.age = Age;
            Console.WriteLine("The Dog name is : " + name + " " + "The Dog age is : " + age);
        }
    }
    class cat : animals
    {
        public void show2()
        {
            string Name = Console.ReadLine();
            int Age = Convert.ToInt32(Console.ReadLine());
            this.name = Name;
            this.age = Age;
            Console.WriteLine("The cat name is " + name + " " + "The cat age is " + age);
        }
    }

    // 9 program sealed class
    sealed class vehicles
    {
        public void startEngine()
        {
            Console.WriteLine("Car Engine is start ");
        }
        public void StopEngine()
        {
            Console.WriteLine("Car Engine is stop ");
        }

    }
    class car : vehicles
    {
        public void startCar() 
        {
            Console.WriteLine("Car is started ");
        }
        
    }

    // 10 program sealed class
    class Bank_Account
    {
        int AccountNumber;
        int Balance;
        public void Detail()
        {
            Console.WriteLine("Enter the Account Number :");
            int accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Balance :");
            int balance1 = Convert.ToInt32(Console.ReadLine());
            this.AccountNumber = accountNo;
            this.Balance = balance1;
        }
    
    }
    sealed class SavingAccount : Bank_Account
    {
        public void interestcalcution()
        {
            int year;
            double P, R, I, T;
            Console.WriteLine("enter the amount :");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the number of years : ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest :");
            R = Convert.ToDouble(Console.ReadLine());
            I = P * year * R / 100;
            T = P + I;
            Console.WriteLine("Total amount : ", T);
            Console.ReadLine();

        }
    }
    class Call 
    {
        public static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            obj1.EmployeeDetails();
            BankAccount obj2 = new BankAccount();
            obj2.deposit();
            obj2.widraw();
            obj2.display();
            /*MathHelper obj3 = new MathHelper();
            obj3.CalculateAvg();
            Logger obj4 = new Logger();
            obj4.Message();
            */
            person obj5 = new person();
            obj5.PrintFullName();
            Employee1 obj6 = new Employee1();
            obj6.EmployeeDetails();
            obj6.SalaryFactor();
            Circle obj7a = new Circle();
            obj7a.show();
            obj7a.CalculateArea();
            Rectangle obj7b = new Rectangle();
            obj7b.show1();
            obj7b.CalculateArea();
            cat obj8a= new cat();
            obj8a.show();
            obj8a.show2();
            Dog obj8b= new Dog();
            obj8b.show();
            obj8b.show1();
            //car obj9 = new car();
            //obj9.startCar();
            SavingAccount obj10 = new SavingAccount();
            obj10.interestcalcution();
        Console.ReadKey();
        }
    }
}