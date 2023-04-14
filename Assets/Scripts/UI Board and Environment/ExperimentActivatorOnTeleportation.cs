using UnityEngine;

public class ExperimentActivatorOnTeleportation : MonoBehaviour
{
    public ExperimentPanelManager exPnl;
    public int colliderIndex;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.name == "TELEPORT LOCATIONS")
        {
            int index = other.gameObject.name.IndexOf(' ');
            colliderIndex = int.Parse(other.gameObject.name.Substring(0, index));
            if(colliderIndex < 4 && colliderIndex > -1)
            {
                Debug.Log(colliderIndex);
                exPnl.ActiveExperimentSelection(colliderIndex);
            }
        }
    }
}



































    //public LineRenderer lightRay;
    //public GameObject lightMeter, detector;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.name == "Plane (4)")
    //    {
    //        lightMeter.SetActive(true);
    //        detector.SetActive(true);
    //        lightRay.enabled = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if(other.name == "Plane (4)")
    //    {
    //        lightMeter.SetActive(false);
    //        detector.SetActive(false);
    //        lightRay.enabled = false;
    //    }
    //}
