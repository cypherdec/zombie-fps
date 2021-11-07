using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100;

    bool isDead = false;

    public bool IsDead { get => isDead; set => isDead = value; }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");

        hitpoints -= damage;

        if(hitpoints <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        if (isDead) return;
        
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
