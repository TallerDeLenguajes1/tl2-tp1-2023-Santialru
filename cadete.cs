namespace ElCadete;
public class Cadete
{
    private int Id;
    private string Nombre;
    private string Direccion;
    private int Telefono;
    private List<Pedido> Pedidos;

    public int Id1 { get => Id; set => Id = value; }
    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Direccion1 { get => Direccion; set => Direccion = value; }
    public int Telefono1 { get => Telefono; set => Telefono = value; }
    internal List<Pedido> Pedidos1 { get => Pedidos; set => Pedidos = value; }

    public double JornalACobrar()
    {
        return Pedidos.Count * 500;
    }
}