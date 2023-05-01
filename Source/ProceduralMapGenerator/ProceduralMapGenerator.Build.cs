// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProceduralMapGenerator : ModuleRules
{
	public ProceduralMapGenerator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"ProceduralMapGenerator/Public"
			}
		);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"ProceduralMapGenerator/Private"
			}
		);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core"
			}
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine"
			}
		);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// List of modules dynamically loaded
			}
		);
	}
}
