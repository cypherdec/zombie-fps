using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;

    [SerializeField] TextMeshProUGUI healthText;

    DeathHandler deathHandler;

    void Start() {
        UpdateHP();
        deathHandler = FindObjectOfType<DeathHandler>();    
    }

    public float Hitpoints { get => hitpoints; set => hitpoints = value; }

    public void TakeDamage(float damage)
    {
        hitpoints -= damage;

        UpdateHP();

        if(hitpoints <= 0)
        {
            deathHandler.HandleDeath();
        }
    }

    public void AddHealth(int hp)
    {
        hitpoints += hp;
        UpdateHP();        
    }

    void UpdateHP()
    {
        healthText.text = hitpoints.ToString() + " HP";
    }
}
