using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private SaveTheDeck _saveTheDeck;
    [SerializeField] private ManaManager _manaManager;
    [SerializeField] private AmountOfCards _amountOfCards;
    [SerializeField] private TurnManager _turnManager;
    [SerializeField] private AICastSpells _aiCastSpells;

    [SerializeField] private GraphicRaycaster _graphicRaycaster;
    [SerializeField] private EventSystem _eventSystem;
    [SerializeField] private RectTransform _canvasRect;
    private PointerEventData _pointerEventData;
    private List<RaycastResult> _results;

    [HideInInspector] public bool UseBurnToss, UseHeatHeal, UseFlameOn, UseFireWall, UseStygian,
        UseDirtChuk, UseLifeSeed, UseEnsnare, UseMudslide, UseGaiaBash,
        UseVoltFling, UseReShock, UseAmpulse, UseDigiNet, UseGalvanize,
        UseChillShard, UseRefresh, UseFrozone, UseTsunami, UseGlaciate = false;

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

        if (_results.Count > 0 && Input.GetMouseButtonDown(1) && SceneManager.GetActiveScene().buildIndex == 0)
        {
            DragCards dragCards = _results[0].gameObject.GetComponent<DragCards>();
            if (dragCards.Draged)
            {
                if (_results[0].gameObject.name == "BurnToss" ||
                _results[0].gameObject.name == "HeatHeal" ||
                _results[0].gameObject.name == "FlameOn" ||
                _results[0].gameObject.name == "FireWall" ||
                _results[0].gameObject.name == "Stygian" ||
                _results[0].gameObject.name == "DirtChuk" ||
                _results[0].gameObject.name == "LifeSeed" ||
                _results[0].gameObject.name == "Ensnare" ||
                _results[0].gameObject.name == "Mudslide" ||
                _results[0].gameObject.name == "GaiaBash" ||
                _results[0].gameObject.name == "VoltFling" ||
                _results[0].gameObject.name == "ReShock" ||
                _results[0].gameObject.name == "Ampulse" ||
                _results[0].gameObject.name == "DigiNet" ||
                _results[0].gameObject.name == "Galvaniz" ||
                _results[0].gameObject.name == "ChillShard" ||
                _results[0].gameObject.name == "Refresh" ||
                _results[0].gameObject.name == "Frozone" ||
                _results[0].gameObject.name == "Tsunami" ||
                _results[0].gameObject.name == "Glaciate")
                {
                    BackToOriginalPos();
                }
            }
            else
            {
                if (_results[0].gameObject.name == "BurnToss(Clone)" ||
                _results[0].gameObject.name == "HeatHeal(Clone)" ||
                _results[0].gameObject.name == "FlameOn(Clone)" ||
                _results[0].gameObject.name == "FireWall(Clone)" ||
                _results[0].gameObject.name == "Stygian(Clone)" ||
                _results[0].gameObject.name == "DirtChuk(Clone)" ||
                _results[0].gameObject.name == "LifeSeed(Clone)" ||
                _results[0].gameObject.name == "Ensnare(Clone)" ||
                _results[0].gameObject.name == "Mudslide(Clone)" ||
                _results[0].gameObject.name == "GaiaBash(Clone)" ||
                _results[0].gameObject.name == "VoltFling(Clone)" ||
                _results[0].gameObject.name == "ReShock(Clone)" ||
                _results[0].gameObject.name == "Ampulse(Clone)" ||
                _results[0].gameObject.name == "DigiNet(Clone)" ||
                _results[0].gameObject.name == "Galvaniz(Clone)" ||
                _results[0].gameObject.name == "ChillShard(Clone)" ||
                _results[0].gameObject.name == "Refresh(Clone)" ||
                _results[0].gameObject.name == "Frozone(Clone)" ||
                _results[0].gameObject.name == "Tsunami(Clone)" ||
                _results[0].gameObject.name == "Glaciate(Clone)")
                {
                    BackToOriginalPos();
                }
            }
        }

        if (_results.Count > 0 && Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (_results[0].gameObject.name == "BurnToss(Clone)" && _manaManager.CurrentMana >= 1 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana--;
                CardStackNumbers();
                UseBurnToss = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "HeatHeal(Clone)" && _manaManager.CurrentMana >= 2 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 2;
                CardStackNumbers();
                UseHeatHeal = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "FlameOn(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseFlameOn = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "FireWall(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseFireWall = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Stygian(Clone)" && _manaManager.CurrentMana >= 4 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 4;
                CardStackNumbers();
                UseStygian = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "DirtChuck(Clone)" && _manaManager.CurrentMana >= 1 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana--;
                CardStackNumbers();
                UseDirtChuk = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "LifeSeed(Clone)" && _manaManager.CurrentMana >= 2 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 2;
                CardStackNumbers();
                UseLifeSeed = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Ensnare(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseEnsnare = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Mudslide(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseMudslide = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "GaiaBash(Clone)" && _manaManager.CurrentMana >= 4 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 4;
                CardStackNumbers();
                UseGaiaBash = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "VoltFling(Clone)" && _manaManager.CurrentMana >= 1 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana--;
                CardStackNumbers();
                UseVoltFling = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "ReShock(Clone)" && _manaManager.CurrentMana >= 2 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 2;
                CardStackNumbers();
                UseReShock = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Ampulse(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseAmpulse = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "DigiNet(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseDigiNet = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Galvaniz(Clone)" && _manaManager.CurrentMana >= 4 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 4;
                CardStackNumbers();
                UseGalvanize = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "ChillShard(Clone)" && _manaManager.CurrentMana >= 1 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana--;
                CardStackNumbers();
                UseChillShard = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Refresh(Clone)" && _manaManager.CurrentMana >= 2 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 2;
                CardStackNumbers();
                UseRefresh = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Frozone(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseFrozone = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Tsunami(Clone)" && _manaManager.CurrentMana >= 3 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 3;
                CardStackNumbers();
                UseTsunami = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }

            if (_results[0].gameObject.name == "Glaciate(Clone)" && _manaManager.CurrentMana >= 4 && _turnManager.IsTurnDone == true)
            {
                _manaManager.CurrentMana -= 4;
                CardStackNumbers();
                UseGlaciate = true;
                _aiCastSpells.AiShootSpell = true;
                MoveToDiscard();
                _turnManager.IsTurnDone = false;
            }
        }
    }

    private void BackToOriginalPos()
    {
        DragCards dragCards = _results[0].gameObject.GetComponent<DragCards>();
        _results[0].gameObject.transform.SetParent(dragCards.OriginalPosition);
    }

    private void MoveToDiscard()
    {
        GameObject randomDiscardSlot = _saveTheDeck.DiscardSlots[Random.Range(0, _saveTheDeck.DiscardSlots.Count)];
        if (randomDiscardSlot.transform.childCount >= 1)
        {
            randomDiscardSlot = _saveTheDeck.DiscardSlots[Random.Range(0, _saveTheDeck.DiscardSlots.Count)];
        }
        _results[0].gameObject.transform.SetParent(randomDiscardSlot.transform);
    }

    private void CardStackNumbers()
    {
        _amountOfCards.AmountInDeck--;
        _amountOfCards.DiscardedAmount++;
    }
}