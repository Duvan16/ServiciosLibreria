using Microsoft.AspNetCore.Identity;
using Servicios.api.Seguridad.Core.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios.api.Seguridad.Core.Persistence
{
    public class SeguridadData
    {
        public static async Task InsertarUsuario(SeguridadContexto context, UserManager<Usuario> usuarioManager)
        {
            if (!usuarioManager.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nombre = "Duvan",
                    Apellido = "Gon",
                    Direccion = "callle",
                    UserName = "duvang",
                    Email = "duva.f@gmail.com"
                };

                await usuarioManager.CreateAsync(usuario, "Password123$");
            }
        }
    }
}
