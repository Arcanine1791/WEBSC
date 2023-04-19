using BNG;
using UnityEngine;

public class SkipBtnActivator : MonoBehaviour
{
    public SnapZone[] ss;
    public GameObject wallPrefab;
    private void Start()
    {
        ss = GetComponentsInChildren<SnapZone>();
    }
    public void skipOperation()
    {
        for(int i=0; i<ss.Length; i++)
        {
            if (ss[i].HeldItem == null)
            {
                Instantiate(wallPrefab, ss[i].gameObject.transform);
            }
        }
    }
}
