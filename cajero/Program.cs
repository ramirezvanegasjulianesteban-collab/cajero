class Cajero
{
    double saldo = 500.00;



    void menu()
    {
        string opcion;
        do
        {
            Console.Clear();
            Console.WriteLine(@"====seleccione la operacion====
1. Consultar saldo
2. Consignar dinero
3. retirar saldo
4. Salir");
            Console.WriteLine("Ingrese la opcion deseada: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ConsultarSaldo();
                    break;
                case "2":
                    ConsignarDinero();
                    break;
                case "3":
                    RetirarDinero();
                    break;
                case "4":
                    Console.WriteLine("Gracias por usar el cajero.");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Intente de nuevo.");
                    Console.ReadKey();
                    break;

            }
            if (opcion != "4")
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }


        }
        while (opcion != "4");
        {
            void ConsultarSaldo()
            {
                Console.Clear();
                Console.WriteLine($"Su saldo actual es: {saldo:C}");
                OtraOperacion();
            }
            void ConsignarDinero()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el monto a consignar: ");
                double monto = Convert.ToDouble(Console.ReadLine());
                if (monto <= 0)
                {
                    Console.WriteLine("El monto debe ser mayor a cero.");
                    ConsignarDinero();
                }
                else
                {
                    saldo += monto;
                    Console.WriteLine($"Se han consignado {monto:C}. Su nuevo saldo es: {saldo:C}");
                    OtraOperacion();
                }


            }
            void RetirarDinero()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el monto a retirar: ");
                double monto = Convert.ToDouble(Console.ReadLine());
                if (monto == 0)
                {
                    Console.WriteLine("El monto debe ser mayor a cero.");
                    RetirarDinero();
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Saldo insuficiente.");
                    RetirarDinero();
                }
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Se han retirado {monto:C}. Su nuevo saldo es: {saldo:C}");
                    OtraOperacion();
                }

            }
            void salir()
            {
                Console.WriteLine("Gracias por usar el cajero.");
                Environment.Exit(0);
            }
            void OtraOperacion()
            {
                Console.WriteLine("\n Desea realizar otra operacion? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta == "s")
                {
                    menu();
                }
                else
                {
                    salir();
                }

            }

        }

        

    }
    static void Main(string[] args)
    {
        Cajero cajero = new Cajero();
        cajero.menu();
    }
}

