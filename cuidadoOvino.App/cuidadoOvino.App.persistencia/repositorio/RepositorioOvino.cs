using System.Collections.Generic ; // libreria de donde se define las interfaces 
using cuidadoOvino.App.dominio;
using System.Linq ;

namespace cuidadoOvino.App.persistencia 
{
    public class RepositorioOvino:INRepositorioOvino //InRepoCuidadoOvino 
    {
     private readonly AppContext _appContext;  
     public RepositorioOvino(AppContext _appContext) //appContext es la variable 
     {
        _appContext=_appContext ;
     }
     Ovejas INRepositorioOvino.AddOvino(Ovejas ovinos)
        {
        var ovinoAdicionado = _appContext.Ovejas.Add(ovinos) ;
        _appContext.SaveChanges() ;
        return ovinoAdicionado.Entity ; // entity para visualizar que se guardo. 
        }
        void INRepositorioOvino.DeleOvino(int id)
        {
            var ovinoEncontrado = _appContext.Ovejas.FirstOrDefault(p=>p.Id==id);
           // if (ovinoEncontrado = null)
           // {
             //   return;
            //}
            _appContext.Ovejas.Remove(ovinoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Ovejas> INRepositorioOvino.GetAllOvino()
        {
          return _appContext.Ovejas ; 
        }

        Ovejas INRepositorioOvino.GetOvino(int id)
        {
            return _appContext.Ovejas.FirstOrDefault(p=>p.Id==id);

        }
        Ovejas INRepositorioOvino.UpdateOvino(Ovejas ovinos) 
        {
            var ovinoEncontrado = _appContext.Ovejas.FirstOrDefault(p=>p.Id==ovinos.Id) ;
            if (ovinoEncontrado!=null)
            {
                ovinoEncontrado.Nombre=ovinos.Nombre ;
                ovinoEncontrado.Raza=ovinos.Raza;
                ovinoEncontrado.Color=ovinos.Color;
                ovinoEncontrado.NombreMedicoVeterinario=ovinos.NombreMedicoVeterinario;
                ovinoEncontrado.Especie=ovinos.Especie ;
                _appContext.SaveChanges();
            }
            return ovinoEncontrado; 

        }
     }
    




}
