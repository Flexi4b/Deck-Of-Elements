using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragCards : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image _image;
    [HideInInspector] public Transform ParentAfterDrag;
    [HideInInspector] public Transform OriginalPosition;
    [HideInInspector] public bool Draged = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        OriginalPosition = transform.parent;
        ParentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        Draged = true;
        _image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(ParentAfterDrag);
        _image.raycastTarget = true;
    }
}
