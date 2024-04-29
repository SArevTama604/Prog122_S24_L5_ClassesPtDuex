namespace Prog122_S24_L5_ClassesPtDuex
{
    internal class Product
    {
        private string v1;
        private string v2;
        private int v3;
        private decimal v4;

        public Product(string v1, string v2, int v3, decimal v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public object Title { get; internal set; }
    }
}