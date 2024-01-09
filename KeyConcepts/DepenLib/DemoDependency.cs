namespace DepenLib;

public class DemoDependency
{
    public string GiveRandomNumber()
    {
        int randomValue = Random.Shared.Next(1,100);
        return $"The value is {randomValue}";
    }
}
