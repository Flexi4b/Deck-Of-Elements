using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpell : MonoBehaviour
{
    [SerializeField] private SpellBehavior _spellBehavior;
    [SerializeField] private Transform _shootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpellBehavior shootSpell = Instantiate(_spellBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
        }
    }
}
