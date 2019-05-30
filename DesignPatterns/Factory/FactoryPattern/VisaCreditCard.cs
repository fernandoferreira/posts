namespace FactoryPattern
{
    class VisaCreditCard : Creditard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge { get; set; }

        public VisaCreditCard(int creditLimit, int AnnualCharge)
        {
            _cardType = "Visa";
            _creditLimit = creditLimit;
            _annualCharge = AnnualCharge;
        }

        public override string CardType { get => _cardType; }
        public override int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }
    }
}