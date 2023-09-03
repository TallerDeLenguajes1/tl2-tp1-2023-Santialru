
using ElCadete;
using ElPedido;
namespace LaCadeteria;
public class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> listadoCadetes;
    private List<Pedido> pedidos;


    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
    internal List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }


    public Cadeteria(string nombre, int telefono, List<Cadete> listadoCadetes, List<Pedido> pedidos)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        this.listadoCadetes = listadoCadetes;
        this.pedidos = pedidos;
    }

    public void CargarDatosCadeteria()
    {
        // Console.WriteLine("Nombre de la Cadeteria: ");
        // Nombre = Console.ReadLine();
        
        // Console.WriteLine("Telefono de la Cadeteria: ");
        // Telefono = int.Parse(Console.ReadLine());
    }

    private void LeerArchivoCadetes()
    {
        string filePath = "ruta_del_archivo.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Saltar la línea de encabezado si es necesario
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    if (data.Length == 4)
                    {
                        int Id = Convert.ToInt32(data[0]);
                        string Nombre = data[1];
                        string Direccion = data[2];
                        int Telefono = Convert.ToInt32(data[3]);
                        List <Pedido> listapedido = new List<Pedido>();
                        Cadete cadete = new Cadete(Id, Nombre, Direccion, Telefono, listapedido);
                    }
                    else
                    {
                        Console.WriteLine("Error: El archivo CSV no tiene el formato correcto.");
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public void AltaPedido(Pedido _pedido)
    {
        Pedidos.Add(_pedido);
    }

    public void CambiarEstado(Pedido UnPedido)
    {
        Console.WriteLine("ESTADO DEL PEDIDO (1:Preparando, 2:En camino, 3:Entregado)");
        int estado;
        int.TryParse(Console.ReadLine(), out estado);
        switch (estado)
        {
            case 1:
                UnPedido.Estado = "Preparando";
                break;
            case 2:
                UnPedido.Estado = "En camino";
                break;
            case 3:
                UnPedido.Estado = "Entregado";
                break;
            default:
                Console.WriteLine("elegiste una opcion incorrecta");
                break;
        }
        
    }

    public void ReasignarPedido(Pedido UnPedido, Cadete UnCadete)
    {
        UnCadete.Pedidos.Add(UnPedido);
    }
}
