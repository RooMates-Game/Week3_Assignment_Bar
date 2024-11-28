using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] string triggeringTag;
        private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag(triggeringTag)) {
            // Store the original size
            Vector3 originalSize = transform.localScale;

            // Shrink the object
            if(triggeringTag == "Shrinking")
            {
                transform.localScale = originalSize / 2;
            }
            //Enlarge the object
            if(triggeringTag == "Enlargment")
            {
                transform.localScale = originalSize * 2;
            }

            // Start the coroutine to reset the size after 5 seconds
            StartCoroutine(ResetSizeAfterDelay(originalSize, 5f));

            // Destroy the other object
            Destroy(other.gameObject);
        }
    }

    //after 3 seconds , return to original size
    private System.Collections.IEnumerator ResetSizeAfterDelay(Vector3 originalSize, float delay) {
        yield return new WaitForSeconds(delay);
        transform.localScale = originalSize;
    }
}
