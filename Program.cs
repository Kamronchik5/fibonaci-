Console.WriteLine("This code has two parts : ");
Console.WriteLine("1-fibonaci number :");
Console.WriteLine("2- a prime number :");
Console.WriteLine("Select need your parts please !");

string input = Console.ReadLine();

switch(input)
{
    case "1" :
    {
        Console.WriteLine("Input the n");
        string numbs = Console.ReadLine();
        int n = Convert.ToInt32(numbs);
        int [] numbers = new int[n]; 
        numbers[0]=0;
        numbers[1]=1;

          for(int i=2 ; i < n ; i++)
          {
            numbers[i]= numbers[i-1] + numbers[i-2];
          }
          foreach(int num in numbers)
          {
            Console.Write(num + "  ");
          }
    }
    break;

    case "2" :
    {
      Console.WriteLine("Input the n");
      string numbs = Console.ReadLine();
      int number = Convert.ToInt32(numbs);

        if (number == 2)
        {
            Console.WriteLine(number + " is a prime number ! ");
        }
        if(number >= 3)
        {
        for (int i = 3; i <= number * number; i += 2)
        {
            if (number % i == 0)
            {
                Console.WriteLine(number + " is not a prime number ! ");
            }
        } 
        }
    }
    break;
}
