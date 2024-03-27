using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private SaveTheDeck _saveTheDeck;

    [SerializeField] private GraphicRaycaster _graphicRaycaster;
    [SerializeField] private EventSystem _eventSystem;
    [SerializeField] private RectTransform _canvasRect;
    private PointerEventData _pointerEventData;
    private List<RaycastResult> _results;

    void Update()
    {
        //Set up the new Pointer Event
        _pointerEventData = new PointerEventData(_eventSystem);
        //Set the Pointer Event Position to that of the game object
        _pointerEventData.position = Input.mousePosition;

        //Create a list of Raycast Results
        _results = new();

        //Raycast using the Graphics Raycaster and mouse click position
        _graphicRaycaster.Raycast(_pointerEventData, _results);

        if (_results.Count > 0 && Input.GetMouseButtonDown(1))
        {
            if (_results[0].gameObject.name == "BurnToss" ||
                _results[0].gameObject.name == "HeatHeal" ||
                _results[0].gameObject.name == "FlameOn" ||
                _results[0].gameObject.name == "FireWall" ||
                _results[0].gameObject.name == "Stygian" ||
                _results[0].gameObject.name == "DirtChuk" ||
                _results[0].gameObject.name == "VoltFling" ||
                _results[0].gameObject.name == "ChillShard" ||
                _results[0].gameObject.name == "BurnToss(Clone)" ||
                _results[0].gameObject.name == "HeatHeal(Clone)" ||
                _results[0].gameObject.name == "FlameOn(Clone)" ||
                _results[0].gameObject.name == "FireWall(Clone)" ||
                _results[0].gameObject.name == "Stygian(Clone)" ||
                _results[0].gameObject.name == "DirtChuk(Clone)" ||
                _results[0].gameObject.name == "VoltFling(Clone)" ||
                _results[0].gameObject.name == "ChillShard(Clone)")
            {
                BackToOriginalPos();
            }
        }
    }

    private void BackToOriginalPos()
    {
        DragCards dragCards = _results[0].gameObject.GetComponent<DragCards>();
        _results[0].gameObject.transform.SetParent(dragCards.OriginalPosition);
    }
}