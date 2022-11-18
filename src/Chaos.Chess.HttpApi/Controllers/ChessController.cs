using Chaos.Chess.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaos.Chess.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ChessController : AbpControllerBase
{
    protected ChessController()
    {
        LocalizationResource = typeof(ChessResource);
    }
}
