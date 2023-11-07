ProgramaPrincipal.Iniciar(args);
public class ProgramaPrincipal
{
    public static void Iniciar(string[] args)
    {
        AdministradorCoches administradorDeCoches = new(new List<Cliente>());

        Cliente cliente = new("Juan", "El Guapo", 1, 1, 500);
        Cliente cliente1 = new("Pedro", "El Feo", 3, 2, 500);
        Cliente cliente2 = new("Maria", "Sin nombre", 2, 1, 500);
        Cliente cliente3 = new("Jose", "NoNAME", 4, 2, 500);
        Cliente cliente4 = new("Juan", "Ferrari", 1, 1, 500);

        administradorDeCoches.Agregar(cliente);
        administradorDeCoches.Agregar(cliente1);
        administradorDeCoches.Agregar(cliente2);
        administradorDeCoches.Agregar(cliente3);
        administradorDeCoches.Agregar(cliente4);

        Console.WriteLine("========BIENVENIDO=========");
        Console.WriteLine("1. Mostrar clientes");
        Console.WriteLine("2. Mostrar precios");
        Console.WriteLine("3. Mostrar reporte");
        Console.WriteLine("4. Mostrar monto total");
        Console.WriteLine("5. Salir");
        Console.WriteLine("===========================");
        Console.Write("Ingrese una opcion: ");
        int opcion = MostrarOpciones();

        while (opcion != 5)
        {

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Mostrando clientes");
                    administradorDeCoches.MostrarClientes();
                    break;
                case 2:
                    Console.WriteLine("Mostrando precios");
                    administradorDeCoches.MostrarPrecios();
                    break;
                case 3:
                    Console.WriteLine("Mostrando reporte");
                    administradorDeCoches.MostrarReporteDeVentas();
                    break;
                case 4:
                    Console.WriteLine("Mostrando monto total");
                    administradorDeCoches.MostrarMontoTotal();
                    break;
                case 5:
                    Console.WriteLine("Gracias por usar el programa");

                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.WriteLine("===========================");
            Console.WriteLine("Presione enter para continuar");
            Console.WriteLine("===========================");
            Console.ReadLine();
            opcion = MostrarOpciones();
        }
    }
    static int MostrarOpciones()
    {
        try
        {
            Console.WriteLine("========BIENVENIDO=========");
            Console.WriteLine("1. Mostrar clientes");
            Console.WriteLine("2. Mostrar precios");
            Console.WriteLine("3. Mostrar reporte");
            Console.WriteLine("4. Mostrar monto total");
            Console.WriteLine("5. Salir");
            Console.WriteLine("===========================");
            Console.WriteLine("Ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());



            return opcion;
        }
        catch (System.Exception)
        {
            return 0;
        }
    }
}

