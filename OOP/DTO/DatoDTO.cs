namespace OOP.DTO;

public class DatoDTO
{
    private int id;
    private float flujo;
    private float nivel;
    private float temperatura;
    private float voltaje;
    private BancoDTO banco;
    private CeldaDTO celda;

    private static List<DatoDTO> datos = new List<DatoDTO>()
    {
        new DatoDTO() { id = 1, flujo = 2, nivel = 1, temperatura = 14, voltaje = 2 },
        new DatoDTO() { id = 2, flujo = 2, nivel = 1, temperatura = 20, voltaje = 3 },
        new DatoDTO() { id = 3, flujo = 3.1f, nivel = 2, temperatura = 22, voltaje = 5 },
        new DatoDTO() { id = 4, flujo = 2.4f, nivel = 3, temperatura = 24, voltaje = 3, },
    };

    public DatoDTO()
    {
    }

    public DatoDTO(int id, float flujo, float nivel, float temperatura, float voltaje, BancoDTO banco, CeldaDTO celda)
    {
        this.id = id;
        this.flujo = flujo;
        this.nivel = nivel;
        this.temperatura = temperatura;
        this.voltaje = voltaje;
        this.banco = banco;
        this.celda = celda;
    }

    public DatoDTO(int id, float flujo, float nivel, float temperatura, float voltaje)
    {
        this.id = id;
        this.flujo = flujo;
        this.nivel = nivel;
        this.temperatura = temperatura;
        this.voltaje = voltaje;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public float Flujo
    {
        get => flujo;
        set => flujo = value;
    }

    public float Nivel
    {
        get => nivel;
        set => nivel = value;
    }

    public float Temperatura
    {
        get => temperatura;
        set => temperatura = value;
    }

    public float Voltaje
    {
        get => voltaje;
        set => voltaje = value;
    }


    public BancoDTO Banco
    {
        get => banco;
        set => banco = value ?? throw new ArgumentNullException(nameof(value));
    }

    public CeldaDTO Celda
    {
        get => celda;
        set => celda = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float TemperaturaFarenheit
    {
        get => (temperatura * 9 / 5) + 32;
    }

    public static bool Agregar(DatoDTO nuevoDatos)
    {
        try
        {
            datos.Add(nuevoDatos);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al agregar");
            return false;
        }
    }

    public static List<DatoDTO> Listar()
    {
        return datos;
    }

    public static int ObtenerIndice(int id)
    {
        for (int i = 0; i < datos.Count; i++)
        {
            if (datos[i].id == id)
            {
                return i;
            }
        }
        return -1;
    }

    public static DatoDTO ObtenerDato(int id)
    {
        for (int i = 0; i < datos.Count; i++)
        {
            if (datos[i].id == id)
            {
                return datos[i];
            }
        }
        return new DatoDTO();
    }

    public static bool Eliminar(int id)
    {
        int idEncontrado = ObtenerIndice(id);
        if (idEncontrado >= 0)
        {
            datos.RemoveAt(idEncontrado);
            return true;
        }

        return false;
    }
}