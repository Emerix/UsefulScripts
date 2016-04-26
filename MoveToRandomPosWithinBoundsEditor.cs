using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(MoveToRandomPosWithinBounds))]
public class MoveToRandomPosWithinBoundsEditor : UnityEditor.Editor {

    public override void OnInspectorGUI()
    {
        base.DrawDefaultInspector();
        MoveToRandomPosWithinBounds myScript = (MoveToRandomPosWithinBounds)target;
        if (GUILayout.Button("Refresh Startpos"))
        {
            myScript.RefreshStartPos();
        }
    }
}
