abstract class Empleado
{
    private string nombre;
    private int dni;
    
    public string Nombre{get{return this.nombre;}set{this.nombre = value;}}
    public int Dni{get{return this.dni;}set{this.dni = value;}}


    public Empleado(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
    }


    public virtual void Reportes()
    {
        System.Console.WriteLine("Nombre: " + nombre);
        System.Console.WriteLine("DNI: " + dni);
    }
}