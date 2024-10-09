for(int i=0; i<=10; i++){
    Console.WriteLine($"Increment:{i}");
}
Console.WriteLine("--------------------");
for(int j=10; j>=0; j--){
    Console.WriteLine($"Decrement:{j}");
}
Console.WriteLine("--------------------");
for (int a = 0; a < 10; a += 3)
{
    Console.WriteLine($"Add 3 :{a}");
}
Console.WriteLine("--------------------");
//Use the break keyword to break the iteration statement
for(int b=0; b < 10; b++){
    Console.WriteLine("ans of b is: "+b);
    if(b==7)break;
}
Console.WriteLine("--------------------");
//Loop through each element of an array
string[] names= {"Alex","Bob","John","David","Sara","Tina"};
for(int x=0; x<names.Length; x++){
    Console.WriteLine("Sequence wise : "+names[x]);
}
Console.WriteLine("********************");
for(int y=names.Length-1; y>=0; y--){
    Console.WriteLine("Reverse Sequence wise :"+names[y]);
}
Console.WriteLine("--------------------");
//Overcoming the limitation of the foreach statement using the for statement
string[] nameOfPersons = {"Umer","Tahir","Naufil","Jose","Maya",};
for(int z=0; z<nameOfPersons.Length; z++){
    if(nameOfPersons[z] == "Naufil"){
           nameOfPersons[z] = "Fouzia";
           Console.WriteLine("iteration of chang name: "+nameOfPersons[z]);
    }
    foreach(var name in nameOfPersons){
        Console.WriteLine(name);
    }
}

//implement the FizzBuzz challenge rules

    //Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    //When the current value is divisible by 3, print the term Fizz next to the number.
    //When the current value is divisible by 5, print the term Buzz next to the number.
    //When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

  for (int s = 1; s <= 100; s++)  // Start from 1, not 0
{
    // Check for FizzBuzz first
    if ((s % 3 == 0) && (s % 5 == 0))
    {
        Console.WriteLine($"{s} - FizzBuzz");
    }
    // Check if divisible by 3
    else if (s % 3 == 0)
    {
        Console.WriteLine(s + " Fizz");
    }
    // Check if divisible by 5
    else if (s % 5 == 0)
    {
        Console.WriteLine(s + " Buzz");
    }
    // Otherwise, just print the number
    else
    {
        Console.WriteLine(s);
    }
}

