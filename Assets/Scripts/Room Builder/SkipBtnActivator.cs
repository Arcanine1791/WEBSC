using BNG;
using UnityEngine;

public class SkipBtnActivator : MonoBehaviour
{
    public SnapZone mirrorSnapZone;
    public GameObject skipButton;
    private void Update()
    {
        if(mirrorSnapZone.HeldItem != null) {skipButton.SetActive(true);}
        else { skipButton.SetActive(false); }
    }
    
}
