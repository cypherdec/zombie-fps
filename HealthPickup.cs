using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] int hpAmount = 50;

    private void OnTriggerEnter(Collider other) {

        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();

        playerHealth.AddHealth(hpAmount);

        Destroy(gameObject);
        
    }
}
