// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PMGInfrastructure : ModuleRules
{
	public PMGInfrastructure(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"PMGInfrastructure/Private"
			}
		);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"PMGInfrastructure/Public"
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
