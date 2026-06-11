class Coordinador : Empleado
{
    private string areas;
    private int cantidadPersonas;




    public string Areas{get{return this.areas;}set{this.areas = value;}}
    public int CantidadPersonas{get{return this.cantidadPersonas;}set{this.cantidadPersonas = value;}}




    public Coordinador( string nombre, int dni, string areas, int cantidadPersonas): base(nombre,dni)
    {
        Areas = areas;
        CantidadPersonas = cantidadPersonas;
    }
    public override void Reportes()
    {
        base.Reportes();
        Console.WriteLine("Areas asignadas: " + areas);
        Console.WriteLine("Cantidad de Personas asignadas: " + cantidadPersonas);
    }
}