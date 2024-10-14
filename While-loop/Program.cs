//Add looping logic to your code using the do-while and while statements in C#

////Write a do-while statement to break when a certain random number is generated

//////write code that will keep generating random numbers between 1 and 10 until we generate the number 7. It could take just one iteration to get a 7, or it could take dozens of iterations.

/*Random number = new Random();
int current = 0;
do{
    current= number.Next(1,11); // Generates a random number between 1 and 10
    Console.WriteLine($"This is current number: {current}");
}while(current != 7);// The loop continues until we generate the number 7
*/


Random number = new Random();
int current = number.Next(1, 11); // Generates a random number between 1 and 10

while (current >= 3)  // Loop runs while the number is 3 or greater
{
    Console.WriteLine(current);  // Prints the number
    current = number.Next(1, 11);  // Generate a new random number for the next iteration
}

Console.WriteLine($"Last number: {current}");  // When current < 3, it exits the loop and prints the last number


//Write a while loop that prints the numbers from 1 to 20.

///Hint: Use a loop counter and increment it until it reaches 20.
int value = 1;
while (value < 20)
{
    Console.WriteLine(value);
    value++;
}

// Number Guessing Game with a do-while Loop
/////Write a number guessing game that generates a random number between 1 and 10 and keeps asking the user to guess the number until they guess it correctly using a do-while loop.

///Hint: You will need to generate a random number and compare it with the user's input inside the do-while loop.

//////////////////////

// Sum of Even Numbers with a do-while Loop
///Write a program that uses a do-while loop to calculate the sum of even numbers between 1 and 50.

//Hint: Use a condition inside the loop to check if a number is even (number % 2 == 0).

//////////////////////

/*Reverse Countdown with a while Loop
Write a program that counts down from 10 to 1 and then prints "Liftoff!" at the end using a while loop.

Hint: Decrement the loop counter in each iteration.*/


//////////////////////

/*
 Sum of Numbers with a while Loop
Write a program that calculates the sum of numbers from 1 to 100 using a while loop.

Hint: Start with sum = 0 and use a loop counter that adds numbers to the sum until it reaches 100.*/

/////////////////

/*
 Collecting User Input Until "exit"
Write a program that keeps asking the user to enter a word and only stops when they type "exit" using a do-while loop.

Hint: You will need to check the user's input in each iteration and compare it with the string "exit".

*/




//Use the continue statement to step directly to the Boolean expression
Random random = new Random();
int currentVal;

do
{
    currentVal = random.Next(1, 11);  // Update currentVal inside the loop

    if (currentVal >= 8)
    {
        continue;  // Skip printing if currentVal is 8 or higher
    }

    Console.WriteLine($"val of continue: {currentVal}");  // This line only runs if currentVal < 8

} while (currentVal != 7);  // Loop until we get 7


Console.WriteLine("************");

//Code challenge - write code to implement the game rules
/*
    .You must use either the do-while statement or the while statement as an outer game loop.
    .The hero and the monster start with 10 health points.
    .All attacks are a value between 1 and 10.
    .The hero attacks first.
    .Print the amount of health the monster lost and their remaining health.
    .If the monster's health is greater than 0, it can attack the hero.
    .Print the amount of health the hero lost and their remaining health.
    .Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    .Print the winner.
*/

Random attacks = new Random();
int valHero = 10;
int valMonster = 10;

do
{
    int valueofDice = attacks.Next(1, 11);
    valMonster -= valueofDice;
    Console.WriteLine($"Monster was damaged and lost {valueofDice} health and now has {valMonster} health.");
    if (valMonster <= 0) continue;
    valueofDice = attacks.Next(1, 11);
    valHero -= valueofDice;

    Console.WriteLine($"Hero was damaged and lost {valueofDice} health and now has {valHero} health.");

} while (valHero > 0 && valMonster > 0);
Console.WriteLine(valHero > valMonster ? "Hero Win" : "Monster Win");

Console.WriteLine("------------------");
//Manage user input

/*
string? readResult;
Console.WriteLine("Enter a string:");
do{
    readResult = Console.ReadLine();
}while(readResult == null); // no check for output
*/
// or
string? readResult;
Console.WriteLine("Enter a string:");

do
{
    readResult = Console.ReadLine();
} while (string.IsNullOrEmpty(readResult));  // Check for both null and empty string

Console.WriteLine("You entered: " + readResult);

Console.WriteLine("------------------");
Console.WriteLine("------------------");

string? readLine;
bool ValidEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readLine = Console.ReadLine();
    if (readLine != null)
    {
        if (readLine.Length >= 3)
        {
            ValidEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (ValidEntry == false);

Console.WriteLine("------------------");
Console.WriteLine("------------------");
//convert the string value to a numeric type.
//write code that validates integer input

int userValue;
bool inputIsValid = false;

Console.WriteLine("Please enter an integer value between 5 and 10:");

do
{
    // Get the input from the user
    string? userInput = Console.ReadLine();

    // Try to parse the input to an integer
    if (int.TryParse(userInput, out userValue))
    {
        // Check if the parsed value is between 5 and 10
        if (userValue >= 5 && userValue <= 10)
        {
            inputIsValid = true; // Input is valid, exit the loop
        }
        else
        {
            // Input is out of range
            Console.WriteLine("The number must be between 5 and 10. Please try again.");
        }
    }
    else
    {
        // Parsing failed, invalid input
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

} while (!inputIsValid); // Continue the loop until valid input is provided

// After exiting the loop, confirm that input is valid
Console.WriteLine($"Your input value of {userValue} has been accepted.");


Console.WriteLine("------------------");
Console.WriteLine("------------------");
//write code that validates string input
bool sentence = false;
string? InputFromUser;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
   InputFromUser = Console.ReadLine().Trim().ToLower();
    if (InputFromUser == "administrator" || InputFromUser == "manager" || InputFromUser == "user")
    {
        sentence = true;
    }else{
       sentence=false;
       Console.WriteLine($"The role name that you entered, {InputFromUser} is not valid. Enter your role name (Administrator, Manager, or User)");
    }
    

} while(sentence == false);
Console.WriteLine($"Your input value {InputFromUser} has been accepted.");


Console.WriteLine("------------------");
Console.WriteLine("------------------");
//Write code that processes the contents of a string array

/*string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    string mystring = myStrings[i];
    int periodLocation = mystring.IndexOf(".");  // Find the first period location


    // Process the string and remove periods
    while (periodLocation != -1)
    {
        // Remove the period at the found location
        mystring = mystring.Remove( periodLocation , 1);
        Console.WriteLine("New string is: " + mystring);

        // Find the next period, if any
        periodLocation = mystring.IndexOf(".");
    }
}
*/


   
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// Outer loop using 'for' to process each string in the array
for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i]; // Get the current string
    int periodLocation = myString.IndexOf("."); // Find the first period location

    // Inner loop to process and extract sentences from the string
    while (periodLocation != -1)
    {
        // Extract the sentence from the beginning of the string up to the period
        string word = myString.Substring(0, periodLocation);

        // Display the extracted sentence after trimming leading spaces
        Console.WriteLine("Sentence: " + word.TrimStart());

        // Remove the processed sentence and the period
        myString = myString.Remove(0, periodLocation + 1);

        // Find the next period in the remaining part of the string
        periodLocation = myString.IndexOf(".");
    }
    // After the inner loop, handle the remaining part of the string (if any)
    if (!string.IsNullOrWhiteSpace(myString))
    {
        Console.WriteLine("Sentence: " + myString.TrimStart());
    }
     }


