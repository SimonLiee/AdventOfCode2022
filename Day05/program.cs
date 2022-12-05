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

// Calculate answer for both parts
Input inn = new Input(file);
Part1 p1 = new Part1(inn);
inn = new Input(file);
Part2 p2 = new Part2(inn);

// Print answer
Console.WriteLine($"Running with {file}");
Console.WriteLine($"Part1: {p1.answer}");
Console.WriteLine($"Part2: {p2.answer}");

return 0;