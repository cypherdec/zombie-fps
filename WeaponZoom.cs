using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] GameObject followCam;
    [SerializeField] float zoomOutFOV = 40f;
    [SerializeField] float zoomInFOV = 20f;


    [SerializeField] FirstPersonController firstPersonController;
    [SerializeField] float zoomInSensitivity = 0.1f;
    [SerializeField] float zoomOutSensitivity = 0.65f;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            followCam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = zoomInFOV;
            firstPersonController.ZoomSensitivity(zoomInSensitivity);
        }
        else
        {
            followCam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = zoomOutFOV;
            firstPersonController.ZoomSensitivity(zoomOutSensitivity);
        }
    }
}
