using Modelos;

namespace Examen3_Blazor.Interfaces;

public interface IUsuarioServicio
{
    Task<Usuario> GetPorCodigo(string codigo);
}
