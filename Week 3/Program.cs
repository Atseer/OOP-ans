using System;
using Encapsulation.Invoicing;
using Encapsulation.Employment;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        //Invoice
        Invoice invoice1 = new Invoice("001","Saw","6","80.5");
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Total Price: {invoice1.Price}");
        Console.WriteLine($"Invoice Amount: {invoice1.GetInvoiceAmount()}");
        
        //Employee
        Employee employee1 = new Employee("Joy", "Boy","1000000");
        employee1.RaiseSalary(10);
        Console.WriteLine($"{employee1.FirstName} {employee1.LastName}'s yearly raise salary: {employee1.GetYearlySalary()}");
        
        //Date
        Date date1 = new Date(12,12,2012);
        date1.DisplayDate();

        //Banking
        BankAccount bank1 = new BankAccount("05634950","Grock","900000.7");
        Console.WriteLine($"Balance: {bank1.GetBalance()}");
        bank1.Deposit(800000);
        Console.WriteLine($"Balance after Deposit: {bank1.GetBalance()}");
        bank1.Withdraw(500000);
        Console.WriteLine($"Balance after Withdraw: {bank1.GetBalance()}");

    }
}