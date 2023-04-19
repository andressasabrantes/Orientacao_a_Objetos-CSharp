namespace ProjetoImposto
{
    abstract class TaxPayer
    {

        public string Name { get; set; }
        public double AnuallIncome { get; set; }

       
        protected TaxPayer(string name, double anuallIncome) 
        {
            Name = name;
            AnuallIncome = anuallIncome;
        }

        public virtual double Tax();
    }
}
