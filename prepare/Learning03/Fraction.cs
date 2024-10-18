public class Fraction
{
    // Private attributes
    private int _numerator;
    private int _denominator;

    
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        // Ensure denominator is not zero
        _denominator = (denominator != 0) ? denominator : 1;
    }

    // Getters and setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
