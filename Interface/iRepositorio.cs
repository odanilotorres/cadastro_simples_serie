using System.Collections.Generic;

namespace dio.series.Interface
{
    public interface iRepositorio<T>
    {
       List<T> Lista();
       T RetornarPorId(int id);
       void Insere(T entidade);
       void Exclui(int id);
       void Atualiza(int id, T entidade);
       int ProximoId();  
    }
}