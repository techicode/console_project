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
    Console.WriteLine("3. Actualizar Datos");
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
            OpcionActualizar();
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

static void OpcionActualizar()
{
    try
    {
        Console.WriteLine("Ingrese la ID a actualizar");
        int id = int.Parse(Console.ReadLine().Trim());

        DatoDAL datoDal = new DatoDAL();
        
        DatoDTO resultado = datoDal.BuscarPorId(id);
        if (resultado == null)
        {
            Console.WriteLine("No se encontró el dato");
            return;
        }
        
        Console.WriteLine("Desea actualizar la temperatura? (Y/N)");
        string opcionTemp = Console.ReadLine().Trim();
        if (opcionTemp.ToUpper() == "Y")
        {
            Console.WriteLine($"Ingrese la nueva temperatura (actual {resultado.Temperatura})");
            float temperatura = float.Parse(Console.ReadLine().Trim());
            resultado.Temperatura = temperatura;
        }
        
        Console.WriteLine("Desea actualizar el nivel? (Y/N)");
        string opctioNivel = Console.ReadLine().Trim();
        if (opctioNivel.ToUpper() == "Y")
        {
            Console.WriteLine($"Ingrese el nuevo nivel (actual {resultado.Nivel})");
            float nivel = float.Parse(Console.ReadLine().Trim());
            resultado.Nivel = nivel;
        }
        
        Console.WriteLine("Desea actualizar el voltaje? (Y/N)");
        string opcionVolt = Console.ReadLine().Trim();
        if (opcionVolt.ToUpper() == "Y")
        {
            Console.WriteLine($"Ingrese la nueva temperatura (actual {resultado.Temperatura})");
            float voltaje = float.Parse(Console.ReadLine().Trim());
            resultado.Voltaje = voltaje;
        }
        
        Console.WriteLine("Desea actualizar el flujo? (Y/N)");
        string opcionFlujo = Console.ReadLine().Trim();
        if (opcionFlujo.ToUpper() == "Y")
        {
            Console.WriteLine($"Ingrese la nueva temperatura (actual {resultado.Temperatura})");
            float flujo = float.Parse(Console.ReadLine().Trim());
            resultado.Flujo = flujo;
        }

        if (DatoDTO.ActualizarDato(resultado) == true)
        {
            Console.WriteLine($"Se ha actualizado con los datos ingresados");
            Console.WriteLine($"ID: {resultado.Id}, Flujo: {resultado.Flujo} Nivel: {resultado.Nivel} Temp: {resultado.Temperatura} Volt: {resultado.Voltaje}");
            return;
        }
        else
        {
            Console.WriteLine("Hubo un error actualizando");
            return;
        }
        
    }
    catch (Exception e)
    {
        Console.WriteLine("Solo se permiten números para el ID");
        return;
    }
    
    
}

static void OpcionBorrar()
{
    Console.Write("Ingrese ID de dato a borrar: ");
    int id = int.Parse(Console.ReadLine().Trim());
}
