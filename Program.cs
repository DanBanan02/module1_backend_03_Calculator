
// 1. Plus function
// 2. Minus function
// 3. Multiplie function
// 4. Divide function
// 5. Precentage function
// 6. Sum function
// 7. Reset function
// 8. Write Calculation function ( Sample: 1+1= (Gives Sum to user.))
// 9. Button function or Write down calculation to get the (Answer)
// 10. Excalidraw Planer
// 11. ReadMe.DM file
// 12. While answer is false. (Msg: Need a math problem.)
// 13. Figure out a layout.
// 14. Figure out if you can make mouse click function. [ Clickable. ] = this function happens.
// 15. make the code compact and not to complicated.
// 16. this calculator will only be a basic calculator with basic functions.
// 17. Make sure to read the Asignment multiple time to make sure you added all the things writen in the asignment.
// 18. ???

class Calcus
{
    public void ShowCalcus(string sum)
    {
        Console.WriteLine("_______________");
        Console.WriteLine(sum);
        Console.WriteLine("===============");        
    }

    public void ShowMathResult()
    {
        Console.WriteLine("Enter Math problem:");
        string userMath = Console.ReadLine();
        Console.WriteLine(userMath);
    }

}