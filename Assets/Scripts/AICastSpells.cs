using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICastSpells : MonoBehaviour
{
    public List<GameObject> OpponentSpells = new();
    public bool AiShootSpell = false;

    [SerializeField] private Transform _shootPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if (AiShootSpell)
        {
            GameObject currentSpell = OpponentSpells[Random.Range(0, OpponentSpells.Count)];
            if (currentSpell == null)
            {
                currentSpell = OpponentSpells[Random.Range(0, OpponentSpells.Count)];
            }
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            OpponentSpells.Remove(currentSpell);
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            AiShootSpell = false;
        }
    }
}
