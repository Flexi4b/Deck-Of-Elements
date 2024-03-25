using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualSpellCards : MonoBehaviour
{
    [SerializeField] private SpellCardsData _spellCardsData = null;

    void Start()
    {
        if (_spellCardsData == null)
        {
            return;
        }

        Instantiate(_spellCardsData.GetEmptyCard);

        //Debug.Log(_spellCardsData.GetCardName + _spellCardsData.GetCardDiscription + _spellCardsData.GetManaCount);
    }
}
