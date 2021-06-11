namespace part4
{
    
    public class Employee
    {
        private string firstname;
        private string lastname;
        private string address;
        private long sin;
        private double salary;
        private readonly string firstName;

        public Employee(string fistname, string lastname, string address, long sin, double salary)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name: {lastname}, Address: {address}, Sin: {sin}, Salary: {salary}";
        }

        public double CalculateTheBonus(double percentage)
        {
            return salary * percentage;
        }

        public string FirstName
        {
            get => firstname;
            set => firstname = value;
        }

        public string LastName
        {
            get => lastname;
            set => lastname = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public long Sin
        {
            get => sin;
            set => sin = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }
    }
    
    
}