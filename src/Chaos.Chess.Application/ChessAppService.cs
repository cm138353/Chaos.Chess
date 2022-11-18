using System;
using System.Collections.Generic;
using System.Text;
using Chaos.Chess.Localization;
using Volo.Abp.Application.Services;

namespace Chaos.Chess;

/* Inherit your application services from this class.
 */
public abstract class ChessAppService : ApplicationService
{
    protected ChessAppService()
    {
        LocalizationResource = typeof(ChessResource);
    }
}
