namespace FactoryPattern
{
    class VisaCreditCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

       public VisaCreditCardFactory(int creditLimit, int annualCharge)
       {
           _creditLimit = creditLimit;
           _annualCharge = annualCharge;
       }

        public override Creditard GetCreditCard()
        {
            return new VisaCreditCard(_creditLimit,_annualCharge);
        }
    }
}