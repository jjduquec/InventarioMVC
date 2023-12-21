using Microsoft.JSInterop.Implementation;
using MVCInventarios.Controllers;
using MVCInventarios.Models;

namespace MVCInventarios.Data
{
    public static class DBInitializer
    {
        

        public static void Initialize(InventariosContext context) {

            if (context.Marcas.Any()) {

                return; 
            }

            var marcas = new Marca[] {

                new Marca{Nombre="Rino" },
                new Marca{Nombre="Alfa" },
                new Marca{Nombre="Beta" }
            
            };

            context.Marcas.AddRange(marcas);
            context.SaveChanges();


            var departamentos = new Departamento[]
            {
                new Departamento{Nombre="Administracion General" }, 
                new Departamento{Nombre="Recursos Humanos"}, 
                new Departamento{Nombre="Contaduria"}
            };

            context.Departamentos.AddRange(departamentos);
            context.SaveChanges();


            var productos = new Producto[] { 
            
                new Producto {Nombre="Silla Electrica",
                              Descripcion="Silla electrica",
                              MarcaId=context.Marcas.First(u=>u.Nombre=="Rino").Id,
                              Costo=3500M

                },
                new Producto {Nombre="Silla Azul",
                              Descripcion="Silla azul",
                              MarcaId=context.Marcas.First(u=>u.Nombre=="Alfa").Id,
                              Costo=3500M

                },
                new Producto {Nombre="Silla Verde",
                              Descripcion="Silla verde",
                              MarcaId=context.Marcas.First(u=>u.Nombre=="Beta").Id,
                              Costo=3500M

                }




            };

            context.Productos.AddRange(productos);
            context.SaveChanges();
        
        
        }


    }
}
