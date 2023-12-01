using System.Reflection.Emit;

namespace C_sharp_Palindrome;

class Palindrome
{
    public static void Main(string[] args)
    {
        string[] arr = { "racecar", "bus", "happy", "civic", "radar", "rates", "level" };
        List<string> reverseArr = new List<string>();

        foreach (string i in arr)
        {
            char[] newarr = i.ToCharArray();
            Array.Reverse(newarr);

            string newstr = new string(newarr);
            reverseArr.Add(newstr);
        }

        for (int i = 0; i < reverseArr.Count; i++)
        {
            if (reverseArr[i] == arr[i])
                Console.WriteLine(arr[i] + " is a Palindrome");
            else
                Console.WriteLine(arr[i] + " is not a Palindrome");
        }
    }
}