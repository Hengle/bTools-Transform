using UnityEditor;

namespace bTools.TransformComponent
{
    [CustomEditor(typeof(ObjectData))]
    public class ObjectDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox("Used by bTools Transform to store transform snapshots of this GameObject", MessageType.Info);
        }
    }
}