using UnityEngine;

public class Resize : MonoBehaviour
{
    [SerializeField] string triggeringTag;

    [SerializeField] float resizeFactor = 2f; // factor of resize 

    [SerializeField] float duration = 5f; //duration of the buff
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggeringTag))
        {
            // Store the original size
            Vector3 originalSize = transform.localScale;

            // Shrink the object
            if (triggeringTag == "Shrinking")
            {
                transform.localScale = originalSize / resizeFactor;
            }
            //Enlarge the object
            if (triggeringTag == "Enlargment")
            {
                transform.localScale = originalSize * resizeFactor;
            }

            // Start the coroutine to reset the size after 5 seconds
            StartCoroutine(ResetSizeAfterDelay(originalSize, duration));

            // Destroy the other object
            Destroy(other.gameObject);
        }
    }

    //after 3 seconds , return to original size
    private System.Collections.IEnumerator ResetSizeAfterDelay(Vector3 originalSize, float delay)
    {
        yield return new WaitForSeconds(delay);
        transform.localScale = originalSize;
    }
}
