namespace ParkIT.Domain.Entities;

public class ParkingList
{
    public Guid Id { get; private set; }
    public string _name;
    public string _localization;


    internal ParkingList(Guid id, string name, string localization)
    {
        Id = id;
        _name = name;
        _localization = localization;
    }

}