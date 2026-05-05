using GBPColmadoNet.Data.Models;

namespace GBPColmadoNet.UI.Services
{
    public static class SessionManager
    {
        public static Usuario? CurrentUser { get; private set; }

        public static void Login(Usuario usuario)
        {
            CurrentUser = usuario;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsAuthenticated => CurrentUser != null;
    }
}
