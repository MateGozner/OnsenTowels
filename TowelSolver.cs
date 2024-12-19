
public class TowelSolver
{
    private HashSet<string> patterns;
    private Dictionary<string, bool> memo;

    public int Solve(string input)
    {

        // Input validation
        if (string.IsNullOrEmpty(input))
            return 0;

        string[] parts = input.Split(new[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

        // Validate input format
        if (parts.Length < 2)
            throw new ArgumentException("Invalid input format. Expected patterns and designs separated by empty line.");

        patterns = parts[0].Split(new[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(p => p.Trim())
                          .Where(p => !string.IsNullOrEmpty(p))
                          .ToHashSet();
        string[] designs = parts[1].Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(d => d.Trim())
                                  .Where(d => !string.IsNullOrEmpty(d))
                                  .ToArray();

        int possibleCount = 0;
        foreach (var design in designs)
        {
            memo = new Dictionary<string, bool>();
            if (CanCreate(design))
            {
                possibleCount++;
            }
        }
        return possibleCount;
    }

    private bool CanCreate(string design)
    {
        // Base case: empty string is always possible
        if (string.IsNullOrEmpty(design))
            return true;

        // Check memoization
        if (memo.ContainsKey(design))
            return memo[design];
        // Try each pattern at the start of remaining design
        foreach (var pattern in patterns)
        {
            if (design.StartsWith(pattern))
            {
                string remaining = design[pattern.Length..];
                if (CanCreate(remaining))
                {
                    memo[design] = true;
                    return true;
                }
            }
        }

        memo[design] = false;
        return false;
    }
}