using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour
{
    [SerializeField] private AICastSpells _spells;
    [SerializeField] private TurnManager _turn;

    [SerializeField] private GameObject _NumberOne;
    [SerializeField] private GameObject _NumberTwo;
    [SerializeField] private GameObject _NumberThree;
    [SerializeField] private GameObject _NumberFour;
    [SerializeField] private GameObject _NumberFive;

    public int CurrentMana;

    private int _maxMana = 5;

    private void Awake()
    {
        CurrentMana = _maxMana;
    }

    void Update()
    {
        if (CurrentMana >= 5)
        {
            _NumberOne.SetActive(false);
            _NumberTwo.SetActive(false);
            _NumberThree.SetActive(false);
            _NumberFour.SetActive(false);
            _NumberFive.SetActive(true);
        }

        if (CurrentMana == 4)
        {
            _NumberOne.SetActive(false);
            _NumberTwo.SetActive(false);
            _NumberThree.SetActive(false);
            _NumberFour.SetActive(true);
            _NumberFive.SetActive(false);
        }

        if (CurrentMana == 3)
        {
            _NumberOne.SetActive(false);
            _NumberTwo.SetActive(false);
            _NumberThree.SetActive(true);
            _NumberFour.SetActive(false);
            _NumberFive.SetActive(false);
        }

        if (CurrentMana == 2)
        {
            _NumberOne.SetActive(false);
            _NumberTwo.SetActive(true);
            _NumberThree.SetActive(false);
            _NumberFour.SetActive(false);
            _NumberFive.SetActive(false);
        }

        if (CurrentMana == 1)
        {
            _NumberOne.SetActive(true);
            _NumberTwo.SetActive(false);
            _NumberThree.SetActive(false);
            _NumberFour.SetActive(false);
            _NumberFive.SetActive(false);
        }

        if (CurrentMana <= 0)
        {
            _NumberOne.SetActive(false);
            _NumberTwo.SetActive(false);
            _NumberThree.SetActive(false);
            _NumberFour.SetActive(false);
            _NumberFive.SetActive(false);
        }
    }

    public void RechargeMana()
    {
        CurrentMana = _maxMana;
        _spells.AiShootSpell = true;
        _turn.IsTurnDone = false;
    }
}
