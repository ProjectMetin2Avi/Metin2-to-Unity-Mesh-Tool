using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class SkinnedMeshToColliderTool : EditorWindow
{
    [Header("Social Links")]
    [SerializeField] private string iconsFolderPath = "Assets/Tools/Icons";
    [SerializeField] private Texture2D GitHubIcon;
    [SerializeField] private Texture2D InstagramIcon;
    [SerializeField] private Texture2D DiscordIcon;
    [SerializeField] private Texture2D YouTubeIcon;
    [SerializeField] private Texture2D Metin2DownloadsIcon;
    [SerializeField] private Texture2D M2DevIcon;
    [SerializeField] private Texture2D TurkmmoIcon;
    private readonly string GitHubURL = "https://github.com/ProjectMetin2Avi";
    private readonly string instagramURL = "https://www.instagram.com/metin2.avi/";
    private readonly string discordURL = "https://discord.gg/WZMzMgPp38";
    private readonly string youtubeURL = "https://www.youtube.com/@project_avi";
    private readonly string Metin2DownloadsURL = "https://www.metin2downloads.to/cms/user/30621-metin2avi/";
    private readonly string M2DevURL = "https://metin2.dev/profile/53064-metin2avi/";
    private readonly string TurkmmoURL = "https://forum.turkmmo.com/uye/165187-trmove/";

    [MenuItem("Tools/Skinned Mesh To Collider Tool  - @Metin2Avi")]
    public static void ShowWindow()
    {
        GetWindow<SkinnedMeshToColliderTool>("Skinned Mesh To Collider Tool  - @Metin2Avi");
    }

    private void OnGUI()
    {
        DrawSocialLinks();
        GUILayout.Label("Skinned Mesh To Collider Tool  - @Metin2Avi", EditorStyles.boldLabel);

        if (GUILayout.Button("Add Mesh Colliders"))
        {
            AddMeshCollidersToSkinnedMeshes();
        }
    }

    private void DrawSocialLinks()
    {
        EditorGUILayout.Space(20);
        GUILayout.Label("Follow/Contact", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        if (DiscordIcon && GUILayout.Button(new GUIContent(GitHubIcon, "GitHub"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(GitHubURL);

        if (DiscordIcon && GUILayout.Button(new GUIContent(InstagramIcon, "Instagram"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(instagramURL);

        if (DiscordIcon && GUILayout.Button(new GUIContent(DiscordIcon, "Discord"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(discordURL);

        if (YouTubeIcon && GUILayout.Button(new GUIContent(YouTubeIcon, "YouTube"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(youtubeURL);

        if (Metin2DownloadsIcon && GUILayout.Button(new GUIContent(Metin2DownloadsIcon, "Metin2Downloads"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(Metin2DownloadsURL);

        if (M2DevIcon && GUILayout.Button(new GUIContent(M2DevIcon, "M2Dev"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(M2DevURL);

        if (TurkmmoIcon && GUILayout.Button(new GUIContent(TurkmmoIcon, "Turkmmo"), GUILayout.Width(40), GUILayout.Height(40)))
            Application.OpenURL(TurkmmoURL);

        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    private void AddMeshCollidersToSkinnedMeshes()
    {
        // Find all SkinnedMeshRenderer objects in the scene
        SkinnedMeshRenderer[] skinnedMeshRenderers = FindObjectsOfType<SkinnedMeshRenderer>();

        if (skinnedMeshRenderers.Length == 0)
        {
            EditorUtility.DisplayDialog("No Skinned Meshes Found", "No objects with SkinnedMeshRenderer component were found in the scene.", "OK");
            return;
        }

        List<GameObject> processedObjects = new List<GameObject>();

        foreach (SkinnedMeshRenderer smr in skinnedMeshRenderers)
        {
            GameObject obj = smr.gameObject;

            // Skip if already processed
            if (processedObjects.Contains(obj))
                continue;

            processedObjects.Add(obj);

            // Check if object already has a MeshCollider
            MeshCollider existingCollider = obj.GetComponent<MeshCollider>();

            if (existingCollider == null)
            {
                // Add new MeshCollider
                MeshCollider meshCollider = Undo.AddComponent<MeshCollider>(obj);

                // Create a new mesh from the skinned mesh
                Mesh colliderMesh = new Mesh();
                smr.BakeMesh(colliderMesh);

                // Assign the mesh to the collider
                meshCollider.sharedMesh = colliderMesh;

                Debug.Log($"Added MeshCollider to: {obj.name}");
            }
            else
            {
                // If MeshCollider already exists, just update its mesh
                Mesh colliderMesh = new Mesh();
                smr.BakeMesh(colliderMesh);

                existingCollider.sharedMesh = colliderMesh;

                Debug.Log($"Updated existing MeshCollider on: {obj.name}");
            }
        }

        EditorUtility.DisplayDialog("Process Complete",
            $"Added/Updated MeshColliders on {processedObjects.Count} objects with SkinnedMeshRenderer components.", "OK");
    }
}
