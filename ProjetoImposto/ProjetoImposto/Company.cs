namespace ProjetoImposto
{
    class Company
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anuallIncome, int numberOfEmployees) : base(name, anuallIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() 
        {
            if (NumberOfEmployees > 10) 
            {
                return AnuallIncome * 0.14
            }
            else 
            {
                return AnuallIncome * 0.16
            }
        }
    }
}
