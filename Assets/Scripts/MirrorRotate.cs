using UnityEngine;

public class MirrorRotate : MonoBehaviour
{
    [SerializeField] private Transform m_Mirror;
    //bool rotate = true;
    public BoxCollider bxc;

    private void Update()
    {
        bxc.enabled = true;

        //    if (rotate)
        //        m_Mirror.Rotate(new Vector3(0, 180, 0));
        //    if (!rotate)
        //        m_Mirror.Rotate(new Vector3(0, 0, 0));
    }
    public void MirorRotat(string buttonName)
    {
        if(buttonName == "Button")
        {
            m_Mirror.Rotate(new Vector3(0, 180, 0));
        }
        if(buttonName == "Button 1")
        {
            m_Mirror.Rotate(new Vector3(0, 0, 0));
        }
    }
}
