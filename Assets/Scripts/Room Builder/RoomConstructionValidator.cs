using BNG;
using System;
using UnityEngine;

public class RoomConstructionValidator : MonoBehaviour
{
    public GameObject room,teleportButton,mirrorRotateButton,deportButton;
    [HideInInspector]public SnapZone[] snapZone;

    bool isSkipped = false;
    private void Start()
    {
        snapZone = room.GetComponentsInChildren<SnapZone>();
    }
    void Update()
    {
        if (isConstructed() || isSkipped)
        {
            teleportButton.SetActive(true);
            mirrorRotateButton.SetActive(true);
            deportButton.SetActive(true);
        }
        else
        {
            teleportButton.SetActive(false);
            mirrorRotateButton.SetActive(false);
            deportButton.SetActive(false);
        }
    }
    public bool isConstructed()
    {
        return Array.TrueForAll(snapZone, snap => snap.HeldItem != null);
    }
    public void IsSkipped()
    {
       isSkipped = true;
    }
}
