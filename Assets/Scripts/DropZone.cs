using UnityEngine;

[RequireComponent(typeof(Collider2D))] // Asume que estás usando Collider2D para juegos 2D
public class DropZone : MonoBehaviour
{
    public Vector3 dropPositionOffset = Vector3.zero; // Puedes usar esto para ajustar la posición exacta dentro de la zona donde se coloca el sprite

    private void OnTriggerEnter2D(Collider2D other)
    {
        DragDropSprite sprite = other.GetComponent<DragDropSprite>();
        if (sprite)
        {
            sprite.EnterDropZone(this);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        DragDropSprite sprite = other.GetComponent<DragDropSprite>();
        if (sprite)
        {
            sprite.ExitDropZone(this);
        }
    }

    public Vector3 GetDropPosition()
    {
        return transform.position + dropPositionOffset;
    }
}
