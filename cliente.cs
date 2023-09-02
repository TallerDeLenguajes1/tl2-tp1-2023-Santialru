namespace ElCliente;
public class Cliente
{
    private string nombre;
    private string direccion;
    private int telefono;
    private string refe;

    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Refe { get; set; }


    public Cliente (string _nombre, string _direccion, int _telefono, string _refe)
    {
        this.nombre = _nombre;
        this.telefono = _telefono;
        this.direccion = _direccion;
        this.refe = _refe;
    }

    public void getDireccion()
    {
        Console.WriteLine(direccion);
    }
    
    public void ListarDatos()
    {
        Console.WriteLine(nombre);
        Console.WriteLine(telefono);
        Console.WriteLine(direccion);
        Console.WriteLine(refe);
    }
}