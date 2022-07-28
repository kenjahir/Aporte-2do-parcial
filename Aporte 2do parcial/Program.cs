//Este programa crea un vehículo y a continuación una vista a la que le pide la visualización. A continuación se modifica el precio y la vista se refresca. A continuación se crea una segunda vista que se asocia al mismo vehículo. El precio se modifica de nuevo y ambas vistas se refrescan.
Vehiculo vehiculo = new Vehiculo();
vehiculo.descripcion = "Vehículo económico";
vehiculo.precio = 5000.0;
VistaVehiculo vistaVehiculo = new VistaVehiculo(vehiculo);
vistaVehiculo.redibuja();
vehiculo.precio = 4500.0;
VistaVehiculo vistaVehiculo2 = new VistaVehiculo(vehiculo);
vehiculo.precio = 5500.0;