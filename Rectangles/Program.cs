using Rectangles;
using System.Drawing;
//Pointer to restart the Program
Beginning:
//Start the Program
Console.WriteLine("Welcome to the Rectangle Analyzer!");
Console.WriteLine("We are using the Rectangle primitive in .NET to check some awesome facts about rectangles.");
Console.WriteLine("So we are about to start, keep in mind you have to create two rectangles");
//Execute Rectangle AnalysingProcess Function
ExecuteRectangleAnalysingProcess();
//Verification for doing multiple rectangles or exit the program
Console.WriteLine("Do you want to execute the program again? Enter Y, For Exiting the program submit Enter with any other value");
string endProgram = Console.ReadLine();
if (endProgram.ToLower().Equals("y")) 
{
    //Go back to the Beggining Pointer
    goto Beginning;
}

void ExecuteRectangleAnalysingProcess()
{
    //Create RectangleAnalyzer object, which is the main class for this exercise
    RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
    Console.WriteLine("We are going to create your first rectangle:");
    //Create first Rectangle
    rectAnalyzer.FirstRectangle = CreateRectangle();
    Console.WriteLine("We are going to create your second rectangle:");
    //Create second Rectangle
    rectAnalyzer.SecondRectangle = CreateRectangle();
    Console.WriteLine("We are calculating the results for your rectangles...");
    //Checking if the rectangles are intersecing
    var isIntersecting = rectAnalyzer.CheckIntersection();
    //Ternary operator to map the response
    var intersectingResponse = isIntersecting ? "Intersecting": "Not Intersecting";
    Console.WriteLine($"Your rectangles are: {intersectingResponse}");
    //Check if the rectangles are contained
    var isContainment = rectAnalyzer.CheckContainment();
    //Ternary operator to map the response
    var containmentResponse = isContainment ? "Containment" : "Not Containment";
    Console.WriteLine($"Your rectangles are: {containmentResponse}");
    //Get the type of adjacency that the Rectangles might have
    var adjacencyType = rectAnalyzer.GetAdjacency();
    Console.WriteLine($"Your rectangles are: {adjacencyType.ToString().Replace('_', ' ')}");
}

Rectangle CreateRectangle() 
{
    //Pointer to input again the X value
    //Instruction to input the left corner X value
    InputX:
    Console.WriteLine("Please introduce the X value of the upper-left corner");
    string xValueR1 = Console.ReadLine();
    var isXR1Valid = int.TryParse(xValueR1, out int xR1);
    if (!isXR1Valid)
        //If is not valid we should go back to the pointer for X
        goto InputX;
    //Pointer to input again the Y value
    //Instruction to input the left corner Y value
    InputY:
    Console.WriteLine("Now please introduce the Y value of the upper-left corner");
    string yValueR1 = Console.ReadLine();
    var isYR1Valid = int.TryParse(yValueR1, out int yR1);
    if (!isYR1Valid)
        //If is not valid we should go back to the pointer for Y
        goto InputY;
    //Pointer to input again the Width value
    //Instruction to input the Width of the Rectangle
    InputW:
    Console.WriteLine("Now please introduce the width of your rectangle");
    string widthValueR1 = Console.ReadLine();
    var isWR1Valid = int.TryParse(widthValueR1, out int wR1);
    if (!isWR1Valid)
        //If is not valid we should go back to the pointer for Width
        goto InputW;
    //Pointer to input again the Height value
    //Instruction to input the Height of the Rectangle
    InputH:
    Console.WriteLine("Now please introduce the height of your rectangle");
    string heightValueR1 = Console.ReadLine();
    var isHR1Valid = int.TryParse(heightValueR1, out int hR1);
    if (!isHR1Valid)
        //If is not valid we should go back to the pointer for Height
        goto InputH;
    //Return the new Rectangle
    return new Rectangle(xR1, yR1, wR1, hR1);
}