namespace exerciciosOO8.Classes;

public class PlanoCartesiano
{
    private int x;
    private int y;

    public int X
    {
        get => x;
        set => x = value;
    }

    public int Y
    {
        get => y;
        set => y = value;
    }
    
    
    public PlanoCartesiano(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public void Mostrar()
    {
        Console.WriteLine($"X: {X} Y: {Y}");
    }
}