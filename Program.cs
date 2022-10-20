//Elizar Garcia
//10-19-22 2pm
//Mini challenge #6 "Odd or Even"
//This prject will prompt the user to enter numbers and the console will return if the numbers are even or odd.



Console.Clear();

bool again = true;
string againAnswer;
int validNumber;

while(again == true)
{
    int number, remainder;

    Console.WriteLine("Enter a number please.");

    string userInput = Console.ReadLine();

    bool isNumber = Int32.TryParse(userInput, out validNumber);
    if(isNumber)
    {
        number = Convert.ToInt32(userInput);

        remainder = validNumber % 2;

        if (remainder == 0)
        {
            Console.WriteLine(validNumber + " is even ");
        
        }else{
            Console.WriteLine(validNumber + " is odd ");

        }

    }else{
        Console.WriteLine("I\nD\nO\nN\nT\nL\nI\nK\nE\nY\nO\nU");

    }
    Console.WriteLine("Do you have anymore numbers for me? Type YES or NO.");

    againAnswer = Console.ReadLine().ToUpper();
    
    if(againAnswer == "YES")
    {
        again = true;
    }else{
        again = false;
    }
}