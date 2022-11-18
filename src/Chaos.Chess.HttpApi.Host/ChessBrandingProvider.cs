using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Chaos.Chess;

[Dependency(ReplaceServices = true)]
public class ChessBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Chess";
}
