namespace Anonymous_Income_Comparison_Program
{
    internal class PayRateCalculator
    {
        private float _payrate = 0.00f;
        private float _withholdingRate = 0.00F;

        public float hours { get; set; }
        public float grossPay
        {
            get
            {
                return hours * _payrate;
            }
        }
        public float payrate
        {
            get
            {
                return _payrate;
            }
            set
            {
                _payrate = value;
            }
        }
        public string personOne{ get; set; }

        public PayRateCalculator(string personOne, float hours, float payRate)
        {
            this.hours = hours;
            this.payrate = payrate;
            this.personOne = personOne;
        }


        public PayRateCalculator()
        {

        }
    }
}