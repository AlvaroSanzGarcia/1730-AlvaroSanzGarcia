namespace ex3c_product_maintenance
{
    public class Software : Product
    {
        public string Version { get; set; } = "";

        public Software(string? code, string? description, decimal price, string version) 
            : base(code, description, price) => 
            
            Version = version;

        public override string ToString() => 
            
            $"{base.ToString()}, Version {Version}";

    }
}
