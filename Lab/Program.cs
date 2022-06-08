bool IsPalindrome(string testString)
{

    String newStr = testString;
    for(int i = 0; i < testString.Length; i++)
    {
        for(int j = newStr.Length - 1; j >= 0; j--)
        {
            if(newStr[j] == testString[i])
            {
                return true;
            }


            //if(testString[j] == testString[i])
            //{
            //    return true;
            //}
        }
    }
    return false;
}

//Console.WriteLine(IsPalindrome("nap"));




char[] DuplicateCharacters(string testString)
{
    char[] result = new char[testString.Length];
    for(int i = 0; i < testString.Length; i++)
    {
        for(int j = i+1; j < testString.Length -1; j++)
        {
            if(testString[j] == testString[i])
            {
                result[i] = testString[i];
                Array.Resize(ref result, result.Length - 1);
               
            }
        }
    }

    return result;
}


//String myStr = "this is a string";
//Console.WriteLine(DuplicateCharacters(myStr));