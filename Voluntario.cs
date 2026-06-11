class Voluntario : Empleado
{
    private double hora;


    public double Hora{get{return this.hora;}set{this.hora = value;}}


    public Voluntario( string nombre, int dni, double hora): base(nombre,dni)
    {
        Hora = hora;
    }
    public override void Reportes()
    {
        base.Reportes();
        System.Console.WriteLine("Cantidad de horas trabajadas: " + hora);
    }
}