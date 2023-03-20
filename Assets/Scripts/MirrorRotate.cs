using UnityEngine;

public class MirrorRotate : MonoBehaviour
{
    [SerializeField] private Transform m_Transform;
    bool rotate;
    public void MirorRotat()
    {
        rotate = !rotate;
        if (rotate)
            m_Transform.Rotate(new Vector3(0, 180, 0));
        if (!rotate)
            m_Transform.Rotate(new Vector3(0, 0, 0));
    }
}
