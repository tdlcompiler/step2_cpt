namespace SOLID_2
{
    public class Discount
    {
        public virtual decimal Calculate(decimal amount)
        {
            return amount;
        }
    }

    public class PercentageDiscount : Discount
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override decimal Calculate(decimal amount)
        {
            return amount - (amount * _percentage / 100);
        }
    }

    public class FixedAmountDiscount : Discount
    {
        private readonly decimal _discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public override decimal Calculate(decimal amount)
        {
            return amount - _discountAmount;
        }
    }

    class Program
    {
        static void Main()
        {
            Discount percentageDiscount = new PercentageDiscount(10);
            Discount fixedDiscount = new FixedAmountDiscount(52);

            decimal price = 500;
            Console.WriteLine($"Со скидкой 10%: {percentageDiscount.Calculate(price)}.");
            Console.WriteLine($"Со скидкой 52 деревянных: {fixedDiscount.Calculate(price)}.");
        }
    }
}