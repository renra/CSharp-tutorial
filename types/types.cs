using System;

class Program
{
  public static void Main()
  {
    long mem_usage_begin = GC.GetTotalMemory(false);
    long mem_usage_end = 0;
    Console.WriteLine("Total memory as seen by GC: {0}", mem_usage_begin);
    Separate();

    BoolDemo();

    SByteDemo();
    ByteDemo();

    UIntDemo();
    IntDemo();
    LongDemo();
    ULongDemo();

    DoubleDemo();
    DecimalDemo();

    CharDemo();
    StringDemo();
    
    mem_usage_end = GC.GetTotalMemory(false);
    Console.WriteLine("Total memory afterwards as seen by GC: {0}", mem_usage_end);
    Console.WriteLine("Memory usage: {0}", mem_usage_end - mem_usage_begin);
  }


  /* Helper methods  */
  static void CharDemo()
  {
    Marker("CHAR DEMO");

    char letter = 'a';
    Console.WriteLine("The type is {0}", letter.GetType());
    Console.WriteLine("The type code is {0}", letter.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", char.MinValue); //strange output
    Console.WriteLine("The max is {0}. Watch out for that.", char.MaxValue); //strange output

    Console.WriteLine("The letter is {0}.", letter);
    Console.WriteLine("The letter is {0}.", (char)(letter+1));

    Separate();
  }

  static void StringDemo()
  {
    Marker("STIRNG DEMO");

    string sentence = "Leave as you came in the manner of light, live in the name of the one who has sight";
    Console.WriteLine("The type is {0}", sentence.GetType());
    Console.WriteLine("The type code is {0}", sentence.GetTypeCode());

    Console.WriteLine(sentence);
    Console.WriteLine("The sentence is : {0}", sentence);
    Console.WriteLine("The tenth character is : {0}", sentence[9]);
    Console.WriteLine("String length : {0}", sentence.Length);

    Separate();
  }

  static void SByteDemo()
  {
    Marker("SByte DEMO");

    sbyte number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", sbyte.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", sbyte.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(sbyte));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  static void ByteDemo()
  {
    Marker("Byte DEMO");

    byte number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", byte.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", byte.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(byte));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  static void UIntDemo()
  {
    Marker("UINT DEMO");

    uint number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", uint.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", uint.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(uint));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  //I really miss a dynamic language here. So much repetition
  static void IntDemo()
  {
    Marker("INT DEMO");

    int number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", int.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", int.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(int));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  static void LongDemo()
  {
    Marker("Long DEMO");

    long number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", long.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", long.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(long));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  static void ULongDemo()
  {
    Marker("ULong DEMO");

    ulong number = 12;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", ulong.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", ulong.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(ulong));

    Console.WriteLine("And today's number is the number {0}", number);

    Separate();
  }

  static void DoubleDemo()
  {
    Marker("DOUBLE DEMO");

    double number = 0.1;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", double.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", double.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(double));
    Console.WriteLine("With a katana you can cut things in {0}", number);

    Separate();
  }

  static void DecimalDemo()
  {
    Marker("DECIMAL DEMO");

    decimal number = 12.556m;
    Console.WriteLine("The type is {0}", number.GetType());
    Console.WriteLine("The type code is {0}", number.GetTypeCode());
    Console.WriteLine("The min is {0}. Watch out for that.", decimal.MinValue);
    Console.WriteLine("The max is {0}. Watch out for that.", decimal.MaxValue);
    Console.WriteLine("The size is {0} byte(s).", sizeof(decimal));
    Console.WriteLine("Decimal has greater precision than double but cannot store such big numbers : {0}", number);

    Separate();
  }

  static void BoolDemo()
  {
    Marker("BOOL DEMO");

    bool flag = true;
    Console.WriteLine("The type is {0}", flag.GetType());
    Console.WriteLine("The type code is {0}", flag.GetTypeCode());
    Console.WriteLine("The size is {0} byte(s).", sizeof(bool));
    BoolOutput(flag);

    flag = false;
    BoolOutput(flag);

    Separate();
  }

  static void BoolOutput(bool flag)
  {
    Console.WriteLine("The flag is {0}", flag);
  }

  static void Marker(string marker)
  {
    Console.WriteLine(marker);
  }

  static void Separate()
  {
    Console.WriteLine("*****************");
    Console.WriteLine();
  }
}
