using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class DragDropSprite : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Camera mainCamera;

    private DropZone targetZone; // Nueva variable

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            offset = transform.position - mousePosition;
            isDragging = true;
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        if (targetZone)
        {
            transform.position = targetZone.GetDropPosition(); // Mueve el sprite a la posición del área
        }
    }

    // Nuevos métodos para manejar el área
    public void EnterDropZone(DropZone zone)
    {
        targetZone = zone;
    }

    public void ExitDropZone(DropZone zone)
    {
        if (targetZone == zone)
        {
            targetZone = null;
        }
    }
}
