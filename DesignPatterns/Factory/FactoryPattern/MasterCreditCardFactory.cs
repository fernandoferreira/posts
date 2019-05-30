namespace FactoryPattern
{
    class MasterCreditCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MasterCreditCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override Creditard GetCreditCard()
        {
            return new MasterCreditCard(_creditLimit, -_annualCharge);
        }
    }
}