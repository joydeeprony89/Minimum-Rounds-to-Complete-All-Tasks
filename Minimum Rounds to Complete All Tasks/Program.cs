// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/description/
//https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/solutions/1955622/java-c-python-sum-up-freq-2-3/
//https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/solutions/2995202/java-solution-with-2-approach/

public class Solution
{
  public int MinimumRounds(int[] tasks)
  {
    Dictionary<int, int> frequency = new Dictionary<int, int>();
    foreach (int t in tasks)
    {
      if (!frequency.ContainsKey(t)) frequency.Add(t, 0);
      frequency[t]++;
    }

    int res = 0;
    foreach (var val in frequency.Values)
    {
      if (val == 1) return -1;
      res += val / 3;
      if (val % 3 != 0) res++;
    }

    return res;
  }
}