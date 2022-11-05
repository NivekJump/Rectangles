using Rectangles;
using System.Drawing;

Beginning:
Console.WriteLine("");
Console.WriteLine("Welcome to the Rectangle Analyzer!");
Console.WriteLine("We are using the Rectangle primitive in .NET to check some awesome facts about rectangles.");
Console.WriteLine("So we are about to start, keep in mind you have to create two rectangles");
ExecuteRectangleAnalysingProcess();
Console.WriteLine("Do you want to execute the program again? Enter Y, For Exiting the program submit Enter with any other value");
string endProgram = Console.ReadLine();
if (endProgram.ToLower().Equals("y")) 
{
    goto Beginning;
}

void ExecuteRectangleAnalysingProcess()
{
    RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
    Console.WriteLine("We are going to create your first rectangle:");
    rectAnalyzer.FirstRectangle = CreateRectangle();
    Console.WriteLine("We are going to create your second rectangle:");
    rectAnalyzer.SecondRectangle = CreateRectangle();
    Console.WriteLine("We are calculating the results for your rectangles...");
    var isIntersecting = rectAnalyzer.CheckIntersection();
    var intersectingResponse = isIntersecting ? "Intersecting": "Not Intersecting";
    Console.WriteLine($"Your rectangles are: {intersectingResponse}");
    var isContainment = rectAnalyzer.CheckContainment();
    var containmentResponse = isContainment ? "Containment" : "Not Containment";
    Console.WriteLine($"Your rectangles are: {containmentResponse}");
    var adjacencyType = rectAnalyzer.GetAdjacency();
    Console.WriteLine($"Your rectangles are: {adjacencyType.ToString().Replace('_', ' ')}");
}

Rectangle CreateRectangle() 
{
    Console.WriteLine("Please introduce the X value of the upper-left corner");
    InputX:
    string xValueR1 = Console.ReadLine();
    var isXR1Valid = int.TryParse(xValueR1, out int xR1);
    if (!isXR1Valid)
        goto InputX;
    InputY:
    Console.WriteLine("Now please introduce the Y value of the upper-left corner");
    string yValueR1 = Console.ReadLine();
    var isYR1Valid = int.TryParse(yValueR1, out int yR1);
    if (!isYR1Valid)
        goto InputY;
    InputW:
    Console.WriteLine("Now please introduce the width of your rectangle");
    string widthValueR1 = Console.ReadLine();
    var isWR1Valid = int.TryParse(widthValueR1, out int wR1);
    if (!isWR1Valid)
        goto InputW;
    InputH:
    Console.WriteLine("Now please introduce the height of your rectangle");
    string heightValueR1 = Console.ReadLine();
    var isHR1Valid = int.TryParse(heightValueR1, out int hR1);
    if (!isHR1Valid)
        goto InputH;
    var rect = new Rectangle(xR1, yR1, wR1, hR1);
    return rect;
}