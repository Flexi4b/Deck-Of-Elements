using UnityEngine;

public enum SpellType
{
    Burn,
    Flora,
    Bolt,
    Chilling,
}

[CreateAssetMenu(menuName = "CardGame/CardData")]
public class SpellCardsData : ScriptableObject
{
    public SpellType SpellTyping;

    [SerializeField] 
    private string _cardName, _cardDiscription = string.Empty;

    [SerializeField]
    private int _manaCount = 0;

    [SerializeField]
    private Sprite _emptyCard, _spellImage, _spellText, _manaOrb, _manaNumber = null;

    public SpellType GetTyping { get {  return SpellTyping; } }
    public string GetCardName { get { return _cardName; } }
    public string GetCardDiscription { get { return _cardDiscription; } }
    public int GetManaCount { get {  return _manaCount; } }
    public Sprite GetEmptyCard { get { return _emptyCard; } }
    public Sprite GetSpellImage { get { return _spellImage; } }
    public Sprite GetSpellText { get { return _spellText; } }
    public Sprite GetManaOrb { get { return _manaOrb; } }
    public Sprite GetManaNumber { get { return _manaNumber; } }
}
