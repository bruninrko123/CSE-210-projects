public class Fraction
{
private int _top;
private int _bottom;

//Constructors

public Fraction()
{
    _top = 1;
    _bottom = 1;
}

public Fraction(int Top, int Bottom)
{
    _top = Top;
    _bottom = Bottom;
}

public Fraction (int WholeNumber)
{
    _top = WholeNumber;
    _bottom = 1;
}


// getters and setters

public void SetTopNumber(int TopNumber)
{
    _top = TopNumber;
    
}

public int GetTopNumber()
{

    return _top;
}



public void SetBottomNumber(int BottomNumber)
{
    _bottom = BottomNumber;
   
}

public int GetBottomNumber()
{
    

    return _bottom;
}

public string GetFractionString()
{
    string fractionString =$"{_top}" + "/" + $"{_bottom}";
    
    return fractionString;
}

public double GetDecimalValue()
{
    
    
    
    return (double)_top / (double)_bottom;
}
}