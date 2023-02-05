using UnityEditor;
using UnityEngine;

    [CustomEditor(typeof(GameEvent_SO), editorForChildClasses: true)]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent_SO e = target as GameEvent_SO;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
