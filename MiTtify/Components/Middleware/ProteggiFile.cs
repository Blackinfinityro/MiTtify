using Microsoft.AspNetCore.Authentication;

namespace MiTtify.Components.Middleware;

record OpzioniProteggiFile(string Percorso);

class ProteggiFile(RequestDelegate next, OpzioniProteggiFile opzioni)
{
    public async Task Invoke(HttpContext httpContext)
    {
        var eAutenticato = httpContext.User.Identities.Any(i => i.IsAuthenticated);
        var eSegreto = httpContext.Request.Path.StartsWithSegments(opzioni.Percorso);
        if (!eAutenticato && eSegreto)
            await httpContext.ChallengeAsync();
        else
            await next(httpContext);
    }
}

static class ProteggiFileExtensions
{
    public static IApplicationBuilder UsaProteggiFile(this IApplicationBuilder app, OpzioniProteggiFile opzioni) =>
        app.UseMiddleware<ProteggiFile>(opzioni);
}