using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakSpell : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();

        if (collision.gameObject.CompareTag("Caster"))
        {
            health.AmountOfHealth--;
        }
    }
}
