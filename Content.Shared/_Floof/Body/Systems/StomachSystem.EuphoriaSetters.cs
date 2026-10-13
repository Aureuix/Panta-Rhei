using Content.Shared.Body.Components;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Components.SolutionManager;
using Content.Shared.Chemistry.EntitySystems;
using Robust.Shared.Utility;
using Content.Shared.Whitelist;
using Content.Shared.FixedPoint;
using Robust.Shared.GameObjects;

namespace Content.Shared.Body.Systems;

public sealed partial class StomachSystem
{
    public void SetSpecialDigestible(StomachComponent stoComp, EntityWhitelist newSpecialDigestible)
    {
        stoComp.SpecialDigestible = newSpecialDigestible;
    }

    public void SetIsSpecialDigestibleExclusive(StomachComponent stoComp, bool newIsSpecialDigestibleExclusive)
    {
        stoComp.IsSpecialDigestibleExclusive = newIsSpecialDigestibleExclusive;
    }
}
