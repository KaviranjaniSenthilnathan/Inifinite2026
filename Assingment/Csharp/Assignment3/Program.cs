
using System;


class BankBase
{
    public int accno;
    public string cname;
    public string acctype;

    public BankBase(int accno, string cname, string acctype)
    {
        this.accno = accno;
        this.cname = cname;
        this.acctype = acctype;
    }
}

class Accounts : BankBase
{
    double balance;

    public Accounts(int accno, string cname, string acctype, double bal)
        : base(accno, cname, acctype)
    {
        balance = bal;
    }

    public void Credit(double amt)
    {
        balance += amt;
    }

    public void Debit(double amt)
    {
        if (amt > balance)
            Console.WriteLine("Not enough balance!");
        else
            balance -= amt;
    }

    public void Process(char type, double amt)
    {
        if (type == 'D') Credit(amt);
        else if (type == 'W') Debit(amt);
    }

    public void Show()
    {
        Console.WriteLine("\n--- ACCOUNT DETAILS ---");
        Console.WriteLine("Acc No: " + accno);
        Console.WriteLine("Name: " + cname);
        Console.WriteLine("Type: " + acctype);
        Console.WriteLine("Balance: " + balance);
    }
}

class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }
}


class Student : Person
{
    int rollno, sem;
    string cls, branch;
    int[] marks = new int[5];

    public Student(int rollno, string name, string cls, int sem, string branch)
        : base(name)
    {
        this.rollno = rollno;
        this.cls = cls;
        this.sem = sem;
        this.branch = branch;
    }

    public void GetMarks()
    {
        Console.WriteLine("\nEnter 5 subject marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Mark " + (i + 1) + ": ");
            marks[i] = int.Parse(Console.ReadLine());
        }
    }

    public void DisplayResult()
    {
        int total = 0;
        bool fail = false;

        foreach (int m in marks)
        {
            if (m < 35) fail = true;
            total += m;
        }

        double avg = total / 5.0;

        Console.WriteLine("\n--- RESULT ---");
        if (fail)
            Console.WriteLine("FAILED (Subject < 35)");
        else if (avg < 50)
            Console.WriteLine("FAILED (Average < 50)");
        else
            Console.WriteLine("PASSED");

        Console.WriteLine("Average: " + avg);
    }

    public void Show()
    {
        Console.WriteLine("\n--- STUDENT DETAILS ---");
        Console.WriteLine("Roll No: " + rollno);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Class: " + cls);
        Console.WriteLine("Semester: " + sem);
        Console.WriteLine("Branch: " + branch);
    }
}


class SaleBase
{
    public int salesNo, productNo;
    public double price;
    public int qty;
    public string date;

    public SaleBase(int s, int p, double price, int q, string d)
    {
        salesNo = s;
        productNo = p;
        this.price = price;
        qty = q;
        date = d;
    }
}

class SaleDetails : SaleBase
{
    double total;

    public SaleDetails(int s, int p, double price, int q, string d)
        : base(s, p, price, q, d)
    { }

    public void Sales()
    {
        total = qty * price;
    }

    public void Show()
    {
        Console.WriteLine("\n--- SALE DETAILS ---");
        Console.WriteLine("Sales No: " + salesNo);
        Console.WriteLine("Product No: " + productNo);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Qty: " + qty);
        Console.WriteLine("Date: " + date);
        Console.WriteLine("Total Amount: " + total);
    }
}

class Program
{
    static void Main()
    {
        Accounts a = new Accounts(101, "Kavi", "Savings", 5000);
        a.Process('D', 1000);
        a.Process('W', 300);
        a.Show();

        Student s = new Student(1, "Ranjani", "B.Tech", 4, "CSE");
        s.GetMarks();
        s.Show();
        s.DisplayResult();

        SaleDetails sd = new SaleDetails(200, 56, 299.5, 4, "31-03-2026");
        sd.Sales();
        sd.Show();
    }
}
