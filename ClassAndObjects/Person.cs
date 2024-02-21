// See https://aka.ms/new-console-template for more information

    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        private double _salary { get; set; }

        public void setSalary(double LocalSalary)
        {
             _salary = LocalSalary;
        }


    public double getSalary () 
    { return _salary; }

    public string FullName()
    {
        return $"{ FirstName} { LastName}" ;
    }

    public string FullName(string Middlename)
    {
        return $"{FirstName} {Middlename} { LastName}";
    }

}



