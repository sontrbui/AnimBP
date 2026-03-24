// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AnimBP : ModuleRules
{
	public AnimBP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AnimBP",
			"AnimBP/Variant_Platforming",
			"AnimBP/Variant_Platforming/Animation",
			"AnimBP/Variant_Combat",
			"AnimBP/Variant_Combat/AI",
			"AnimBP/Variant_Combat/Animation",
			"AnimBP/Variant_Combat/Gameplay",
			"AnimBP/Variant_Combat/Interfaces",
			"AnimBP/Variant_Combat/UI",
			"AnimBP/Variant_SideScrolling",
			"AnimBP/Variant_SideScrolling/AI",
			"AnimBP/Variant_SideScrolling/Gameplay",
			"AnimBP/Variant_SideScrolling/Interfaces",
			"AnimBP/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
