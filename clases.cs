namespace Empresa;


class Cadeteria
{
    string nombre;
    int telefono;
    List<Cadete> ListadoCadetes;

}

class Cadete
{
    int id;
    string nombre;
    string direccion;
    int telefono;
    List<Pedido> ListadoPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Pedido> ListadoPedidos1 { get => ListadoPedidos; set => ListadoPedidos = value; }
}

class Pedido
{
    int nro;
    string obs;
    Cliente cli;
    int estado;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public int Estado { get => estado; set => estado = value; }
    internal Cliente Cli { get => cli; set => cli = value; }
}

class Cliente 
{
    string nombre;
    string direccion;
    int telefono;
    string datos;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string Datos { get => datos; set => datos = value; }
}