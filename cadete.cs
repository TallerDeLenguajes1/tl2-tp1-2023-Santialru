using ElPedido;
namespace ElCadete;
public class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    private List<Pedido> pedidos;

    public Cadete(int id, string nombre, string direccion, int telefono, List<Pedido> pedidos)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.Pedidos = pedidos;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

    public void AceptarPedido(Pedido UnPedido)
    {
        Pedidos.Add(UnPedido);
    }
    public double JornalACobrar()
    {
        return Pedidos.Count * 500;
    }
}