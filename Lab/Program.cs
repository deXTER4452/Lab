List<int> MaxNumbersInLists(List<List<int>> newList)
{
    List<int> myList = new List<int>();
    myList = newList.Max();

    return myList;
};

String HighestGrade(List<List<int>> newList)
{
    String myString = String.Empty;


    return myString;
}


List<int> OrderByLooping(List<int> newList)
{
    
    for(int i = 0; i < newList.Count; i++)
    {
        if(newList[i] > newList[i + 1])
        {
            int newInt = newList[i];
            newList[i] = newList[i+1];
            newList[i+1] = newInt;
        }
    }
    return newList;
}
//