using ElCadete;
using ElPedido;
namespace LaCadeteria;
public class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> ListadoCadetes;
    private List<Pedido> Pedidos;


    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes1 { get => ListadoCadetes; set => ListadoCadetes = value; }
    internal List<Pedido> Pedidos1 { get => Pedidos; set => Pedidos = value; }


    public Cadeteria(string nombre, int telefono, List<Cadete> listadoCadetes, List<Pedido> pedidos)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        ListadoCadetes = listadoCadetes;
        Pedidos = pedidos;
    }
}
