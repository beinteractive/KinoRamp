﻿using UnityEngine;
using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
        AssetDatabase.ExportPackage("Assets/Kino", "KinoRamp.unitypackage", ExportPackageOptions.Recurse);
    }
}
