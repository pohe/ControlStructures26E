using ControlStructures26E;

Console.WriteLine("Hello, World!");


//int age = 15;
//string message = "You are ";

//if (age < 18)
//{
//    message = message + "a child.";
//}
//else
//{
//    message = message + "an adult.";
//}

//Console.WriteLine(message);


//Console.Write("Indtast antal børn:");
//int noOfChildren = int.Parse(Console.ReadLine());
//int childSupport = 0;
//switch(noOfChildren)
//{
//    case 0:
//        childSupport = 0;
//        break;
//    case 1:
//        childSupport = 1200;
//        break;
//    case 2:
//        childSupport = 2000;
//        break;
//    case 3:
//        childSupport = 2600;
//        break;
//    default:
//        childSupport = 3000;
//        break;
//    }

//Console.WriteLine(childSupport);

//int score = 66;
//string mark = ""; 
//switch (score)
//{
//    case (< 40):
//        mark = "D";
//        break;
//    case (< 70):
//        mark = "C";
//        break;
//    case (< 90):
//        mark = "B";
//        break;
//    default:
//        mark = "A";
//        break;
//}


//int number = 1;
//while (number < 5)
//{
//    Console.WriteLine($"The value of the number is {number}");
//    number = number + 2;
//}




Console.WriteLine("Tallene fra 1 - 20");
int i = 1; //Initalisere en tællevariable
while( i <=20) //Condition def. stop betingelse
{
    Console.Write(i +  " ");
    i++; //i = i+1;
}
Console.WriteLine();
Console.WriteLine("Tallene fra 20 - 1");
int j = 20; 
while(1 <= j)
{
    Console.Write(j + " ");
    j--;//j = j-1
}
Console.WriteLine();
Console.WriteLine("Alle de lige tal" +
    " fra 1 - 20");

//int c = 1; 
//while( c<=20 )
//{
//    if (c%2 == 0)
//    {
//        Console.Write(c +  " ");
//    }
//    c++;
//}

int d = 2; 
while (d<=20)
{
    Console.WriteLine(d + " ");
    d = d + 2; //statement der ændre på variabler i betingelsen
    
}
Console.WriteLine("Følgende figur skal skrives ud");
Console.WriteLine("*****");
Console.WriteLine("*****");
Console.WriteLine("*****");
Console.WriteLine("*****");
Console.WriteLine("*****");
Console.WriteLine("Her er den: ");
int y = 0;
int x; 
while(y<5)
{
    x = 0;
    while (x<5)
    {
        Console.Write("*");
        x++;
    }
    Console.WriteLine();
    y++;
}


Student ann = new Student("Ann");

Student beth = new Student("Beth");
int avgScore = (ann.TestScore.HasValue && beth.TestScore.HasValue) ?
    (ann.TestScore.Value + beth.TestScore.Value) / 2 :
    0;  // ... or what? 

if (ann.TestScore.HasValue && beth.TestScore.HasValue)
{
    Console.WriteLine("Gennemsnit er :" + (ann.TestScore.Value + beth.TestScore.Value) / 2);
}
else
    Console.WriteLine("Gennemsnit er :"+ 0);