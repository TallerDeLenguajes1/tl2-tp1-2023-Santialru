namespace Empresa;
class Pedido
{
    private int Nro;
    private string Obs;
    private Cliente Cliente;
    private string Estado;
    private Cadete CadeteAsignado;

    public int Nro1 { get => Nro; set => Nro = value; }
    public string Obs1 { get => Obs; set => Obs = value; }
    public string Estado1 { get => Estado; set => Estado = value; }
    internal Cliente Cliente1 { get => Cliente; set => Cliente = value; }
    internal Cadete CadeteAsignado1 { get => CadeteAsignado; set => CadeteAsignado = value; }
}

class Cliente
{
    private string nombre;
    private string direccion;
    private int telefono;
    private Pedido PedidoAsignado;

    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public Pedido PedidoAsignado1 { get; set; }
}

class Cadete
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

class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> ListadoCadetes;
    private List<Pedido> Pedidos;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes1 { get => ListadoCadetes; set => ListadoCadetes = value; }
    internal List<Pedido> Pedidos1 { get => Pedidos; set => Pedidos = value; }
}

