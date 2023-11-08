Console.WriteLine("Diga um  numero maior que 5");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5 )
{
    Console.WriteLine("Sucesso");

} else {
    Console.WriteLine(num + " não é maior que 5");
        }

int[] numbers = new int[num];

for  (int i = 0; i < num; i++)
{
    Console.WriteLine(i);
    numbers[i] = i;
}

foreach (int n in numbers)
{
    Console.WriteLine(n);
}

switch (num)
{
    case 5: Console.WriteLine("5");
        break;
        case 6: Console.WriteLine("6"); 
        break;
        case 7: Console.WriteLine("7"); 
        break; 
        case 8: Console.WriteLine("8");
        break;     
        case 9: Console.WriteLine("9");
            break;
        default: Console.WriteLine("Too big to count");
        break;

}


DateTime dt = DateTime.Now;
Console.WriteLine(dt);
String time = dt.ToString("yyyyMMdd");
Console.WriteLine(time);
int tim = Int32.Parse(time);
Console.WriteLine(tim);
