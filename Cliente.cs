public static class Helper
{
    public static string GetNombreDePresentacion(int presentacion)
    {
        switch (presentacion)
        {
            case 1:
                return $"Jetta clasico";
            case 2:
                return $"Vento";
            case 3:
                return $"Nivus";
            default:
                return $"No definido";
        }
    }

    public static string GetNombreDeManofactura(int manofactura)
    {
        switch (manofactura)
        {
            case 1:
                return $"Agencia";
            case 2:
                return $"Fabrica";
            default:
                return $"No definido";
        }
    }

}
public class Cliente
{
    public Cliente(string nombre, string nombreAuto, int presentacion, int manofactura, double precio)
    {
        NombreCliente = nombre;
        NombreAuto = nombreAuto;
        Presentacion = presentacion;
        Manofactura = manofactura;
        Precio = precio;
    }
    private string NombreCliente { get; set; }
    private string NombreAuto { get; set; }
    private int Presentacion { get; set; }
    private int Manofactura { get; set; }
    private double Precio { get; set; }


    public string GetNombreCliente { get { return NombreCliente; } }
    public string GetNombreAuto { get { return NombreAuto; } }

    public string GetName
    {
        get
        {
            return NombreCliente;
        }
    }
    public int GetManofactura
    {
        get { return Manofactura; }
    }
    public int GetPresentacion { get { return Presentacion; } }

    public string GetPrecioMessage
    {
        get
        {
            switch (Manofactura)
            {
                case 1:
                    string precioConDescuento = (Precio - (Precio * 0.10)).ToString("0.00") + " MXN";
                    return $"El precio del auto {NombreAuto} es de {precioConDescuento} con un descuento del 10%";
                case 2:
                    return $"El precio del auto {NombreAuto} es de {Precio.ToString("0.00") + " MXN"}";
                default:
                    return $"El precio del auto {NombreAuto} es de {Precio.ToString("0.00") + " MXN"}";
            }
        }
    }
    public double GetPrecioConDescuento
    {
        get
        {
            switch (Manofactura)
            {
                case 1:
                    return Precio - (Precio * 0.10);
                case 2:
                    return Precio;
                default:
                    return Precio;
            }
        }
    }

    public double GetPrecio
    {
        get
        {
            return Precio;
        }
    }
    public string Message
    {
        get
        {
            return $"El cliente {NombreCliente} compro el auto {NombreAuto} en la presentacion {GetPresentacionCoche} y manofacturado en {GetManofacturaCoche} por un precio de {Precio}";
        }
    }
    public string GetPresentacionCoche
    {
        get
        {
            return Helper.GetNombreDePresentacion(Presentacion);
        }
    }
    public string GetManofacturaCoche
    {
        get
        {
            return Helper.GetNombreDeManofactura(Manofactura);
        }
    }
}
public class AdministradorCoches
{
    public AdministradorCoches(List<Cliente> clientes)
    {
        Clientes = clientes;
    }
    protected List<Cliente> Clientes { get; set; }

    public void Agregar(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void Eliminar(Cliente cliente)
    {
        Clientes.Remove(cliente);
    }

    public void MostrarClientes()
    {
        foreach (var cliente in Clientes)
        {
            Console.WriteLine(cliente.Message);
        }
    }
    public void MostrarPrecios()
    {
        foreach (var cliente in Clientes)
        {
            Console.WriteLine(cliente.GetPrecioMessage);
        }
    }

    public void MostrarAutosPorManofactura(int manofactura)
    {
        int count = 0;
        foreach (var cliente in Clientes)
        {
            if (cliente.GetManofactura == manofactura)
            {
                count++;
            }
        }
        Console.WriteLine($"Hay {count} autos en la manofactura {Helper.GetNombreDeManofactura(manofactura)}");
    }

    public void MostrarAutosPorPresentacion(int presentacion)
    {
        int count = 0;
        foreach (var cliente in Clientes)
        {
            if (cliente.GetPresentacion == presentacion)
            {
                count++;
            }
        }
        Console.WriteLine($"Hay {count} autos en la presentacion {Helper.GetNombreDePresentacion(presentacion)}");
    }

    public void MostrarMontoTotal()
    {
        double montoTotal = 0;
        foreach (var cliente in Clientes)
        {
            montoTotal += cliente.GetPrecioConDescuento;
        }
        Console.WriteLine($"El monto total por todos los coches es de {montoTotal.ToString("0.00") + " MXN"}");
    }

    public void MostrarReporteDeVentas()
    {
        Console.WriteLine("Reporte de ventas");


        foreach (var cliente in Clientes)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Cliente: {cliente.GetName}");
            Console.WriteLine($"Auto: {cliente.GetNombreAuto}");
            Console.WriteLine($"Precio: {cliente.GetPrecio}");
            Console.WriteLine($"Precio despues de descuentos: {cliente.GetPrecioConDescuento}");
            Console.WriteLine($"Presentacion: {cliente.GetPresentacionCoche}");
            Console.WriteLine($"Manofactura: {cliente.GetManofacturaCoche}");
            Console.WriteLine("====================================");
        }

        MostrarAutosPorPresentacion(1);
        MostrarAutosPorPresentacion(2);
        MostrarAutosPorPresentacion(3);
        MostrarAutosPorPresentacion(4);
        Console.WriteLine("====================================");

        MostrarAutosPorManofactura(1);
        MostrarAutosPorManofactura(2);
        Console.WriteLine("====================================");

    }
}