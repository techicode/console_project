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

    public DatoDTO? BuscarPorId(int id)
    {
        // for(int i =0; i < DatoDTO.Listar().Count; i++)
        // {
        //     if (DatoDTO.Listar()[i].Id == id)
        //     {
        //         return DatoDTO.Listar()[i];
        //     }
        // }

        // foreach (var dato in DatoDTO.Listar())
        // {
        //     if (dato.Id == id)
        //     {
        //         return dato;
        //     }
        // }

        return DatoDTO.Listar().FirstOrDefault(x => x.Id == id);
    }
}