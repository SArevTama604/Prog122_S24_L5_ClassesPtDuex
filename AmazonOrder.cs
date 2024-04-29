namespace Prog122_S24_L5_ClassesPtDuex
{
    internal class AmazonOrder
    {
        private string v1;
        private string v2;
        private decimal v3;

        public AmazonOrder(string v1, string v2, decimal v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public object Products { get; internal set; }
    }
}