using System ;

namespace cuidadoOvino.App.dominio

{
    public class VisitaDomiciliaria
        {   
             public int Id{get;set;}
             float Temperatura{get;set;}
            public float Peso{get;set;}
            public float FrecuenciaRespiratoria{get;set;}
            public float FrecuenciaCardiaca{get;set;}
            public string EstadoAnimo{get;set;}
            public string FechaVisita{get;set;}
            public string DocumentoVeterinario{get;set;}
            public string MedicinasFormuladas{get;set;}



        }

}