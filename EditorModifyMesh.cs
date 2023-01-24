using UnityEngine;
using UnityEditor;
using System.Linq;

public class EditorModifyMesh : EditorWindow
{
    [MenuItem("Tools/Mesh/FlipNormals")]
    static void FlipNormals()
    {
        Mesh oldMesh = Selection.activeObject as Mesh;

        oldMesh.triangles = oldMesh.triangles.Reverse().ToArray();
        oldMesh.RecalculateNormals();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Tools/Mesh/FlipNormals", true)]
    static bool DoSomethingValidation() => Selection.activeObject.GetType() == typeof(Mesh);
}
