using Chaos.Chess.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
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
