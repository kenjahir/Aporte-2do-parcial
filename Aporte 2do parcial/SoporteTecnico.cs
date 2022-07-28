using System;
//Contiene dos atributos y los accesos de lectura y escritura para ambos atributos.
// Los dos accesos de escritura invocan al método notifica.
public class Vehiculo : Sujeto
{
    protected string _descripcion;
    protected double _precio;

    public string descripcion
    {
        get
        {
            return _descripcion;
        }
        set
        {
            _descripcion = value;
            this.notifica();
        }
    }

    public double precio
    {
        get
        {
            return _precio;
        }
        set
        {
            _precio = value;
            this.notifica();
        }
    }

}