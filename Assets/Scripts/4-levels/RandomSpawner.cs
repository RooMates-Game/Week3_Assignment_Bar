using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] GameObject targetObject; // Reference to the other GameObject
    [SerializeField] float exclusionRadius = 1f; // Radius to exclude around the target object
    void Start()
    {
        // Ensure the target object is assigned
        if (targetObject == null)
        {
            Debug.LogError("Target object is not assigned!");
            return;
        }

        // Get the camera's world boundaries
        Camera mainCamera = Camera.main;
        if (mainCamera == null) return;

        // Calculate the world bounds
        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        Vector3 targetPosition = targetObject.transform.position; // Position of the target object
        Vector3 newPosition;

        // Randomize position until it's outside the exclusion radius
        do
        {
            float x_axis = Random.Range(-cameraWidth / 2, cameraWidth / 2);
            float y_axis = Random.Range(-cameraHeight / 2, cameraHeight / 2);
            newPosition = new Vector3(x_axis, y_axis, 0);
        }
        while (Vector3.Distance(targetPosition, newPosition) < exclusionRadius);

        // Apply the new position
        transform.position = newPosition;
    }
}
