// See https://aka.ms/new-console-template for more information

Console.WriteLine("programming portfolio result calculator\n");
int digital_portfolio = 35;
int Open_Book_Programming_Exam = 7;
int Capstone_Project = 100;

Console.WriteLine("What was the digital portfolio mark? (out of 35)");
float randomnumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What was Open Book Programming Exam mark? (out of 7)");
float randomnumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What was the Capstone Project mark? (out of 100)");
float randomnumber3 = Convert.ToInt32(Console.ReadLine());

float calc1 = randomnumber1 * 100 / digital_portfolio;
float calc2 = randomnumber2 * 100 / Open_Book_Programming_Exam;
float calc3 = randomnumber3 * 100 / Capstone_Project;
float last_calc = (calc1 * 50 / 100) + (calc2 * 25 / 100) + (calc3 * 25 / 100);

last_calc = (float)Math.Round(last_calc, 2);

if ((randomnumber1 > digital_portfolio) || (randomnumber2 > Open_Book_Programming_Exam) || (randomnumber3 > Capstone_Project))
{
    Console.WriteLine("wrong input as the(se) given number(s) could not go beyond the set mark scheme\n");
}
else if ((randomnumber1 < 0) || (randomnumber2 < 0) || (randomnumber3 < 0))
{
    Console.WriteLine("negative number(s) is/are not (a) valid mark for this application\n");
}
else if (((randomnumber1 <= digital_portfolio) && (randomnumber2 <= Open_Book_Programming_Exam) && (randomnumber3 <= Capstone_Project)) && (last_calc >= 70))
{
    Console.WriteLine(" \nthe result is: " + last_calc + "%" + " - 1st grade\n");
}
else if (((randomnumber1 <= digital_portfolio) && (randomnumber2 <= Open_Book_Programming_Exam) && (randomnumber3 <= Capstone_Project)) && (last_calc >= 60 || last_calc == 70))
{
    Console.WriteLine(" \nthe result is: " + last_calc + "%" + "%" + " - 2:1 grade\n");
}
else if (((randomnumber1 <= digital_portfolio) && (randomnumber2 <= Open_Book_Programming_Exam) && (randomnumber3 <= Capstone_Project)) && (last_calc >= 50 || last_calc == 60))
{
    Console.WriteLine(" \nthe result is: " + last_calc + "%" + " - 2:2 grade\n");
}
else if (((randomnumber1 <= digital_portfolio) && (randomnumber2 <= Open_Book_Programming_Exam) && (randomnumber3 <= Capstone_Project)) && (last_calc >= 40 || last_calc == 50))
{
    Console.WriteLine(" \nthe result is: " + last_calc + "%" + " - 3rd grade\n");
}
else if
(((randomnumber1 <= digital_portfolio) && (randomnumber2 <= Open_Book_Programming_Exam) && (randomnumber3 <= Capstone_Project)) && (last_calc < 40 || calc2 < 40 || calc3 < 40))
{
    Console.WriteLine(" \nthe result is: " + last_calc + "%" + " - fail\n");
}

