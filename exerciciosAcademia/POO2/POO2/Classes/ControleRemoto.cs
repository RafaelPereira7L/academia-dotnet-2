namespace POO2.Classes;

public class ControleRemoto
{
    public void aumentarVolume(Televisao tv)
    {
        tv.volume++;
    }
    
    public void diminuirVolume(Televisao tv)
    {
        tv.volume--;
    }
    
    public void aumentarCanal(Televisao tv)
    {
        tv.canal++;
    }
    
    public void diminuirCanal(Televisao tv)
    {
        tv.canal--;
    }
    
    public void trocarCanal(Televisao tv, int canal)
    {
        tv.canal = canal;
    }

    public void consultar(Televisao tv)
    {
        Console.WriteLine("Canal: " + tv.canal);
        Console.WriteLine("Volume: " + tv.volume);
    }
}