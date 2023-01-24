using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using UnityEditor.PackageManager.UI;

public class EditorModifyMesh : EditorWindow
{
    [MenuItem("Tools/Mesh/FlipNormals")]
    static void FlipNormals()
    {
        Mesh oldMesh = Selection.activeObject as Mesh;

        //Flips Normals
        oldMesh.triangles = oldMesh.triangles.Reverse().ToArray();
        oldMesh.RecalculateNormals();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/Mesh/FlipNormals", true)]
    static bool DoSomethingValidation() => Selection.activeObject.GetType() == typeof(Mesh);
}
