namespace university;

class TriangleTestingSolution

{
    // array to hold the sides of the triangle
    private static uint[] _sides = new uint[3];
    // variable for the sides of the triangle
    private static char _sideLetter = 'A';
    
    static void Main(string[] args)
    {
        Console.WriteLine("This program will ask you for the lengths of the sides of a triangle.");
        Console.WriteLine("It will then tell you if the triangle is equilateral, isosceles, or scalene.");
        Console.WriteLine("Please enter the lengths of the sides of the triangle after the prompt and press enter. \n");
        
        // Ask for the lengths of the sides of the triangle using the loop
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Please enter the length of side {_sideLetter}: ");
            // storing the input to the array
            _sides[i] = AskForInput();
            // incrementing the side variable to display the next side character
            _sideLetter++;
            // clearing the console after each input
            Console.Clear();
        }
        
        // calling the method to check the triangle
        CheckTriangle();
    }
    
    private static void CheckTriangle()
    {
        // checking if the triangle is valid
        if (_sides[0] + _sides[1] <= _sides[2] || 
            _sides[1] + _sides[2] <= _sides[0] || 
            _sides[0] + _sides[2] <= _sides[1])
        {
            Console.WriteLine("The triangle is not valid.");
            return;
        }
        // checking if the triangle is equilateral
        if (_sides[0] == _sides[1] && _sides[1] == _sides[2])
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        // checking if the triangle is isosceles
        else if (_sides[0] == _sides[1] || 
                 _sides[1] == _sides[2] || 
                 _sides[0] == _sides[2])
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        // checking if the triangle is scalene
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }
    
    // This method asks for input and returns the input as an integer.
    // Input should be a number between 1 and 100.
    // If the input is not a number or is not between 1 and 100,
    // the method will ask for input again.
    private static uint AskForInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit))
            {
                uint convertedInput = (uint)Convert.ToInt32(input);
                
                if (convertedInput is >= 1 and <= 100)
                    return convertedInput;
            }
            
            Console.Write("Range must be between 1 and 100. Please try again: ");
        }
    }
}