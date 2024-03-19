using UnityEngine;
using UnityEngine.EventSystems;

public class DeckSlots : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DragCards dragCards = dropped.GetComponent<DragCards>();
            dragCards.ParentAfterDrag = transform;
        }
    }
}
