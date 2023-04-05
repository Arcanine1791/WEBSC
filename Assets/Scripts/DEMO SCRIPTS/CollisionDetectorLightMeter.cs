using UnityEngine;

public class CollisionDetectorLightMeter : MonoBehaviour
{
    public LineRenderer lightRay;
    public GameObject lightMeter,detector;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Plane (4)")
        {
            lightMeter.SetActive(true);
            detector.SetActive(true);
            lightRay.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Plane (4)")
        {
            lightMeter.SetActive(false);
            detector.SetActive(false);
            lightRay.enabled = false;
        }
    }
}
