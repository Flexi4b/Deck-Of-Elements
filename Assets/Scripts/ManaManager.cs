using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaManager : MonoBehaviour
{
    public int CurrentMana;

    private int _maxMana = 5;

    private void Awake()
    {
        CurrentMana = _maxMana;
    }

    void Update()
    {
        
    }
}
