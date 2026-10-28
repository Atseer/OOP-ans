namespace Encapsulation.Employment;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private double _monthSalary;

    public string FirstName
    {
        get {return _firstName;}
        set {_firstName = value;}
    }
    public string LastName
    {
        get {return _lastName;}
        set {_lastName = value;}
    }

    public double MonthlySalary
    {
        get {return _monthSalary;}
        set
        {
            if (value >= 0)
            {
                return _monthSalary;
            }
        }
    }
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        if(string.IsNullOrEmpty(firstName))
        _firstName = "Unknown";
        else
        _firstName = firstName;

        if(string.IsNullOrEmpty(lastName))
        _lastName = "Unknown";
        else
        _lastName = lastName;

        if(monthlySalary < 0)
        _monthSalary = 0.0;
        else
        _monthSalary = monthlySalary;
    }

    public void RaiseSalary(int raisePrecentage)
    {
        if(raisePrecentage >= 0 && raisePrecentage <= 20)
        _monthSalary += _monthSalary * raisePrecentage / 100.0;
    }
    public double GetYearlySalary()
    {
        return _monthSalary * 12;
    }

}



