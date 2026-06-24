class refVariable
{
    static void DoubleValue(ref int num_ber ) { 
    
        num_ber *= 3;
    }
    public static void Main( string[] args)
    {
        refVariable obj = new refVariable();
        int value = 18;
        Console.WriteLine("Before Passing the reference variable ,The value is " + value);
        DoubleValue(ref value);
        Console.WriteLine("Before Passing the reference variable ,The value is " + value);

    }
}