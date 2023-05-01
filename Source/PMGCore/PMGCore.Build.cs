// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PMGCore : ModuleRules
{
	public PMGCore(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"PMGCore/Public"
			}
		);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"PMGCore/Private"
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
