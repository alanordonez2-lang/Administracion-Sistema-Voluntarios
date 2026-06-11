class Program
{
    static List<Empleado> empleados = new List<Empleado>();
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bienvenido al sistema de Voluntarios");
        int opcion;
        do
        {
            Console.WriteLine("Seleccione la opcion que desea:");
            Console.WriteLine("0. Salir del programa");
            Console.WriteLine("1. Administrar Empleados");
            Console.WriteLine("2. Mostrar Informacion");




            opcion = int.Parse(Console.ReadLine());




            switch(opcion)
            {
                case 0:
                    Console.WriteLine("Ha salido del programa con exito");
                break;
                case 1:
                    AdministrarEmpleados();    
                break;
                case 2:
                    MostrarInfo();
                break;
            }
        }
        while(opcion != 0);
    }
    static void AdministrarEmpleados()
    {
        Console.WriteLine("Seleccione el tipo de accion que desea");
        Console.WriteLine("1. Agregar empleado");
        Console.WriteLine("2. Eliminar empleado");
        int indice = int.Parse(Console.ReadLine());
        
        if(indice==1)
        {
            Console.WriteLine("Ingrese tipo de empleado que quiere agregar");
            Console.WriteLine("1. Coordinador");
            Console.WriteLine("2. Voluntario");


            int tipo = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese nombre del empleado");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese DNI del empleado");
            int dni = int.Parse(Console.ReadLine());


            if(tipo==1)
            {
                Console.WriteLine("Ingrese las areas asignadas");
                string areas = Console.ReadLine();


                System.Console.WriteLine("Ingrese la cantidad de personas asignadas");
                int cantidadPersonas = int.Parse(Console.ReadLine());


                empleados.Add(new Coordinador(nombre, dni, areas, cantidadPersonas));  
            }
            else if( tipo == 2)
            {
                Console.WriteLine("Ingrese la cantidad de horas que trabaja");
                double horas = double.Parse(Console.ReadLine());
                
                empleados.Add(new Voluntario(nombre,dni, horas));
            }
        }
        else if(indice==2)
        {
            if(empleados.Count == 0)
            {
                System.Console.WriteLine("No hay empleados disponibles");
                return;
            }
            for(int i=0; i<empleados.Count; i++)
            {
                Console.WriteLine(empleados[i].Nombre);
            }




            Console.WriteLine("Ingrese el empleado a eliminar(empieza desde el 0)");
            int eliminacion = int.Parse(Console.ReadLine());




            empleados.RemoveAt(eliminacion);




            Console.WriteLine("Empleado eliminado");
        }
    }


    static void MostrarInfo()
    {
        if(empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados disponibles");
            return;
        }
        for(int i=0; i<empleados.Count; i++)
        {
            Console.WriteLine(empleados[i].Nombre);
        }
        Console.WriteLine("Ingrese el empleado el cual quiere generar reportes (empieza desde el 0)");
        int calcular = int.Parse(Console.ReadLine());
        
        empleados[calcular].Reportes();
    }
}