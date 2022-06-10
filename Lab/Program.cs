Console.WriteLine("Please enter a number");


int GetNumberInput(int myNum)
{
    
     myNum = Int32.Parse(Console.ReadLine());


    return myNum;
}

string[] PopulateWordArray(int length)
{
    string[] myArray = new string[length];
    Console.WriteLine("Please enter " + length + " words");
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Console.ReadLine();

    };

    return myArray;
}


Console.WriteLine("Please enter a character");
char getCharacterInput()
{
    char myChar = Console.ReadKey().KeyChar;

    return myChar;
}





int CountCharacters(string[] words, char charToCount)
{
    int counter = 0;
    

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < words[i].Length; j++)
        {
            if (charToCount == words[i][j])
            {
                counter++;
            }
            
        }
    }

    return counter;
}

int GetCharacterOccurrencePercentage(string[] words, char charToCount)
{
    double percentage = 0;
    
    for(int i = 0; i < words.Length; i++)
    {
        percentage = (charToCount / words[i].Length) * 100;
    }
    int intPercentage = Convert.ToInt32(percentage);
    return intPercentage;
    
}


void PrintResults(char countedCharacter, int charFrequency, int charPercentage, int totalChars)
{
    Console.WriteLine(" /n The letter " + countedCharacter + "appears " + charFrequency + " times in the array. This letter makes up more than " + charPercentage + "% of the total number of characters.");
}
