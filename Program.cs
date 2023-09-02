using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// using Empresa;
class Program
{
    static void Main(string[] args)
    {
        Cadeteria cadeteria = new Cadeteria();
        CargarDatosCsv(cadeteria);

        while (true)
        {
            Console.WriteLine("1. Dar de alta pedido");
            Console.WriteLine("2. Asignar pedido a cadete");
            Console.WriteLine("3. Cambiar estado de pedido");
            Console.WriteLine("4. Reasignar pedido a otro cadete");
            Console.WriteLine("5. Mostrar informe de pedidos");
            Console.WriteLine("6. Salir");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ingrese número de pedido:");
                    int nroPedido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese observaciones:");
                    string observaciones = Console.ReadLine();
                    Console.WriteLine("Ingrese nombre del cliente:");
                    string nombreCliente = Console.ReadLine();
                    Console.WriteLine("Ingrese dirección del cliente:");
                    string direccionCliente = Console.ReadLine();
                    Console.WriteLine("Ingrese teléfono del cliente:");
                    string telefonoCliente = Console.ReadLine();

                    Cliente cliente = new Cliente
                    {
                        Nombre = nombreCliente,
                        Direccion = direccionCliente,
                        Telefono = telefonoCliente
                    };

                    Pedido nuevoPedido = new Pedido
                    {
                        Nro = nroPedido,
                        Obs = observaciones,
                        Cliente = cliente,
                        Estado = "preparando"
                    };

                    cliente.PedidoAsignado = nuevoPedido;
                    cadeteria.Pedidos.Add(nuevoPedido);
                    break;

                case 2:
                    Console.WriteLine("Ingrese número de pedido:");
                    int numPedido = int.Parse(Console.ReadLine());
                    Pedido pedido = cadeteria.Pedidos.FirstOrDefault(p => p.Nro == numPedido);
                    if (pedido != null)
                    {
                        Console.WriteLine("Ingrese ID del cadete:");
                        int idCadete = int.Parse(Console.ReadLine());
                        Cadete cadeteAsignado = cadeteria.ListadoCadetes.FirstOrDefault(c => c.Id == idCadete);
                        if (cadeteAsignado != null)
                        {
                            pedido.Estado = "en camino";
                            cadeteAsignado.Pedidos.Add(pedido);
                            Console.WriteLine("Pedido asignado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Cadete no encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pedido no encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese número de pedido:");
                    int numPedidoEstado = int.Parse(Console.ReadLine());
                    Pedido pedidoEstado = cadeteria.Pedidos.FirstOrDefault(p => p.Nro == numPedidoEstado);
                    if (pedidoEstado != null)
                    {
                        Console.WriteLine("Ingrese nuevo estado (preparando/en camino/entregado):");
                        string nuevoEstado = Console.ReadLine();
                        pedidoEstado.Estado = nuevoEstado;
                        Console.WriteLine("Estado actualizado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Pedido no encontrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Ingrese número de pedido:");
                    int numPedidoReasignar = int.Parse(Console.ReadLine());
                    Pedido pedidoReasignar = cadeteria.Pedidos.FirstOrDefault(p => p.Nro == numPedidoReasignar);
                    if (pedidoReasignar != null)
                    {
                        Console.WriteLine("Ingrese ID del nuevo cadete:");
                        int idNuevoCadete = int.Parse(Console.ReadLine());
                        Cadete nuevoCadete = cadeteria.ListadoCadetes.FirstOrDefault(c => c.Id == idNuevoCadete);
                        if (nuevoCadete != null)
                        {
                            Cadete cadeteActual = pedidoReasignar.CadeteAsignado;
                            cadeteActual.Pedidos.Remove(pedidoReasignar);
                            pedidoReasignar.CadeteAsignado = nuevoCadete;
                            nuevoCadete.Pedidos.Add(pedidoReasignar);
                            Console.WriteLine("Pedido reasignado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Nuevo cadete no encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pedido no encontrado.");
                    }
                    break;

                case 5:
                    VerReporte(cadeteria);
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    static void CargarDatosCsv(Cadeteria cadeteria)
    {
        // Cargar datos de cadetes desde archivo CSV
        // ...

        // Cargar datos de pedidos desde archivo CSV
        // ...
    }

    static void VerReporte(Cadeteria cadeteria)
    {
        Console.WriteLine("Informe de Pedidos");
        Console.WriteLine("==================");

        foreach (Cadete cadete in cadeteria.ListadoCadetes)
        {
            Console.WriteLine($"Cadete: {cadete.Nombre}");
            Console.WriteLine($"Cantidad de envíos: {cadete.Pedidos.Count}");
            Console.WriteLine("==================");
        }

        double totalEarnings = cadeteria.ListadoCadetes.Sum(c => c.JornalACobrar());
        double averageDeliveries = cadeteria.ListadoCadetes.Average(c => c.Pedidos.Count);

        Console.WriteLine($"Monto total ganado: {totalEarnings}");
        Console.WriteLine($"Cantidad promedio de envíos por cadete: {averageDeliveries}");
    }
}

// class Pedido
// {
//     public int Nro { get; set; }
//     public string Obs { get; set; }
//     public Cliente Cliente { get; set; }
//     public string Estado { get; set; }
//     public Cadete CadeteAsignado { get; set; }
// }

// class Cliente
// {
//     public string Nombre { get; set; }
//     public string Direccion { get; set; }
//     public string Telefono { get; set; }
//     public Pedido PedidoAsignado { get; set; }
// }

// class Cadete
// {
//     public int Id { get; set; }
//     public string Nombre { get; set; }
//     public string Direccion { get; set; }
//     public string Telefono { get; set; }
//     public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

//     public double JornalACobrar()
//     {
//         return Pedidos.Count * 500;
//     }
// }

// class Cadeteria
// {
//     public string Nombre { get; set; }
//     public string Telefono { get; set; }
//     public List<Cadete> ListadoCadetes { get; set; } = new List<Cadete>();
//     public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
// }

