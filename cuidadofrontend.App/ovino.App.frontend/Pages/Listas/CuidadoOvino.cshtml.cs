using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ovino.App.frontend.Pages
{
    public class CuidadoOvinoModel : PageModel
    {
        private string[] vectorOpciones ={ "ID ",    
        "Nit", "Nombre"} ; // vector de opciones me desplega una lista 
        public List<string> mylista{get;set;}  // instanciar la lista 
        public void OnGet()
        {
            mylista = new List<string>(); // creacion de la lista 
            mylista.AddRange(vectorOpciones); // adicionar los elementos del vector a la lista
        }
    }
}