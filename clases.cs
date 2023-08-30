namespace Empresa;


class Cadeteria
{
    private string nombre;
    private int telefono;
    private List<Cadete> ListadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes1 { get => ListadoCadetes; set => ListadoCadetes = value; }
}

class Cadete
{
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    private List<Pedido> ListadoPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Pedido> ListadoPedidos1 { get => ListadoPedidos; set => ListadoPedidos = value; }

    public int JornalACobrar()
    {
        
        return 0;
    }
}

class Pedido
{
    private int nro;
    private string obs;
    private Cliente cli;
    private int estado;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public int Estado { get => estado; set => estado = value; }
    internal Cliente Cli { get => cli; set => cli = value; }

    public void VerDireccionCliente()
    {
        Console.WriteLine(Cli.Direccion);
    }

    public void VerDatosCliente()
    {
        Console.WriteLine(cli.Nombre);
        Console.WriteLine(cli.Direccion);
        Console.WriteLine(cli.Telefono);
        Console.WriteLine(cli.Datos);
    }
}

class Cliente 
{
    private string nombre;
    private string direccion;
    private int telefono;
    private string datos;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string Datos { get => datos; set => datos = value; }
}