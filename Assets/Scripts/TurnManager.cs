using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public bool IsTurnDone = true;

    [SerializeField] private TextMeshProUGUI _TurnsLeft;
    [SerializeField] private float _ResetCountDown = 5f;

    private float _countdown = 0f;

    private int _amountOfTurns = 10;
 
    void Awake()
    {
        _countdown = _ResetCountDown;
        _TurnsLeft.text = "Turns left: " + _amountOfTurns.ToString() + "!";
    }

    void Update()
    {
        if (!IsTurnDone)
        {
            _countdown -= Time.deltaTime;

            if (_countdown <= 0f )
            {
                _countdown = _ResetCountDown;
                _amountOfTurns--;
                _TurnsLeft.text = "Turns left: " + _amountOfTurns.ToString() + "!";
                IsTurnDone = true;
            }
        }

        if (_amountOfTurns <= 0)
        {
            //check caster with most health
            Application.Quit();
        }

    }
}
