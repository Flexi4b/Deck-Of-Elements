using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTheDeck : MonoBehaviour
{
    public List<GameObject> DeckSlots = new();

    public List<GameObject> CardsInDeck = new();

    public List<GameObject> DiscardSlots = new();

    public Cards CardDatabase;

    private void Awake()
    {
        LoadDeckList();
    }

    void Update()
    {
        foreach (GameObject slot in DeckSlots)
        {
            DeckSlots deckSlots = slot.GetComponent<DeckSlots>();
            if (deckSlots.CardSelected == true)
            {
                Transform child = slot.transform.GetChild(0);

                if (!CardsInDeck.Contains(child.gameObject))
                    CardsInDeck.Add(child.gameObject);
                
                SaveDeckList();
                deckSlots.CardSelected = false;
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            foreach (GameObject slot in DeckSlots)
            {
                if (slot.transform.childCount == 0)
                {
                    for (int i = 3; i < 8; i++)
                    {
                        if (DeckSlots[i].transform.childCount != 0)
                        {
                            Transform otherChild = DeckSlots[i].transform.GetChild(0);
                            otherChild.SetParent(slot.transform);
                            break;
                        }
                    }
                }

                Transform child = slot.transform.GetChild(0);

                if (!CardsInDeck.Contains(child.gameObject))
                    CardsInDeck.Add(child.gameObject);
            }
        }
    }

    public void SaveDeckList()
    {
        string _savedDeck = string.Empty;
        for (int i = 0; i < CardsInDeck.Count; i++)
        {
            int _index = CardDatabase.CardList.FindIndex(c => c.name.Equals(CardsInDeck[i].name));
            if (_index >= 0)
            {
                _savedDeck += string.Format("-{0}", _index);
                Debug.Log("Saved card index: " + _index + " (" + CardsInDeck[i].name + ")");
            }
        }
        PlayerPrefs.SetString("DECK", _savedDeck);
    }

    public void LoadDeckList()
    {
        string _savedDeck = PlayerPrefs.GetString("DECK", "");
        string[] _cards = _savedDeck.Split('-');

        if (_savedDeck.Length == 0) return;

        for (int i = 0; i < _cards.Length; i++)
        {
            if (_cards[i].Equals(string.Empty)) continue;
            int _cardIndex = int.Parse(_cards[i]);
            GameObject _card = CardDatabase.CardList[_cardIndex];
            Debug.Log(_card.name);

            Instantiate(_card, DeckSlots[i-1].transform);
        }
    }
}
