using OOP.DTO;

namespace OOP.DAL;

public class DatoDAL
{
    private List<DatoDTO> listaDatos = new List<DatoDTO>();

    public bool Insertar(DatoDTO dato)
    {
        return DatoDTO.Agregar(dato);
    }

    public bool Actualizar(DatoDTO dato)
    {
        return false;
    }

    public bool Eliminar(DatoDTO dato)
    {
        return false;
    }

    public List<DatoDTO> Listar()
    {
        return DatoDTO.Listar();
    }
}