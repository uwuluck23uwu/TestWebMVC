namespace P02_Depency.Models
{
    public class Test : ITest
    {
        public Data Data { get; set; }
        public Test() 
        {
            Data = new();
            GenrateData();
        }
        public Data GenrateData()
        {
            Data.Id = GetHashCode();
            Data.Message = "Test";
            return Data;
        }
    }
}
