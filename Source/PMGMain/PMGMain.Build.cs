// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PMGMain : ModuleRules
{
	public PMGMain(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"PMGMain/Public"
			}
		);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"PMGMain/Private"
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
