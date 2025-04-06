
public abstract class Part
{
    private string Name;
    private int UsedMiles;
    private int LifeMiles;

    protected Part(string name, int usedMiles, int lifeMiles)
    {
        Name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;
        UsedMiles = usedMiles >= 0 ? usedMiles : 0;
        LifeMiles = lifeMiles >= 0 ? lifeMiles : 0;
    }

    protected Part() : this("Unknown", 0, 0) { }

    public override string ToString()
    {
        return $"{Name} - {UsedMiles} miles used, {LifeMiles} miles life";
    }
}

public class Chain : Part
{
    public Chain(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public Chain() : base() { }
}

public class Cassette : Part
{
    public Cassette(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public Cassette() : base() { }
}

public class FrontFork : Part
{
    public FrontFork(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public FrontFork() : base() { }
}

public class RearShock : Part
{
    public RearShock(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public RearShock() : base() { }
}

public class ChainRing : Part
{
    public ChainRing(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public ChainRing() : base() { }
}

public class BottomBracket : Part
{
    public BottomBracket(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public BottomBracket() : base() { }
}

public class Sealant : Part
{
    public Sealant(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public Sealant() : base() { }
}

public class BrakePads : Part
{
    public BrakePads(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public BrakePads() : base() { }
}

public class BrakeRotors : Part
{
    public BrakeRotors(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public BrakeRotors() : base() { }
}

public class Tires : Part
{
    public Tires(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public Tires() : base() { }
}

public class Dropper : Part
{
    public Dropper(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public Dropper() : base() { }
}

public class BrakeBleed : Part
{
    public BrakeBleed(string name, int usedMiles, int lifeMiles) : base(name, usedMiles, lifeMiles) { }
    public BrakeBleed() : base() { }
}

