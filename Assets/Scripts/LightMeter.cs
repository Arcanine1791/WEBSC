using UnityEngine;
using TMPro;

public class LightMeter : MonoBehaviour
{
    public Transform lineRendererStart,lineRendererEnd,detecter;
    public float length, dist;
    RaycastHit hit;
    void Update()
    {

        lineRender();

        Ray rr = new Ray(lineRendererStart.position, lineRendererStart.forward);
        Debug.DrawRay(lineRendererStart.position, lineRendererStart.forward * dist , Color.red);

        if(Physics.Raycast(rr,out hit))
        {
            if(hit.collider.tag == "Detecter")
            {
                length = hit.distance;
                readingText.text = (length * 10).ToString();
                lineRendererEnd.position = new Vector3(lineRendererEnd.position.x, lineRendererEnd.position.y, hit.distance);
            }
        }
    }
    
    public LineRenderer lineRenderer;
    public TMP_Text readingText;
    void lineRender()
    {
        lineRenderer.SetPosition(0, lineRendererStart.position);
        lineRenderer.SetPosition(1, lineRendererEnd.position);

        //ll.SetPosition(1, (lineRendererStart.localPosition));
    }
}