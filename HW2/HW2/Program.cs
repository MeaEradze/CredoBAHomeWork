#region Task1
//1) შექმენით კონსოლური აპლიკაცია, რომელიც შეასრულებს მარტივ არითმეტიკულ ოპერაციებს რიცხვებზე.
// გამოაცხადეთ ორი ცვლადი
// შეასრულეთ მიმატების, გამოკლების, გამრავლების, გაყოფისა და ნაშთის ოპერაციები.
// შედეგები დაბეჭდეთ კონსოლში

Console.WriteLine("---------------Task 1---------------");
Console.WriteLine();
int x = 5;
int y = 10;

int r1 = x + y;
int r2 = x - y;
int r3 = x * y;
int r4 = x / y;
int r5 = x % y;
Console.WriteLine($"Sum of {x} and {y} is: {r1}\nDifference is: {r2}\nProduct is: {r3}\nQuotient is: {r4}\nRemainder is: {r5}");
Console.WriteLine();
Console.WriteLine();

#endregion

#region Task2

// 2) წარმოაჩინეთ float, double და decimal შორის სიზუსტის სხვაობა:
//შექმენით სამი ცვლადი float, double და decimal ტიპებით. თითოეულს მიანიჭეთ მნიშვნელობად 1.0/7.0 ზე
//თითოეული ცვლადი გაამრავლეთ 7 ზე
//დაბეჭდეთ თითოეული შედეგი და შეადარეთ

Console.WriteLine("---------------Task 2---------------");
Console.WriteLine();

float f = 1.0f / 7.0f;
double d = 1.0 / 7.0;
decimal dec = 1.0m / 7.0m;
f = f * 7;
d = d * 7;
dec = dec * 7;
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);

Console.WriteLine("\nPrecision Comparison:");
Console.WriteLine($"Float precision: {f == 1.0f}");    
Console.WriteLine($"Double precision: {d == 1.0}");    
Console.WriteLine($"Decimal precision: {dec == 1.0m}");

Console.WriteLine();
Console.WriteLine();
#endregion

#region Task3

//3) გადაიყვანეთ სხვადასხვა მონაცემთა ტიპები განსხვავებულ ტიპებში
// გამოაცხადეთ int, double, float და decimal ტიპის ცვლადები
// მიანიჭეთ თითეულ მათგანს მნიშვნელობები
// შეასრულეთ explicit და implicit კონვერტაციებით ამ ტიპებს შორის (სადაც რომელია შესაძლებელი)
Console.WriteLine("---------------Task 3---------------");
Console.WriteLine();
int i = 5;
double d1 = 5.0;
float f1 = 4.0f;
decimal dec1 = 2.0m;

//Implicit convertations-არის კონვერტაციის ტიპი, რომელიც ხდება ავტომატურად, დამატებითი სინტაქსისის გარეშე,
//რადგან კონვერტაცია გარანტირებულად უსაფრთხოა(ანუ მონაცემები არ გვეკარგება)-ეს ხდება, როდესაც უფრო მცირე და ნაკლებად ზუსტ
//მონაცემის ტიპს ვდებთ უფრო დიდ და ზუსტ მონაცემში, მაგ. int ტიპის მონაცემი implicitely ჩაიდება float, double და decimal მონაცემებში,
//რადგან ის იგივე ზომის ან უფრო პატარაა და ზემოთ ცამოთვლილი მონაცემები უფრო ზუსტია, ანუ მონაცემები არ გვეკარგება.
Console.WriteLine($"Int = {5} implicit convertations");
Console.WriteLine($"Convert int to double: {d1 = i}");
Console.WriteLine($"Convert int to float: {f1 = i}");
Console.WriteLine($"Convert int to decimal: {dec1 = i}");
Console.WriteLine("----------");


//მნიშვნელობები გადაეწერე, მონაცემებს და თავიდან მივანიჭოთ
i = 5;
d1 = 5.0;
f1 = 4.3456f;
dec1 = 2.0m;
//float implicitely კონვერტირდება მხოლოდ double-ში, int-ისთვის int-ს ზომაა და უფრო ზუსტი, ამიტომ მონაცემებს დავკარგავთ, ხოლო 
Console.WriteLine($"Float = {f1} implicit convertations");
d1 = f1;
Console.WriteLine($"Convert float to double: {d1}");
Console.WriteLine("----------");


//Explicit convertations-როდესაც მონაცემები უფრო დი, დ data storage-ში ინახება და დამრგვალება გვიწევს(მონაცემთა დაკარგვა),
//რათა მონაცემები "ჩავატიოთ" უფრო მცირე data type-ში, ყიყევენთ დამატებით სინტაქსის დაქასთვას ან ფუნქციებს
i = 10;
float floatValue = (float)i;
double doubleValue = (double)i;
decimal decValue = (decimal)i;
Console.WriteLine($"Int = {i} explicit convertations");
Console.WriteLine($"Convert int to float: {floatValue}");
Console.WriteLine($"Convert int to double: {doubleValue}");
Console.WriteLine($"Convert int to decimal: {decValue}");
Console.WriteLine("----------");

floatValue = 3.14f;
int intValue = (int)floatValue;
doubleValue = (double)floatValue;
decValue = (decimal)floatValue;
Console.WriteLine($"Float = {floatValue} explicit convertations");
Console.WriteLine($"Convert float to int: {intValue}");
Console.WriteLine($"Convert float to double: {doubleValue}");
Console.WriteLine($"Convert float to decimal: {decValue}");
Console.WriteLine("----------");

doubleValue = 3.14;
Console.WriteLine($"Double = {doubleValue} explicit convertations");
Console.WriteLine($"Convert double to int: {intValue = (int)doubleValue}");
Console.WriteLine($"Convert double to float: {floatValue = (float)doubleValue}");
Console.WriteLine($"Convert double to decimal: {decValue = (decimal)doubleValue}");
Console.WriteLine("----------");

decValue = 3.14m;
Console.WriteLine($"Decimal = {decValue} explicit convertations");
Console.WriteLine($"Convert decimal to int: {intValue = (int)decValue}");
Console.WriteLine($"Convert decimal to float: {floatValue = (float)decValue}");
Console.WriteLine($"Convert decimal to double: {doubleValue = (double)decValue}");
Console.WriteLine("----------");

//Convert to int function
doubleValue = 3.14;
floatValue = 2.1234f;
decValue = 1.1234m;
intValue = Convert.ToInt32(doubleValue);
Console.WriteLine($"Convert to int functions: ");
Console.WriteLine($"Convert double to int: {intValue}");
Console.WriteLine($"Convert flost to int: {intValue = Convert.ToInt32(floatValue)}");
Console.WriteLine($"Convert decimal to int: {intValue = Convert.ToInt32(decValue)}");
Console.WriteLine("----------");

//Convert to double functions
intValue = 10;
doubleValue = Convert.ToDouble(intValue);
Console.WriteLine($"Convert to double functions: ");
Console.WriteLine($"Convert int to double: {doubleValue}");
Console.WriteLine($"Convert float to double: {doubleValue = Convert.ToDouble(floatValue)}");
Console.WriteLine($"Convert decimal to double: {doubleValue = Convert.ToDouble(decValue)}");
//კიდევ ბევრი ფუნქციაა(მეტი კონვერტაცია აღარ შემიძლია)
//Convert.ToDecimal
//Convert.ToInt16
//Convert.ToInt64
//Convert.ToUInt32
//Convert.ToSingle
Console.WriteLine("----------");

//რომ დავწერე მერე გამახსენდა, რომ სტრინგის გადაყვანა არ მოგითხოვიათ, მაგრამ დავტოვე მაინც, რადგან დავწერე :)
Console.WriteLine($"Testing int.TryParse function: ");
string[] stringValues = new string[] { "1234", "12.4", "123bla", "bla1234" };
int result;
for (int j = 0; j < stringValues.Length; j++)
{
    bool success = int.TryParse(stringValues[j], out result);
    Console.WriteLine($"{j+1}) {stringValues[j]}");
    if (success)
    {
        Console.WriteLine("Parsed integer: " + result);
    }
    else
    {
        Console.WriteLine("Invalid number");
    }

}

Console.WriteLine();
Console.WriteLine();

#endregion

#region Task4
//4) შექმენით კონსოლური აპლიკაცია, როკმელიც ორ ცვლადს მნიშვნელობას გაუცვლის.
//მაგ.:
//before:
//int x = 5;
//int b = 10;

//after:
//int x = 10;
//int b - 5;

Console.WriteLine("---------------Task 4---------------");
Console.WriteLine();
int a = 5;
int b = 10;
Console.WriteLine($"before - a = {a} and b = {b}");
//with new variable 
//int c = a;
//a = b;
//b = c;
//without new variable
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"after - a = {a} and b = {b}");

Console.WriteLine();
Console.WriteLine();

#endregion

#region Task5

//5) შექმენით კონსოლური აპლიკაცია, რომელიც დაითვლის BMI (Body Mass Index) მნიშვნელობას და ამის შესაბამისად
//დაბეჭდავს რჩევებს.
//* შემოატანინეთ მომხმარებელს კონსოლიდან ინფორმაცია - სიმაღლე და წონა (https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/)
//*დაითვალეთ BMI https://en.wikipedia.org/wiki/Body_mass_index
//*მიღებული შედეგების მიხედვით დაბეჭდეთ სხვადასხვა რჩევები


Console.WriteLine("---------------Task 5---------------");
Console.WriteLine();
Console.Write("Please insert weight in double, use kg-s: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Please insert height in double, use meters: ");
double height = Convert.ToDouble(Console.ReadLine());

double bmiResult = weight / Math.Pow(height, 2);
Console.WriteLine($"Your BMI is : {bmiResult}");

if(bmiResult < 16.0)
    Console.WriteLine("Category: Underweight (Severe thinness)");
else if(bmiResult >= 16 && bmiResult <= 16.9)
    Console.WriteLine("Category: Underweight (Moderate thinness)");
else if (bmiResult >= 17 && bmiResult <= 18.4)
    Console.WriteLine("Category: Underweight (Mild thinness)");
else if (bmiResult >= 18.5 && bmiResult <= 24.9)
    Console.WriteLine("Category: Normal range");
else if (bmiResult >= 25 && bmiResult <= 29.9)
    Console.WriteLine("Category: Overweight (Pre-obese)");
else if (bmiResult >= 30 && bmiResult <= 34.9)
    Console.WriteLine("Category: Obese (Class I)");
else if (bmiResult >= 35 && bmiResult <= 39.9)
    Console.WriteLine("Category: Obese (Class II)");
else if (bmiResult >= 40)
    Console.WriteLine("Category: Obese (Class III)");
else
    Console.WriteLine("Program does not have your category");

Console.WriteLine();
Console.WriteLine();
Console.ReadKey();
#endregion
