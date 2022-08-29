namespace RenamedNamespace;

public record MyAddedRecord(string Name)
{
    private readonly string _name = Name;

    public string GetName() => _name;

    //public void SetName(string value) => _name = value;
    public override string ToString()
    {
        return $"{nameof(_name)}: {_name}, {nameof(Name)}: {Name}";
    }
}