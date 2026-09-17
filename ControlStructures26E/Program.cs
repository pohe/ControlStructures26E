Console.WriteLine("Hello, World!");

Console.Write("Indtast antal børn:");
int noOfChildren = int.Parse(Console.ReadLine());
int childSupport = 0;
switch(noOfChildren)
{
    case 0:
        childSupport = 0;
        break;
    case 1:
        childSupport = 1200;
        break;
    case 2:
        childSupport = 2000;
        break;
    case 3:
        childSupport = 2600;
        break;
    default:
        childSupport = 3000;
        break;
    }

Console.WriteLine(childSupport);

int score = 66;
string mark = ""; 
switch (score)
{
    case (< 40):
        mark = "D";
        break;
    case (< 70):
        mark = "C";
        break;
    case (< 90):
        mark = "B";
        break;
    default:
        mark = "A";
        break;
}


int number = 1;
while (number < 5)
{
    Console.WriteLine($"The value of the number is {number}");
    number = number + 2;
}
