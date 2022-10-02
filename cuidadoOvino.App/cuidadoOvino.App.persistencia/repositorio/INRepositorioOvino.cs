using System.Collections.Generic ; // libreria de donde se define las interfaces 
using cuidadoOvino.App.dominio;
using System.Linq ;

namespace cuidadoOvino.App.persistencia 
{
    public interface INRepositorioOvino 
    {
        Ovejas AddOvino(Ovejas ovinos) ;
        void DeleOvino(int id ) ;
        IEnumerable <Ovejas> GetAllOvino() ;
        Ovejas GetOvino(int id) ;
        Ovejas UpdateOvino(Ovejas ovinos) ;

    }
}