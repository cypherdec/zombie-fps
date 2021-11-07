using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 1;
    [SerializeField] AmmoType ammoType;

    void OnTriggerEnter(Collider other)
    {
        AddAmmo();
        Destroy(gameObject);
    }

    void AddAmmo()
    {
        FindObjectOfType<Ammo>().IncreaseAmmo(ammoType, ammoAmount);
    }
}
