// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PMGGenerator : ModuleRules
{
	public PMGGenerator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"PMGGenerator/Public"
			}
		);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"PMGGenerator/Private"
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
