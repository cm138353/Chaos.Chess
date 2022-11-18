using Volo.Abp.Settings;

namespace Chaos.Chess.Settings;

public class ChessSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ChessSettings.MySetting1));
    }
}
