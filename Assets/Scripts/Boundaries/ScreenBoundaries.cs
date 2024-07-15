using UnityEngine;

public class ScreenBoundaries : MonoBehaviour
{
    public float colliderThickness = 1f; 
    public float offset = 0.5f; 

    void Start()
    {
        AddBoundaryColliders();
    }

    private void AddBoundaryColliders()
    {
        Vector2 lowerLeftCorner = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
        Vector2 upperRightCorner = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        // Top boundary
        AddColliderHorizontally(lowerLeftCorner.x, upperRightCorner.x, upperRightCorner.y + offset);
        // Bottom boundary
        AddColliderHorizontally(lowerLeftCorner.x, upperRightCorner.x, lowerLeftCorner.y - offset);
        // Left boundary
        AddColliderVertically(lowerLeftCorner.y, upperRightCorner.y, lowerLeftCorner.x - offset);
        // Right boundary
        AddColliderVertically(lowerLeftCorner.y, upperRightCorner.y, upperRightCorner.x + offset);
    }

    private void AddColliderHorizontally(float startX, float endX, float positionY)
    {
        GameObject boundary = new GameObject("HorizontalBoundary");
        boundary.transform.position = new Vector3((startX + endX) / 2, positionY, 0);
        boundary.transform.parent = transform;
        BoxCollider2D collider = boundary.AddComponent<BoxCollider2D>();
        collider.size = new Vector2(endX - startX + offset, colliderThickness);
        collider.isTrigger = true;
    }

    private void AddColliderVertically(float startY, float endY, float positionX)
    {
        GameObject boundary = new GameObject("VerticalBoundary");
        boundary.transform.position = new Vector3(positionX, (startY + endY) / 2, 0);
        boundary.transform.parent = transform;
        BoxCollider2D collider = boundary.AddComponent<BoxCollider2D>();
        collider.size = new Vector2(colliderThickness, endY - startY + offset);
        collider.isTrigger = true; 
    }
}