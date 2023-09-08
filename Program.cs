
namespace tp1;
// using Empresa;
class Program
{
     void Main(string[] args)
    {
        var cadeteria = new Cadeteria("cadeteria.csv", "cadetes.csv"); 
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
                    Console.WriteLine("Ingrese el id del pedido a realizar");
                    string inputId = Console.ReadLine();
                    int.TryParse(inputId, out int id);
                    cadeteria.AltaPedido(id);
                    break;

                case 2:
                    Console.WriteLine("Estamos asignando el pedido a un cadete disponible...");
                    cadeteria.AsignarPedido();
                    break;

                case 3:
                    cadeteria.CambiarEstado();
                    break;

                case 4:
                    Console.WriteLine("Ingrese el id del pedido a reasignar");
                    string inputIdPedido = Console.ReadLine();
                    int.TryParse(inputIdPedido, out int idPedido);
                    Console.WriteLine("Ingrese el id del nuevo Cadete");
                    string inputIdNuevoCadete = Console.ReadLine();
                    int.TryParse(inputIdNuevoCadete, out int idNuevoCadete);

                    cadeteria.ReasignarPedido(idPedido,idNuevoCadete);
                    break;

                case 5:
                    Console.WriteLine("Aqui tienes el informe:");
                    var informe = new Informe(cadeteria);
                    informe.MostrarInforme();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

}  