class Program
{
    static void Main(string[] args)
    {
        string input = @"r, wr, b, g, bwu, rb, gb, br

        brwrr
        bggr
        gbbr
        rrbgbr
        ubwu
        bwurrg
        brgr
        bbrgwb";

        var solver = new TowelSolver();
        int result = solver.Solve(input);
        Console.WriteLine($"Number of possible designs: {result}");
    }
}
