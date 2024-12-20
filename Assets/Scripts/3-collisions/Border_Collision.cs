using UnityEngine;

public class Border_Collision : MonoBehaviour
{
    [SerializeField] string triggeringTag;

    [SerializeField] string whichBorder; // explain which border he collide with

    [SerializeField] float offset = 0.3f;  // Use a small offset to avoid immediate re-collision

    private void OnTriggerEnter2D(Collider2D other)
    {

        // Check if the colliding object's tag matches the triggering tag
        if (other.tag == triggeringTag)
        {
            float border_x = other.transform.position.x;
            float border_y = other.transform.position.y;


            switch (whichBorder)
            {
                case "left":
                    // Move to the right border, add an offset to avoid immediate re-collision
                    border_x = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - other.transform.localScale.x - offset;
                    break;

                case "right":
                    // Move to the left border, add an offset to avoid immediate re-collision
                    border_x = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + other.transform.localScale.x + offset;
                    break;

                case "top":
                    // stay at top border, add an offset to avoid immediate re-collision
                    border_y = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - other.transform.localScale.y - 3 * offset;
                    break;

                case "down":
                    // Move to the top border, add an offset to avoid immediate re-collision
                    border_y = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + other.transform.localScale.y + 3 * offset;
                    break;

                default:
                    Debug.LogWarning("Invalid border type.");
                    break;
            }

            Debug.Log("Collision detected - border");

            // Move spaceship to the left border while keeping y the same and z at 0
            other.transform.position = new Vector3(border_x, border_y, 0);

        }
    }

}
