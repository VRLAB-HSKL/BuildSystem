using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEditor.PackageManager;
using UnityEngine;

public class PackageCleaner : EditorWindow
{
    static ResetToEditorDefaultsRequest resetRequest;

    [MenuItem("Window/PackageCleaner")]
    public static void ShowWindow()
    {
        GetWindow<PackageCleaner>("Package Cleaner");
    }

    private void OnGUI()
    {
        GUILayout.Label("Remove Non-Default-Packages", EditorStyles.boldLabel);

        if (GUILayout.Button("Reset Package Manager"))
        {
            ToDefault();
        }
    }

    static void ToDefault()
    {
        resetRequest = Client.ResetToEditorDefaults();
        EditorApplication.update += ProgressToDefault;
    }

    static void ProgressToDefault()
    {
        if (resetRequest.IsCompleted)
        {
            if (resetRequest.Status == StatusCode.Success)
                Debug.Log("Reset to default packages successful.");
            else if (resetRequest.Status >= StatusCode.Failure)
                Debug.Log(resetRequest.Error.message);

            EditorApplication.update -= ProgressToDefault;
        }
    }
}
