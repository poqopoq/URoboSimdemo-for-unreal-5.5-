// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class DemoProjectEditorTarget : TargetRules
{
	public DemoProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		#if UE_5_5_OR_LATER
		DefaultBuildSettings = BuildSettingsVersion.V5;
		#else
		DefaultBuildSettings = BuildSettingsVersion.V2;
		#endif
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "DemoProject" } );
	}
}
