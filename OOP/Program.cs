// See https://aka.ms/new-console-template for more information

using OOP.DAL;
using OOP.DTO;
using OOP.Utils;

// Console.WriteLine("Hello, World!");

// Console.WriteLine(ConsoleUtils.Saludar("Pepe"));

// Console.BackgroundColor = ConsoleColor.DarkBlue;
// Console.ForegroundColor = ConsoleColor.Black;
//
// Console.Write("Escriba su nombre: ");
// string nombre = Console.ReadLine();
// Console.WriteLine($"Hola {nombre}");


while (Menu())
{
    // Console.Write("Ingrese un número: ");
    Console.ReadKey();
}

static bool Menu()
{
    Console.Clear();
    Console.Title = "Ejercicio de menú";
    Console.WriteLine("1. Listar Datos");
    Console.WriteLine("2. Agregar Datos");
    Console.WriteLine("3. Eliminar Datos");
    Console.WriteLine("4. Salir");
    Console.Write("Ingrese una opción: ");
    int numero;
    try
    {
        numero = int.Parse(Console.ReadLine().Trim());
    }
    catch (Exception e)
    {
        Console.WriteLine("Debe ingresar un número valido");
        return true;
    }

    switch (numero)
    {
        case 1:
            OpcionListar();
            break;
        case 2:
            OpcionInsertar();
            break;
        case 3:
            OpcionBorrar();
            break;
        case 4:
            Console.WriteLine("Presionó salir");
            return false;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

    return true;
}

static void OpcionInsertar()
{
    try
    {
        Console.Write("Ingrese ID de dato: ");
        int id = int.Parse(Console.ReadLine().Trim());
        Console.Write("Ingrese flujo: ");
        float flujo = float.Parse(Console.ReadLine().Trim());
        Console.Write("Ingrese nivel: ");
        float nivel = float.Parse(Console.ReadLine().Trim());
        Console.Write("Ingrese temperatura:  ");
        float temperatura = float.Parse(Console.ReadLine().Trim());
        Console.Write("Ingrese voltaje: ");
        float voltaje = float.Parse(Console.ReadLine().Trim());
        
        DatoDAL datoDal = new DatoDAL();
        datoDal.Insertar(new DatoDTO()
            { Id = id, Flujo = flujo, Nivel = nivel, Temperatura = temperatura, Voltaje = voltaje });
    }
    catch (Exception e)
    {
        Console.WriteLine("Error al ingresar datos");
    }
}

static void OpcionListar()
{
    DatoDAL dal = new DatoDAL();
    List<DatoDTO> lista = dal.Listar();
    // recorrer lista
    Console.WriteLine("Listar...");
    foreach (DatoDTO dato in lista)
    {
        Console.WriteLine($"ID: {dato.Id}, Flujo: {dato.Flujo} Nivel: {dato.Nivel} Temp: {dato.Temperatura} Volt: {dato.Voltaje}");
    }
}

static void OpcionBorrar()
{
    Console.Write("Ingrese ID de dato a borrar: ");
    int id = int.Parse(Console.ReadLine().Trim());
    
}
