// Just drag this file in the Assets directory of your Unity project to install 
// It will add the group of package to the package manager to be ready to use
// Go to RE Hack Filter in the package manager to import the demo.
// To work you need Re-Hack Runtime and Restream outside of Unity.
//https://eloistree.itch.io/rehack
#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;
// Just drag and drop this file in your asset folder in unity to install
public class MultiplatformFileSaveUtility : MonoBehaviour
{
    public static PackageValue[] m_wantedDependencies = new PackageValue[] {
    new PackageValue("be.eloistree.unitydirectorystorageutility","https://gitlab.com/eloistree/2020_04_28_UnityDirectoryStorageUtility"),
    new PackageValue("be.eloistree.license","https://github.com/EloiStree/GeneralLicense.git")
    };

    private static void WhatToDoWhenDrop()
    {

        string manifestPath = Application.dataPath + "/../Packages/manifest.json";
        string packageFile = File.ReadAllText(manifestPath);
        string packageToAdd = "";
        for (int i = 0; i < m_wantedDependencies.Length; i++)
        {
            string toAdd = string.Format("\"{0}\": \"{1}\"", m_wantedDependencies[i].m_id, m_wantedDependencies[i].m_version);
            if (packageFile.IndexOf(toAdd) < 0)
            {
                packageToAdd = string.Format("\n     {0}, ", toAdd);
                packageFile = packageFile.Replace("\"dependencies\": {", "\"dependencies\": {" + packageToAdd);
            }
        }

        File.WriteAllText(manifestPath, packageFile);
        AssetDatabase.Refresh();

    }
    
    public class PackageValue
    {
        public string m_id = "";
        public string m_version = "0.0.1";

        public PackageValue(string id, string version)
        {
            this.m_id = id;
            this.m_version = version;
        }
    }

    #region GRENADE SCRIPT
    public static bool m_deleteAfterUse = false;
    [UnityEditor.Callbacks.DidReloadScripts]
    private static void OnScriptsReloaded()
    {
        if (IsFileAtProjectRoot())
        {
            Debug.Log("> BOOM : " + GetFileName());
            WhatToDoWhenDrop();
            if (m_deleteAfterUse)
            {
                File.Delete(GetFilePath());
            }
            else
            {
                string filePath = GetFilePath();
                string dir = Application.dataPath + "/GrenadeScripts/Used";
                Directory.CreateDirectory(dir);
                File.Move(filePath, dir + "/" + GetFileName());
                AssetDatabase.Refresh();
            }
        }
    }
    private static bool IsFileAtProjectRoot()
    {
        return File.Exists(Application.dataPath + "/" + GetFileName());
    }

    private static string GetFileName()
    {
        return Path.GetFileName(new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName());
    }
    private static string GetFilePath()
    {
        return new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
    }
    #endregion
}
#endif
