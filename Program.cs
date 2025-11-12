/*//"1--------------------------------------------------------------------"
int[] num = { 1, 2, 3, 6, 9, 2, 4, 7, 12 };
int max = num.Max();
int min = num.Min();
Console.WriteLine($"MAX: {max},MIN: {min}");*/

/*//"2--------------------------------------------------------------------"
int[] num = { 1, 2, 3, 4, 5, 6, 7 };
for (int i = 0; i < num.Length/2; i++)
{
    int x = num[i];
    num[i] = num[num.Length - i-1];
    num[num.Length - i-1] = x;
}
foreach (int x in num)
{
    Console.WriteLine(x);
}*/

/*//"3---------------------------------------------------------------------"
List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
List<int> cut=num.Where(x => x % 2 == 0).ToList();
foreach(int x in cut)
{
    Console.WriteLine(x);
}
*/

/*//"4------------------------------------------------------------------------"
bool IsWorkday(Weekday day)
{
    return (day >= Weekday.Mon && day <= Weekday.Fri);
}
Console.WriteLine(IsWorkday(Weekday.Mon));
Console.WriteLine(IsWorkday(Weekday.Sat));
enum Weekday
{
    Mon,
    Tue,
    Wed,
    Thu,
    Fri,
    Sat,
    Sun
}*/

/*//"5------------------------------------------------------------------------"
Point point=new Point(4,5);
Console.WriteLine(point.Length());
struct Point
{
    int X;
    int Y;
    public Point(int x,int y)
    {
      X = x;
        Y = y;
    }
    public double Length()
    {
        return Math.Sqrt(X*X + Y*Y);
    }
}*/

/*//"6---------------------------------------------------------------------------"
IGreeter greeter = new ConsoleGreeter();
Console.WriteLine(greeter.Greet("Ramzi"));
interface IGreeter
{
    string Greet(string name);
}
class ConsoleGreeter : IGreeter
{
    public string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}*/

/*//"7--------------------------------------------------------------------------------"
string[] x = { "A", "", "B" };
int n = 0;
bool nullTrue(string[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == "")
        {
            n++;
        }
    }
    return n > 0;
}
Console.WriteLine(nullTrue(x));*/

/*//"8--------------------------------------------------------------------------------"

var nums = new List<int> { 1, 2, 2, 3, 1 };
HashSet<int> unique = new HashSet<int>(nums);
List<int>newNum= new List<int>(unique);

Console.WriteLine(string.Join(", ", newNum));*/

/*//"9-----------------------------------------------------------------------------------"

List<int> Indexs(int[] numbers, int value)
{
    List<int> indexes = new List<int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == value)
            indexes.Add(i);
    }

    return indexes;
}
int[] num = { 1, 3, 1, 1, 5 };
var indeks = Indexs(num, 1);
Console.WriteLine(string.Join(",", indeks));*/

/*//"10----------------------------------------------------------------------------------"

string cumle = "salam ramzi muellim";
for(int i = 0; i < cumle.Length; i++)
{
    if (i == 0)
    {
        cumle = cumle.Substring(0, i) + char.ToUpper(cumle[i]) + cumle.Substring(i + 1).ToLower();
    }
    else if(cumle[i] == ' ')
    {
        i++;
        cumle = cumle.Substring(0, i) + char.ToUpper(cumle[i])+cumle.Substring(i+1).ToLower();  
    }
}
Console.WriteLine(cumle);*/

/*//"11--------------------------------------------------------------------------------------"

bool Advance(ref OrderStatus current, OrderAction action)
{
        switch (current)
        {
            case OrderStatus.Created:
                if (action == OrderAction.Pay)
                {
                    current = OrderStatus.Paid;
                    return true;
                }
                else if (action == OrderAction.Cancel)
                {
                    current = OrderStatus.Cancelled;
                    return true;
                }
                break;

            case OrderStatus.Paid:
                if (action == OrderAction.Ship)
                {
                    current = OrderStatus.Shipped;
                    return true;
                }
                else if (action == OrderAction.Cancel)
                {
                    current = OrderStatus.Cancelled;
                    return true;
                }
                break;

            case OrderStatus.Shipped:
                if (action == OrderAction.Deliver)
                {
                    current = OrderStatus.Delivered;
                    return true;
                }
                break;
        }
        return false;
}
OrderStatus status = OrderStatus.Created;

        Console.WriteLine(Advance(ref status, OrderAction.Pay));   
        Console.WriteLine(status);                                 

        Console.WriteLine(Advance(ref status, OrderAction.Ship));  
        Console.WriteLine(status);                                 

        Console.WriteLine(Advance(ref status, OrderAction.Pay));
        Console.WriteLine(status);                              
enum OrderStatus
{
    Created,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}

enum OrderAction
{
    Pay,
    Ship,
    Deliver,
    Cancel
}
*/

/*//"12-----------------------------------------------------------------------------------------"

Point2D p1 = new Point2D(1, 1);
Console.WriteLine($"baslangic: {p1}"); 
Point2D p2 = p1.Move(2, 3);
Console.WriteLine($"son: {p2}"); 

readonly struct Point2D
{
    public double X { get; }
    public double Y { get; }

    public Point2D(double x, double y)
    {

        X = x;
        Y = y;
    }

    public Point2D Move(double dx, double dy)
    {
        return new Point2D(X + dx, Y + dy);
    }
    public override string ToString() => $"({X}, {Y})";
}*/

/*//"13------------------------------------------------------------------------------"
List<IShape> shapes = new List<IShape>() { new Circle(4), new Circle(2.3), new Rectangle(6) };
double areaSum = 0;
double perimetrSum = 0;
foreach (IShape shape in shapes)
{
    areaSum += shape.Area();
    perimetrSum += shape.Perimetr();
}
Console.WriteLine(areaSum);
Console.WriteLine(perimetrSum);
interface IShape
{
    double Area();
    double Perimetr();
}
class Circle : IShape
{
    double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public double Area()
    {
        return 3.14 * radius * radius;
    }

    public double Perimetr()
    {
        return 2 * 3.14 * radius;
    }
}
class Rectangle : IShape
{
    double x;
    public Rectangle(double n)
    {
        x = n;
    }
    public double Area()
    {
        return x * x;
    }

    public double Perimetr()
    {
        return 4 * x;
    }
}*/

/*//"14----------------------------------------------------------------------------------"
enum OrderStatus
{
    Created,
    Paid,
    Shipped,
    Delivered,
    Cancelled
}

OrderStatus? ParseOrderStatus(string input)
{
    if (Enum.TryParse<OrderStatus>(input, ignoreCase: true, out var status))
    {
        return status;
    }
    return null;
}

var s1 = ParseOrderStatus("paid"); 
var s2 = ParseOrderStatus("foo");  
Console.WriteLine(s1);
Console.WriteLine(s2);*/
/*//"15----------------------------------------------------------------------------------"

List<Praduct> praducts = new List<Praduct>() { new Praduct("Nihad", 14000),new Praduct("Gulmirze",15000), new Praduct("Seyid", 1000) };
var max = praducts.Max(p=>p.Price);
foreach (var p in praducts)
{
    if(p.Price == max)
    {
        Console.WriteLine(p.Name);
    }
}

class Praduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Praduct(string name,double price)
    {
        Name = name;
        Price = price;        
    }
}*/

//"16-------------------------------------------------------------------------------------"

/*//"17-------------------------------------------------------------------------------------"
List<string> words = new List<string>
        {
            "apple", "banana", "Nihad", "apple", "Nihad", "Seyid", "Gulmirze"
        };

var result = words
    .Distinct()               
    .Where(x => x.Length >= 4)     
    .Where(x => x.StartsWith("A", StringComparison.OrdinalIgnoreCase)) 
    .OrderBy(x => x)                
    .Select(x => x.ToUpper())       
    .ToList();

result.ForEach(Console.WriteLine);*/

/*//"18-------------------------------------------------------------------------------------"

class Praduct
{
    public string Name { get; set; }
    public List<int> Grade { get; set; }
    public Praduct(string name,List<int>grade)
    {
        Name = name;
        Grade = grade;

    }
    public double Average()
    {
        int sum= 0;
        foreach (var item in Grade)
        {
            
            sum += item;
        }
        return sum /Grade.Count;
    }
}*/

/*//"19-------------------------------------------------------------------------------------"

List<Praduct> praducts = new List<Praduct>() { new Praduct("Nihad", 14000), new Praduct("Gulmirze", 15000), new Praduct("Seyid", 1000) };
string name=Console.ReadLine();
foreach (var p in praducts)
{
    if(p.Name == name)
    {
        Console.WriteLine($"{p.Name}: {p.Price}$ ");
    }
}

class Praduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Praduct(string name, double price)
    {
        Name = name;
        Price = price;
    }
}*/

/*//"20-------------------------------------------------------------------------------------"
string[] weekDays = { "Bazar ertesi", "Çerşenbe axsami", "Çerşenbe", "Cume axsami", "Cume", "Senbe", "Bazar" };

int[] temperatures = { 22, 25, 32, 28, 30, 27, 24 };

double averageTemp = temperatures.Average();

int maxTemp = temperatures.Max();
int minTemp = temperatures.Min();

int hottestDayIndex = Array.IndexOf(temperatures, maxTemp);
int coldestDayIndex = Array.IndexOf(temperatures, minTemp);
Console.WriteLine($"Heftelik orta temperatur: {averageTemp}");
Console.WriteLine($"En isti gun: {weekDays[hottestDayIndex]}, {maxTemp}");
Console.WriteLine($"En soyuq gun: {weekDays[coldestDayIndex]}, {minTemp}");
*/ 