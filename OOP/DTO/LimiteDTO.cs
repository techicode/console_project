namespace OOP.DTO;

public class LimiteDTO
{
    private int id;
    private float flujoMin;
    private float flujoMax;
    private float nivelMin;
    private float nivelMax;
    private float temperaturaMin;
    private float temperaturaMax;
    private float voltajeMin;
    private float voltajeMax;


    public int Id
    {
        get => id;
        set => id = value;
    }

    public float FlujoMin
    {
        get => flujoMin;
        set => flujoMin = value;
    }

    public float FlujoMax
    {
        get => flujoMax;
        set => flujoMax = value;
    }

    public float NivelMin
    {
        get => nivelMin;
        set => nivelMin = value;
    }

    public float NivelMax
    {
        get => nivelMax;
        set => nivelMax = value;
    }

    public float TemperaturaMin
    {
        get => temperaturaMin;
        set => temperaturaMin = value;
    }

    public float TemperaturaMax
    {
        get => temperaturaMax;
        set => temperaturaMax = value;
    }

    public float VoltajeMin
    {
        get => voltajeMin;
        set => voltajeMin = value;
    }

    public float VoltajeMax
    {
        get => voltajeMax;
        set => voltajeMax = value;
    }
    
}