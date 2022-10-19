using RimWorld;
using UnityEngine;
using Verse;

namespace Xnayah;

public class IncidentWorker_XarkaPass : IncidentWorker_HerdMigration
{
    protected override bool CanFireNowSub(IncidentParms parms)
    {
        var map = (Map)parms.target;
        return !map.gameConditionManager.ConditionIsActive(GameConditionDefOf.ToxicFallout);
    }

    protected override bool TryExecuteWorker(IncidentParms parms)
    {
        var map = (Map)parms.target;
        if (!RCellFinder.TryFindRandomPawnEntryCell(out var intVec, map, CellFinder.EdgeRoadChance_Animal + 0.2f))
        {
            return false;
        }

        var xarka = PawnKindDefOf.Xarka;
        var points = StorytellerUtility.DefaultParmsNow(IncidentCategoryDefOf.ThreatBig, map)
            .points;
        var num = GenMath.RoundRandom(points / xarka.combatPower);
        var max = Rand.RangeInclusive(2, 4);
        num = Mathf.Clamp(num, 1, max);
        var num2 = Rand.RangeInclusive(90000, 150000);
        if (!RCellFinder.TryFindRandomCellOutsideColonyNearTheCenterOfTheMap(intVec, map, 10f, out var invalid))
        {
            invalid = IntVec3.Invalid;
        }

        Pawn pawn = null;
        for (var i = 0; i < num; i++)
        {
            var loc = CellFinder.RandomClosewalkCellNear(intVec, map, 10);
            pawn = PawnGenerator.GeneratePawn(xarka);
            GenSpawn.Spawn(pawn, loc, map, Rot4.Random);
            pawn.mindState.exitMapAfterTick = Find.TickManager.TicksGame + num2;
            if (invalid.IsValid)
            {
                pawn.mindState.forcedGotoPosition = CellFinder.RandomClosewalkCellNear(invalid, map, 10);
            }
        }

        Find.LetterStack.ReceiveLetter("LetterLabelXarkaPasses".Translate(xarka.label).CapitalizeFirst(),
            "LetterXarkaPasses".Translate(xarka.label), LetterDefOf.PositiveEvent, pawn);
        return true;
    }
}