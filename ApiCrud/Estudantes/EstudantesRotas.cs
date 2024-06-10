using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Estudantes
{
    public static class EstudantesRotas
    {
        public static void AddRotasEstudantes(this WebApplication app){
            app.MapGet(pattern: "estudantes", handler: () => "Hellow estudantes!");
        }
    }
}