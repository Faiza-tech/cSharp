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
while (value < 20){
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