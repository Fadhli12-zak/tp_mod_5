public class DataGeneric<T>
{
   private T data;
   
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }

}
public class Generic
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataString = new DataGeneric<string>("103022330068");
        dataString.PrintData();
    }
}