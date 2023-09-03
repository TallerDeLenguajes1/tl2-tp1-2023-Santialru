using ElCliente;
namespace ElPedido;
public class Pedido
{
    private Cliente cliente;
    private int nro;
    private string obs;
    private string estado;


    internal Cliente Cliente { get => cliente; set => cliente = value; }
    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public string Estado { get => estado; set => estado = value; }

    public Pedido(Cliente cliente, int nro, string obs, string estado)
    {
        this.cliente = cliente;
        this.nro = nro;
        this.obs = obs;
        this.estado = estado;
    }
    

    public void VerDireccionCliente()
    {
        Console.WriteLine("direccion: "+ cliente.Direccion);
    }

    public void VerDatosCliente()
    {
        Console.WriteLine(cliente.Nombre);
        Console.WriteLine(cliente.Telefono);
        Console.WriteLine(cliente.Direccion);
        Console.WriteLine(cliente.Refe);
    }

    public void CrearPedido(Cliente nuevoCliente)
    {
        Cliente = nuevoCliente;

        Console.WriteLine("Ingrese número de pedido:");
        Nro = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese observaciones:");
        Obs = Console.ReadLine();

        Estado = "Preparando";
    }
}