// *Esta clase esta ligada directamente al DbContex ,realizara las trasaciones
// con referenta a la database,para ello debe heredar de dbcontext llamamos al Db
using System ;
using Microsoft.EntityFrameworkCore;

using cuidadoOvino.App.dominio ;

namespace cuidadoOvino.App.persistencia 
{
    public class AppContext:DbContext
        {
            public  DbSet < CuidadoOvino > CuidadoOvino{get;set;} // ok puedo comentar 
            public DbSet < DuenoOvino > DuenoOvino {get;set;}
            public DbSet < HistoriaClinica > HistoriaClinica {get;set;}
            public DbSet < MedicoVet> MedicoVet {get;set;}
            public DbSet < Ovejas>  Ovejas {get;set;}
            public DbSet < VisitaDomiciliaria > VisitaDomiciliaria {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // produce la configuracion de nuestra 
        // base de datos llama sql.server
       {

         if(!optionsBuilder.IsConfigured)//*configuracion de la data base*/

         {
          optionsBuilder
          .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=OvinosData");//*el nombre de la base de datos*/
         }
       }   

        }
        
}