// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LTU_emiolo_1_4_V1EditorTarget : TargetRules
{
	public LTU_emiolo_1_4_V1EditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "LTU_emiolo_1_4_V1" } );
	}
}
