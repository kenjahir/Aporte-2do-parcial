using System.Collections.Generic;

public abstract class Sujeto
{
    //Los observadores se gestionan mediante una lista.
    protected IList<Observador> observadores =
        new List<Observador>();

    public void agrega(Observador observador)
    {
        observadores.Add(observador);
    }

    public void suprime(Observador observador)
    {
        observadores.Remove(observador);
    }

    public void notifica()
    {
        foreach (Observador observador in observadores)
            observador.actualiza();
    }
}