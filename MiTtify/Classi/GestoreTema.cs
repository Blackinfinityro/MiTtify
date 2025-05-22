using BitzArt.Blazor.Cookies;
using Microsoft.AspNetCore.Components;

namespace MiTtify.Classi
{
    public class GestoreTema
    {
        private ICookieService cookies;
        private NavigationManager navigationManager;
        const string NomeCookie = "Mittify_Tema";

        public GestoreTema(ICookieService cookies, NavigationManager navigationManager)
        {
            this.cookies = cookies;
            this.navigationManager = navigationManager;
        }

        public async Task<string> PrendiTema()
        {
            return (await cookies.GetAsync(NomeCookie))?.Value ?? "lignt";
        }

        public async Task ImpostaTema(string tema)
        {
            await cookies.SetAsync(NomeCookie, tema);
            navigationManager.Refresh();
        }
    }
}
