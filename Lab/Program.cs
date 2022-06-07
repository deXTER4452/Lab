Console.WriteLine("Please enter a number");


int GetNumberInput(int myNum)
{
    
     myNum = Int32.Parse(Console.ReadLine());
    //string[] myArray = new string[myNum];
    //Console.WriteLine("Please enter " + myNum + " words");
    //for (int i = 0; i < myArray.Length; i++)
    //{
    //    myArray[i] = Console.ReadLine();

    //};

    return myNum;
}

//Console.WriteLine("Please enter a character");
//char myChar = Console.ReadKey().KeyChar;
//int counter = 0;
//double percentage = 0;

//for (int i = 0; i < myArray.Length; i++)
//{
//    for (int j = 0; j < myArray[i].Length; j++)
//    {
//        if (myChar == myArray[i][j])
//        {
//            counter++;
//        }
//        //percentage = (counter/myArray[i].Length) * 100;
//    }
//}

//Console.WriteLine(" /n The letter " + myChar + "appears " + counter + " times in the array. This letter makes up more than " + percentage + "% of the total number of characters.");