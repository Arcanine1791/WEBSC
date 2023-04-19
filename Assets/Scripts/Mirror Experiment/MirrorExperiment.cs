using BNG;
using UnityEngine;
using UnityEngine.UI;

public class MirrorExperiment : MonoBehaviour
{
    public GameObject silverCam;
    SnapZone plateSnapZone;
    Text snapzoneText;

    private void Start()
    {
        plateSnapZone = GetComponentInChildren<SnapZone>();
        snapzoneText = plateSnapZone.gameObject.GetComponentInChildren<Text>();
    }
    void Update()
    {
        if (plateSnapZone.HeldItem != null)
        {
            snapzoneText.enabled = false;
            silverCam.SetActive(true);
        }
    }
}
