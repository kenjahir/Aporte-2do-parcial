﻿sing System;
// gestiona un texto que contiene la descripción y el precio del vehículo asociado
// (el sujeto). Este texto se actualiza tras cada notificación 
//en el cuerpo del método actualiza. 
//El método redibuja imprime este texto por pantalla.
public class VistaVehiculo : Observador
{
    protected Vehiculo vehiculo;
    protected string texto = "";

    public VistaVehiculo(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
        vehiculo.agrega(this);
        actualizaTexto();
    }

    protected void actualizaTexto()
    {
        texto = "Descripción " + vehiculo.descripcion +
        " Precio: " + vehiculo.precio;
    }

    public void actualiza()
    {
        actualizaTexto();
        this.redibuja();
    }

    public void redibuja()
    {
        Console.WriteLine(texto);
    }
}
