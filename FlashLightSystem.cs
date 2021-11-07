using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minAngle = 40f;

    Light flashLight;

    void Start()
    {
        flashLight = GetComponent<Light>();
    }

    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        flashLight.spotAngle = restoreAngle;
    }

    public void RestoreLightIntensity(float intensityAmount)
    {
        flashLight.intensity = intensityAmount;
    }

    void DecreaseLightAngle()
    {
        if(flashLight.spotAngle <= minAngle) {return;}
        flashLight.spotAngle -= angleDecay * Time.deltaTime;
    }


    void DecreaseLightIntensity()  
    {
        flashLight.intensity -= lightDecay * Time.deltaTime;
    }
}
