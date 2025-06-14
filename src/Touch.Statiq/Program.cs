using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Web;
using System.Threading.Tasks;

await Bootstrapper
    .Factory
    .CreateWeb(args)
    .AddIsolatedPipeline("webfonts",
        new CopyFiles("../lib/font-awesome/webfonts/fa-solid-**").To(f =>
            Task.FromResult(new NormalizedPath("webfonts").Combine(f.Path.FileName)
        )))
    .AddIsolatedPipeline("bootstrap",
        new CopyFiles("../lib/bootstrap/js/bootstrap.min.js").To(f =>
            Task.FromResult(new NormalizedPath("scripts").Combine(f.Path.FileName)
        )))
    .RunAsync();

public record Ploeg(char Letter, int Afdeling, int AfdelingId, int TeamId);
public record Contact(string Naam, string Telefoon, string EmailGebruiker, string EmailDomein);
public record MenuItem(string Page, string AwesomeIcon, string Label);
