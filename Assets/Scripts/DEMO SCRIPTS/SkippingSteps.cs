using UnityEngine;

public class SkippingSteps : MonoBehaviour
{
    public GameObject player,lights;
    public Vector3 startPos, endPos;
    public Vector3 controlPos;

    public bool isTeleport,isReturn;
    private void Start()
    {
        controlPos = startPos + (endPos - startPos)/2 + Vector3.forward * 5f;
    }

    float count = 0.0f;

    void Update()
    {
        if (isTeleport)
        {
            StartToEnd();
        }
        if(isReturn) 
        {
            EndToStart();
        }
    }

    void StartToEnd()
    {
        if (count < 1.0f)
        {
            count += 0.1f * Time.deltaTime;

            Vector3 m1 = Vector3.Lerp(startPos, controlPos, count);
            Vector3 m2 = Vector3.Lerp(controlPos, endPos, count);
            player.transform.position = Vector3.Lerp(m1, m2, count);
        }
        lights.SetActive(false);
        
    }
    void EndToStart()
    {
        if (count < 1.0f)
        {
            count += 0.1f * Time.deltaTime;

            Vector3 m1 = Vector3.Lerp(startPos, controlPos, count);
            Vector3 m2 = Vector3.Lerp(controlPos, endPos, count);
            player.transform.position = Vector3.Lerp(m2, m1, count);
        }
        lights.SetActive(true);
    }
}
