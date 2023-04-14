using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    [Tooltip("The target object that the spot light will adjust its range and intensity based on its distance.")]
    public GameObject targetObject;
    public GameObject magnifier;
    public GameObject surface;
    [Tooltip("The maximum range of the spot light.")]
    public float maxRange = 10f;

    [Tooltip("The minimum range of the spot light.")]
    public float minRange = 1f;

    [Tooltip("The maximum intensity of the spot light.")]
    public float maxIntensity = 1f;

    [Tooltip("The minimum intensity of the spot light.")]
    public float minIntensity = 0f;

    public Light spotLight;
    public bool isMagnifier;
    float intensity;
    float range;
    public float distance;
    private void Update()
    {
        if (targetObject != null)
        {
            distance = Vector3.Distance(transform.position, targetObject.transform.position);

            // Calculate the range based on the distance
             range = Mathf.Lerp(minRange, maxRange, distance / maxRange);

            // Calculate the intensity based on the distance
            intensity = Mathf.Lerp(minIntensity, maxIntensity, distance/maxRange);

            // Set the range and intensity of the spot light
           
        }
        if (!isMagnifier)
        {
            spotLight.spotAngle = range*10;
            spotLight.intensity = intensity*10;
        }
        if (isMagnifier)
        {
            spotLight.spotAngle = range*10;
            spotLight.intensity = intensity*100;
        }
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 100))
        {
            Debug.Log("Did Hit");
            if (hit.collider.name == "Magnifier")
            {
                isMagnifier = true;
                targetObject = magnifier;
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.red);
            }
            else
            {
                targetObject = surface;
                isMagnifier = false;
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 1000, Color.blue);
                Debug.Log("Did not Hit");
            }
        }
        
    }
}