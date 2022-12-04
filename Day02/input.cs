// Defaults to non-test input
string file = "./input.txt";;
if (args.Length == 1) 
{   
    // If the first arge is higher than zero, run test
    if(Int32.Parse(args[0]) > 0){
        file = "./testInput.txt";
    }
} else if(args.Length > 1) { // If more than one argument
    System.Console.WriteLine("Too many arguments.");
    return 1;
}

// Read all files to array
string[] lines = System.IO.File.ReadAllLines(file);

// Calculate answer for both parts
Part2 p2 = new Part2(lines);
Part1 p1 = new Part1(lines);

// Print answer
Console.WriteLine($"Running with {file}");
Console.WriteLine($"Part1: {p1.answer}");
Console.WriteLine($"Part2: {p2.answer}");

return 0;