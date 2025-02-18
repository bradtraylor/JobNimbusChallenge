public class BracketCheckWorker
{

    public BracketCheckWorker()
    {
        
    }
    public static bool HasMatchingBrackets(string input)
    {

        if (input.Length == 0 || !input.Contains('<') || !input.Contains('>')) return false; //empty string and/or no brackets in input

        int bracketCount = 0;

        foreach (char c in input)
        {
            if (c == '<') bracketCount++;
            else if (c == '>') bracketCount--;

            if (bracketCount < 0) return false; 
        }
        return bracketCount == 0;
    }
}