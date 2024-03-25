using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBehavior : MonoBehaviour
{
    public enum Typing
    {
        Burn,
        Flora,
        Bolt,
        Chilling,
    }

    public enum Ability
    {
        Weak,
        Regenaration,
        Wall,
        Status,
        Powerfull,
    }

    public Typing CardType;
    public Ability CardAbility;

    private float _speed = 5;
    private float _existanceTime = 2.5f;

    private bool _equalTypes = false;
    private bool _firstTypeWins = false;
    private bool _secondTypeWins = false;

    private bool _bothLose = false;
    private bool _firstSkillWins = false;
    private bool _secondSkillWins = false;
    private bool _bothWin = false;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);

        _existanceTime -= Time.deltaTime;
        if (_existanceTime < 0)
        {
            Destroy(gameObject);
        }
    }

    struct TypingPair
    {
        public Typing First { get; }
        public Typing Second { get; }

        public TypingPair(Typing first, Typing second)
        {
            First = first;
            Second = second;
        }
    }

    struct AbilityPair
    {
        public Ability First { get; }
        public Ability Second { get; }

        public AbilityPair(Ability first, Ability second)
        {
            First = first;
            Second = second;
        }
    }

    private Dictionary<TypingPair, int> typeCombination = new Dictionary<TypingPair, int>
    {
        //Burn typings
        {new TypingPair(Typing.Burn, Typing.Burn), 0},
        {new TypingPair(Typing.Burn, Typing.Flora), 1},
        {new TypingPair(Typing.Burn, Typing.Bolt), 0},
        {new TypingPair(Typing.Burn, Typing.Chilling), 2},

        //Flora typings
        {new TypingPair(Typing.Flora, Typing.Burn), 2},
        {new TypingPair(Typing.Flora, Typing.Flora), 0},
        {new TypingPair(Typing.Flora, Typing.Bolt), 1},
        {new TypingPair(Typing.Flora, Typing.Chilling), 0},

        //Bolt typings
        {new TypingPair(Typing.Bolt, Typing.Burn), 0},
        {new TypingPair(Typing.Bolt, Typing.Flora), 2},
        {new TypingPair(Typing.Bolt, Typing.Bolt), 0},
        {new TypingPair(Typing.Bolt, Typing.Chilling), 1},

        //Chilling typings
        {new TypingPair(Typing.Chilling, Typing.Burn), 1},
        {new TypingPair(Typing.Chilling, Typing.Flora), 0},
        {new TypingPair(Typing.Chilling, Typing.Bolt), 2},
        {new TypingPair(Typing.Chilling, Typing.Chilling), 0},
    };

    private Dictionary<AbilityPair, int> abilityCombination = new Dictionary<AbilityPair, int>
    {
        //Weak spell ability
        {new AbilityPair(Ability.Weak, Ability.Weak), 0},
        {new AbilityPair(Ability.Weak, Ability.Regenaration), 3},
        {new AbilityPair(Ability.Weak, Ability.Wall), 2},
        {new AbilityPair(Ability.Weak, Ability.Status), 3},
        {new AbilityPair(Ability.Weak, Ability.Powerfull), 2},

        //Regeneration spell ability
        {new AbilityPair(Ability.Regenaration, Ability.Weak), 3},
        {new AbilityPair(Ability.Regenaration, Ability.Regenaration), 3},
        {new AbilityPair(Ability.Regenaration, Ability.Wall), 3},
        {new AbilityPair(Ability.Regenaration, Ability.Status), 0},
        {new AbilityPair(Ability.Regenaration, Ability.Powerfull), 3},

        //Wall spell ability
        {new AbilityPair(Ability.Wall, Ability.Weak), 1},
        {new AbilityPair(Ability.Wall, Ability.Regenaration), 3},
        {new AbilityPair(Ability.Wall, Ability.Wall), 3},
        {new AbilityPair(Ability.Wall, Ability.Status), 3},
        {new AbilityPair(Ability.Wall, Ability.Powerfull), 0},

        //Status spell ability
        {new AbilityPair(Ability.Status, Ability.Weak), 3},
        {new AbilityPair(Ability.Status, Ability.Regenaration), 0},
        {new AbilityPair(Ability.Status, Ability.Wall), 3},
        {new AbilityPair(Ability.Status, Ability.Status), 3},
        {new AbilityPair(Ability.Status, Ability.Powerfull), 3},

        //Powerfull spell ability
        {new AbilityPair(Ability.Powerfull, Ability.Weak), 1},
        {new AbilityPair(Ability.Powerfull, Ability.Regenaration), 3},
        {new AbilityPair(Ability.Powerfull, Ability.Wall), 0},
        {new AbilityPair(Ability.Powerfull, Ability.Status), 3},
        {new AbilityPair(Ability.Powerfull, Ability.Powerfull), 0},
    };

    public string GetType(Typing first, Typing second)
    {
        TypingPair pair = new TypingPair(first, second);

        if (typeCombination.TryGetValue(pair, out int action))
        {
            if (action == 0)
            {
                _equalTypes = true;
                return "0";
            }
            
            if (action == 1)
            {
                _firstTypeWins = true;
                return "1";
            }

            if (action == 2)
            {
                _secondTypeWins = true;
                return "2";
            }

            else
            {
                return null;
            }

        }
        else
        {
            return "Geen actie gevonden";
        }
    }

    public string GetAbility(Ability first, Ability second)
    {
        AbilityPair pair = new AbilityPair(first, second);

        if (abilityCombination.TryGetValue(pair, out int action))
        {
            if (action == 0)
            {
                _bothLose = true;
                return "0";
            }

            if (action == 1)
            {
                _firstSkillWins = true;
                return "1";
            }

            if (action == 2)
            {
                _secondSkillWins = true;
                return "2";
            }
            
            if (action == 3)
            {
                _bothWin = true;
                return "3";
            }

            else
            {
                return null;
            }
        }
        else
        {
            return "Geen actie gevonden";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Typing type = collision.gameObject.GetComponent<SpellBehavior>().CardType;
        Ability ability = collision.gameObject.GetComponent<SpellBehavior>().CardAbility;
        
        GetType(this.CardType, type);
        GetAbility(this.CardAbility, ability);

        if (_equalTypes == true && _bothLose == true)
        {
            Destroy(gameObject);
        }

        if (_equalTypes == true && _firstSkillWins == true)
        {
            Debug.Log("Damage Opponent");
        }

        if (_equalTypes == true && _secondSkillWins == true)
        {
            Destroy(gameObject);
        }

        if (_equalTypes == true && _bothWin == true)
        {
            Debug.Log("Spells do their action");
        }

        if (_firstTypeWins == true && _bothLose == true)
        {
            Debug.Log("Damage Opponent");
        }

        if (_firstTypeWins == true && _firstSkillWins == true)
        {
            Debug.Log("Damage Opponent");
        }

        if (_firstTypeWins == true && _secondSkillWins == true)
        {
            Destroy(gameObject);
        }

        if (_firstTypeWins == true && _bothWin == true)
        {
            Debug.Log("Spells do their action");
        }

        if (_secondTypeWins == true && _bothLose == true)
        {
            Destroy(gameObject);
        }

        if (_secondTypeWins == true && _firstSkillWins == true)
        {
            Destroy(gameObject);
        }

        if (_secondTypeWins == true && _secondSkillWins == true)
        {
            Destroy(gameObject);
        }

        if (_secondTypeWins == true && _bothWin == true)
        {
            Debug.Log("Spells do their action");
        }
    }
}
