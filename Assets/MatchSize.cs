using UnityEngine;

[ExecuteInEditMode]
public class MatchCanvasToMesh : MonoBehaviour
{
    // The rectangular mesh GameObject that the canvas will match.
    public GameObject targetGameObject;

    private RectTransform canvasRectTransform;
    private Renderer targetRenderer;

    void Start()
    {
        canvasRectTransform = GetComponent<RectTransform>();

        if (targetGameObject == null)
        {
            Debug.LogError("Target GameObject not assigned.");
            enabled = false;
            return;
        }

        targetRenderer = targetGameObject.GetComponent<Renderer>();
        if (targetRenderer == null)
        {
            Debug.LogError("Target GameObject must have a Renderer component (e.g., MeshRenderer).");
            enabled = false;
        }
    }

    void Update()
    {
        // Check if all necessary components are available.
        if (targetRenderer != null && canvasRectTransform != null)
        {
            // Get the world-space size of the target GameObject's bounds.
            Vector3 targetSize = targetRenderer.bounds.size;

            // Set the Canvas RectTransform's size to match the object's dimensions.
            // A higher number makes the canvas appear smaller relative to the world.
            float scaleFactor = 1f; // Adjust this value to fine-tune canvas resolution.
            canvasRectTransform.sizeDelta = new Vector2(targetSize.x * scaleFactor, targetSize.y * scaleFactor);

            // Set the Canvas's position to be aligned with the mesh.
            // You may need to adjust the position offset based on your pivot.
            canvasRectTransform.position = targetRenderer.bounds.center;

            // Optional: Rotate the canvas to match the mesh's rotation.
            canvasRectTransform.rotation = targetGameObject.transform.rotation;
        }
    }
}
