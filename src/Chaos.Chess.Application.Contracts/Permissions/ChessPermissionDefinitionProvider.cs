using Chaos.Chess.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Chaos.Chess.Permissions;

public class ChessPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ChessPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ChessPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ChessResource>(name);
    }
}
