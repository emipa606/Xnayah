# GitHub Copilot Instructions for RimWorld Mod: Xarka Pass Mod

## Mod Overview and Purpose

The Xarka Pass Mod is designed for the game RimWorld, providing a new gameplay feature that introduces a unique incident known as "Xarka Pass." This incident enhances the game by adding diversity to the herd migration events, giving players new challenges and opportunities in managing and interacting with the in-game ecosystem.

## Key Features and Systems

- **New Incident: Xarka Pass**
  - Extends the existing herd migration events with specific behaviors unique to the Xarka creature.
  - Adjusts in-game dynamics by providing different herd interactions and potential benefits or challenges.

- **Custom Creature Definitions**
  - Additional creatures defined through `PawnKindDefOf`, providing the foundation to spawn and manage new lifeforms in the game.

## Coding Patterns and Conventions

- **C# Coding Standards**
  - Use PascalCase for class names and method names as seen in `IncidentWorker_XarkaPass` and `PawnKindDefOf`.
  - Use clear and descriptive names for classes and methods to maintain readability and maintainability.

- **File Organization**
  - Separate assembly attribute files to handle versioning across different .NET Framework versions (.NETFramework,Version=v4.7.2 and v4.8).
  - Group temporary generated files to prevent pollution of the core codebase.

## XML Integration

- **PawnKindDef Integration**
  - Utilize XML files to define new creatures and their properties such as stats, appearance, and behavior.
  - Ensure XML definitions are referenced correctly in C# code to seamlessly integrate with the game's mechanics.

## Harmony Patching

- **Harmony Framework**
  - Prepare for dynamic feature adjustments using Harmony patches.
  - Ensure patches are well-documented and segregated by functionality to avoid conflicts with other mods.
  - Anticipate future expansions or changes by designing patches to be easily extendable.

## Suggestions for Copilot

- **Code Completion for Incident Logic**
  - Use Copilot to suggest code blocks when extending incident logic, focusing on conditional checks that determine when the "Xarka Pass" incident should occur.
  
- **XML Definition Assistance**
  - Leverage Copilot to assist in bulk template generation for XML creature definitions, ensuring consistency in properties setup.

- **Refactor Suggestions**
  - Allow Copilot to suggest refactoring opportunities in class design or method extraction, promoting cleaner and more efficient code.
  
- **Harmony Patch Guidance**
  - Use Copilot to explore potential Harmony patching opportunities, including suggestions on hooked methods or best practices in compatibility settings.

By following these guidelines, contributors to the Xarka Pass Mod can maintain a clean, efficient, and engaging development environment while delivering compelling content to players.
