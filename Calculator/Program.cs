namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      menu();
    } 
    static void otherOperation()
    {
      Console.WriteLine("Do you want do operation ?");
      Console.WriteLine("1 - Yes");
      Console.WriteLine("2 - No");
      short res = short.Parse(Console.ReadLine());
      if(res == 1){
        menu();
      }else{
        System.Environment.Exit(0);
      }
    }
    static void menu()
    {
      Console.WriteLine("Please, enter the number wanted :");
      Console.WriteLine("1 - Sum");
      Console.WriteLine("2 - Subtraction");
      Console.WriteLine("3 - Multiplication");
      Console.WriteLine("4 - Division");
      Console.WriteLine("5 - Exit");
      short option = short.Parse(Console.ReadLine());

      switch(option){
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
          sum();
          otherOperation();
          break;
        case 2:
          subtraction();
          otherOperation();
          break;
        case 3:
          multiplication();
          otherOperation();
          break;
        case 4:
          division();
          otherOperation();
          break;
        default:
          menu();
          break;
      }
      
    }
    static void sum()
    {
      Console.Clear();
      Console.WriteLine("First value :");
      float numberOne = float.Parse(Console.ReadLine());
      Console.WriteLine("Second value :");
      float numberTwo = float.Parse(Console.ReadLine());
      float result = numberOne + numberTwo;
      Console.ReadKey();
    }
    static void subtraction()
    {
      Console.Clear();
      Console.WriteLine("First value :");
      float numberOne = float.Parse(Console.ReadLine());
      Console.WriteLine("Second value :");
      float numberTwo = float.Parse(Console.ReadLine());
      float result = numberOne - numberTwo;
      Console.WriteLine("The subtraction result is " + result);
      Console.ReadKey();
    }

    static void multiplication()
    {
      Console.Clear();
      Console.WriteLine("First value :");
      float numberOne = float.Parse(Console.ReadLine());
      Console.WriteLine("Second value :");
      float numberTwo = float.Parse(Console.ReadLine());
      float result = numberOne * numberTwo;
      Console.WriteLine("The multiplication result is " + result);
      Console.ReadKey();
    }

    static void division()
    {
      Console.Clear();
      Console.WriteLine("First value :");
      float numberOne = float.Parse(Console.ReadLine());
      Console.WriteLine("Second value :");
      float numberTwo = float.Parse(Console.ReadLine());
      float result = numberOne / numberTwo;
      Console.WriteLine("The division result is " + result);
      Console.ReadKey();
    }
  }
}