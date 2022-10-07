namespace POO;

internal class Temperatura
{
    public double celsius = 0;

    public double getCelsius()
    {
        return celsius = ((celsius * 9) / 5) +32;
    }

    public void setCelsius(double fahrenheit)
    {
        Console.WriteLine("Fahrenheit "+fahrenheit);
        celsius = ((fahrenheit - 32) * 5) / 9;
        Console.WriteLine("Celsius "+celsius);
    }
}