using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageCanvas;
    [SerializeField] float impactTime = 0.3f;
    

    void Start()
    {
        damageCanvas.enabled = false;
    }

    public void ShowDamageImpact() 
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter() 
    {
        damageCanvas.enabled = true;

        yield return new WaitForSeconds(impactTime);

        damageCanvas.enabled = false;       
    }


}
