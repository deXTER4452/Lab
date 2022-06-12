using System.Text;

Dictionary<int, string> CarPark = new Dictionary<int, string>();
Dictionary<int, string> InitializeCarPark(int capacity)
{
    
    for (int i = 0; i < capacity; i++)
    {
        CarPark.Add(i, string.Empty);
    }
    

    return CarPark;
}

int AddVehicle(carPark, string licence) // not sure what was meant by carPark in the question
{
    for(int i = 0; i < CarPark.Count; i++)
    {
        if (CarPark[i] == null)
        {
            CarPark[i] = licence;
            return CarPark.Count;
        }
    }

    return -1;
}

bool VacateStall(carPark, int stallNumber) // not sure what was meant by carPark in the question
{

    return false;
}

String Manifest(carPark) // not sure what was meant by carPark in the question
{
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < CarPark.Count; i++)
    {
        sb.Append(CarPark[i]);
    }

    return sb.ToString();
}