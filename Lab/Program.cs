using System.Text;

bool IsPalindrome(string testString)
{
    StringBuilder sb = new StringBuilder();
    char[] myChars = testString.ToCharArray();
    char[] reverseChars = new char[myChars.Length];
    for(int i = myChars.Length - 1; i >= 0; i++)
    {
        reverseChars[i] = myChars[i];
        if (myChars[i] == reverseChars[i])
        {
            return true;
        }
    }


    return false;
}








char[] DuplicateCharacters(string testString)
{

    char[] myChars = new char[testString.Length];
    char[] results = new char[testString.Length];

    for(int i = 0; i < myChars.Length; i++)
    {
        for(int j = i+1; j < myChars.Length; i++)
        {
            if (myChars[i] == myChars[j])
            {
                
                Array.Resize(ref results, results.Length - 1);
                break;
            }
            else
            {
                results[i] += myChars[i];
            }
        }
    }
    return results;
}


//