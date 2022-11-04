// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LTU_emiolo_1_4_V1Target : TargetRules
{
	public LTU_emiolo_1_4_V1Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LTU_emiolo_1_4_V1" } );
	}
}
