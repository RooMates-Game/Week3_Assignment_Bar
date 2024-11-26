using UnityEngine;

public class shrinking : MonoBehaviour
{
    [SerializeField] string triggeringTag;

        private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(triggeringTag)) {
            // Store the original size
            Vector3 originalSize = transform.localScale;

            // Shrink the object
            transform.localScale = originalSize / 2;

            // Start the coroutine to reset the size after 5 seconds
            StartCoroutine(ResetSizeAfterDelay(originalSize, 5f));

            // Destroy the other object
            Destroy(other.gameObject);
        }
    }

    private System.Collections.IEnumerator ResetSizeAfterDelay(Vector3 originalSize, float delay) {
        yield return new WaitForSeconds(delay);
        transform.localScale = originalSize;
    }
}
