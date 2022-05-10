namespace OOP.DTO;

public class CeldaDTO
{
    private int id;
    private int numero;

    public CeldaDTO(int id, int numero)
    {
        this.id = id;
        this.numero = numero;
    }

    public CeldaDTO()
    {
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
}