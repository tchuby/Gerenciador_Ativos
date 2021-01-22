using System.ComponentModel;

namespace Gerenciador_Ativos.Domain.Enums
{
    public enum Profile
    {
        [Description("Administrador")]
        Admin = 1,

        [Description("Cliente")]
        Client = 2
    }
}
