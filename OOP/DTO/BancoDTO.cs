namespace OOP.DTO;

// equivalente a una tabla de db 
public class BancoDTO
{
    private int id;
    private int numero;
    private CeldaDTO[] celdas;

    public BancoDTO(int id, int numero, CeldaDTO[] celdas)
    {
        this.id = id;
        this.numero = numero;
        this.celdas = new CeldaDTO[] { };
        this.celdas = celdas;
    }

    public BancoDTO()
    {
        this.celdas = new CeldaDTO[] { };
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public int Numero
    {
        get => numero;
        set => numero = value;
    }

    public CeldaDTO[] Celdas
    {
        get => celdas;
        set => celdas = value ?? throw new ArgumentNullException(nameof(value));
    }
}