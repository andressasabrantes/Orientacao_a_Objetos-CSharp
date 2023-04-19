namespace ProjetoImposto
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anuallIncome, double healthExpenditures) : base(name, anuallIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnuallIncome < 20000.00) 
            {
                return AnuallIncome * 0.15 - (HealthExpenditures * 0.5);
            }
            else 
            {
                return AnuallIncome * 0.25 - (HealthExpenditures * 0.5);
            }          
        }
    }
}
