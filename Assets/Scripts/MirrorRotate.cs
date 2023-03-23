using UnityEngine;

public class MirrorRotate : MonoBehaviour
{
    [SerializeField] private Transform m_Transform;
    bool rotate;
    public BoxCollider[] bxc = new BoxCollider[2];

    private void Update()
    {
        bxc[1].enabled = true;
        bxc[0].enabled = true;
    }
    public void MirorRotat()
    {
        rotate = !rotate;
        if (rotate)
            m_Transform.Rotate(new Vector3(0, 180, 0));
        if (!rotate)
            m_Transform.Rotate(new Vector3(0, 0, 0));
    }
}
