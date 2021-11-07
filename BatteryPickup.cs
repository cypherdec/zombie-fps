using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 70f;
    [SerializeField] float restoreIntensity = 8f;

    FlashLightSystem flashLight;

    void Start()
    {
        flashLight = FindObjectOfType<FlashLightSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject.tag == "Player")
        // {
        //     flashLight = other.GetComponentInChildren<FlashLightSystem>();

        // }

        flashLight.RestoreLightAngle(restoreAngle);
        flashLight.RestoreLightIntensity(restoreIntensity);
        Destroy(gameObject);

    }
}
