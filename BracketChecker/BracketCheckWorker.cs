public class BracketCheckWorker
{

    public BracketCheckWorker()
    {
        
    }
    public static bool HasMatchingBrackets(string input)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (c == '<') count++;
            else if (c == '>') count--;

            if (count < 0) return false; 
        }
        return count == 0;
    }
}