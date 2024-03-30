using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpell : MonoBehaviour
{
    public Spells SpellDatabase;
    
    [SerializeField] private MousePosition _mousePos;
    [SerializeField] private Transform _shootPoint;

    void Update()
    {
        if (_mousePos.UseBurnToss)
        {
            GameObject currentSpell = SpellDatabase.SpellList[0];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseBurnToss = false;
        }

        if (_mousePos.UseHeatHeal)
        {
            GameObject currentSpell = SpellDatabase.SpellList[1];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseHeatHeal = false;
        }

        if (_mousePos.UseFlameOn)
        {
            GameObject currentSpell = SpellDatabase.SpellList[2];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseFlameOn = false;
        }

        if (_mousePos.UseFireWall)
        {
            GameObject currentSpell = SpellDatabase.SpellList[3];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseFireWall = false;
        }

        if (_mousePos.UseStygian)
        {
            GameObject currentSpell = SpellDatabase.SpellList[4];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseStygian = false;
        }

        if (_mousePos.UseDirtChuk)
        {
            GameObject currentSpell = SpellDatabase.SpellList[5];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseDirtChuk = false;
        }

        if (_mousePos.UseLifeSeed)
        {
            GameObject currentSpell = SpellDatabase.SpellList[6];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseLifeSeed = false;
        }

        if (_mousePos.UseEnsnare)
        {
            GameObject currentSpell = SpellDatabase.SpellList[7];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseEnsnare = false;
        }

        if (_mousePos.UseMudslide)
        {
            GameObject currentSpell = SpellDatabase.SpellList[8];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseMudslide = false;
        }

        if (_mousePos.UseGaiaBash)
        {
            GameObject currentSpell = SpellDatabase.SpellList[9];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseGaiaBash = false;
        }

        if (_mousePos.UseVoltFling)
        {
            GameObject currentSpell = SpellDatabase.SpellList[10];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseVoltFling = false;
        }

        if (_mousePos.UseReShock)
        {
            GameObject currentSpell = SpellDatabase.SpellList[11];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseReShock = false;
        }

        if (_mousePos.UseAmpulse)
        {
            GameObject currentSpell = SpellDatabase.SpellList[12];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseAmpulse = false;
        }

        if (_mousePos.UseDigiNet)
        {
            GameObject currentSpell = SpellDatabase.SpellList[13];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseDigiNet = false;
        }

        if (_mousePos.UseGalvanize)
        {
            GameObject currentSpell = SpellDatabase.SpellList[14];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseGalvanize = false;
        }

        if (_mousePos.UseChillShard)
        {
            GameObject currentSpell = SpellDatabase.SpellList[15];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseChillShard = false;
        }

        if (_mousePos.UseRefresh)
        {
            GameObject currentSpell = SpellDatabase.SpellList[16];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseRefresh = false;
        }

        if (_mousePos.UseFrozone)
        {
            GameObject currentSpell = SpellDatabase.SpellList[17];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseFrozone = false;
        }

        if (_mousePos.UseTsunami)
        {
            GameObject currentSpell = SpellDatabase.SpellList[18];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseTsunami = false;
        }

        if (_mousePos.UseGlaciate)
        {
            GameObject currentSpell = SpellDatabase.SpellList[19];
            SpellBehavior currentBehavior = currentSpell.GetComponent<SpellBehavior>();
            SpellBehavior shootSpell = Instantiate(currentBehavior, _shootPoint.position, _shootPoint.rotation) as SpellBehavior;
            _mousePos.UseGlaciate = false;
        }
    }
}
