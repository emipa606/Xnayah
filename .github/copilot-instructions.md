# GitHub Copilot Instructions for Xnayah (Continued) Mod

## Mod Overview and Purpose

The Xnayah (Continued) mod is an update and continuation of Maartens mod, adding a new alien race called the Xar along with unique creatures, materials, buildings, and research options to the RimWorld game. The mod introduces intelligent and non-intelligent Xar subspecies, new materials like XayBlocks/Bricks, and a powerful turret named XarTurret. Future updates will include more events, buildings, and unique mechanics.

## Key Features and Systems

### New Race: Xar
- Intelligent and non-intelligent subspecies
- Intelligent Xar will try to destroy players
- Non-intelligent Xar act like normal animals

### New Creatures
- **Xnayah Spider**: Infests mechs and creatures, laying eggs and reproducing
- **Xarka**: Furry warg-like creature, passive and tamed easily

### New Materials
- **XayBlocks/Bricks**: Produced from Xnayah-infested chunks

### New Buildings
- **XarTurret**: Powerful turret with increased hitpoints and damage, requires XarTech research

### New Research
- **XarTech**: Research subtree for unlocking XarTurret and other future Xar-related buildings

### New Events
- **Xarka Wandering Event**: Xarkas wander into the area
- Future events involving Xnayah infestation and Xar base building

## Coding Patterns and Conventions

### XML Integration
- XML files are used to define various aspects of the mod, including research projects, thing definitions, terrain definitions, and more.
- Follow the existing XML structure and conventions to ensure compatibility and maintainability.

### Harmony Patching
- Use Harmony to patch existing RimWorld code to add new features or modify existing behavior.
- Ensure that patches are clean, efficient, and well-documented.

## Suggestions for Copilot

### XML Definitions
- When creating new XML definitions, use Copilot to generate a basic structure based on existing XML files.
- For example, to create a new `ThingDef`, you can use the following template:
  xml
  <ThingDef Name="XnayahSpider" ParentName="InsectBase">
    <defName>XnayahSpider</defName>
    <label>Xnayah Spider</label>
    <description>A dangerous infesting creature.</description>
    <category>Alien</category>
    <statBases>
      <baseMarketValue>10</baseMarketValue>
      <moveSpeed>0.5</moveSpeed>
    </statBases>
    <comps>
      <li Class="CompProperties_Food">
        <edibility>VeryBadHumanlikes</edibility>
      </li>
    </comps>
  </ThingDef>
  

### Harmony Patches
- Use Copilot to generate Harmony patches for existing RimWorld code.
- For example, to patch a method that needs to be modified, you can use the following template:
  csharp
  [HarmonyPatch(typeof(OriginalClass), "OriginalMethod")]
  public static class Patch_OriginalClass_OriginalMethod
  {
      [HarmonyPostfix]
      public static void Postfix(ref SomeType __result)
      {
          // Add custom logic here
      }
  }
  

### C# Coding
- Use Copilot to generate C# code for new classes, methods, and event handlers.
- For example, to create a new incident worker, you can use the following template:
  csharp
  using RimWorld;
  using Verse;

  namespace Xnayah
  {
      public class IncidentWorker_XarkaPass : IncidentWorker
      {
          protected override bool TryExecuteWorker(IncidentParms parms)
          {
              Map map = (Map)parms.target;
              IntVec3 spawnPoint = CellFinder.RandomSpawnCellForPawnNear(parms.targetSpot, map, 10);
              Pawn xarka = PawnGenerator.GeneratePawn(PawnKindDefOf.Xarka, map.faction);
              GenSpawn.Spawn(xarka, spawnPoint, map);
              return true;
          }
      }
  }
  

By following these guidelines and using Copilot to generate code snippets, you can efficiently develop and maintain the Xnayah (Continued) mod for RimWorld.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

