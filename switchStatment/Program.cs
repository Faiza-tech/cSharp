using System.Diagnostics;

int employeeLevel = 200;
string employeeName = "John";
string title = "";

switch(employeeLevel){

    case 100:
    title = "Junior Associate";
    break;

    case 200:
    title = "Senior Associate";
    break;

    case 300:
    title = "Manager";
    break;

    case 400:
    title = "Senior Manager";
    break;

    default:
    title = "Associate";
    break;
};

Console.WriteLine($"{employeeName}: level is {employeeLevel}, and he is {title}");
