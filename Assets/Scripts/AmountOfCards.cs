using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmountOfCards : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _totalInDeck;
    [SerializeField] private TextMeshProUGUI _discardTotal;

    [HideInInspector] public int AmountInDeck = 5;
    [HideInInspector] public int DiscardedAmount = 0;

    void Update()
    {
        _totalInDeck.text = AmountInDeck.ToString();
        _discardTotal.text = DiscardedAmount.ToString();

        if (AmountInDeck <= 0)
        {
            _totalInDeck.text = "0";
        }

        //When discard pile reshuffle, set DiscardedAmount back to 0
    }
}
