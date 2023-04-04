using UnityEngine;

public class CollisionDetectorLightMeter : MonoBehaviour
{
    public GameObject lightMeter,detector;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Plane (4)")
        {
            lightMeter.SetActive(true);
            detector.SetActive(true);
        }
    }
}
