
public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo User" + nama);
    }
}

﻿public class DataGeneric<T>
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
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Fadhli");

        DataGeneric<string> dataString = new DataGeneric<string>("103022330068");
        dataString.PrintData();
    }
}