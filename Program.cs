 public class HaloGeneric
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Fadhli");
    }
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo User" + nama);
    }
}