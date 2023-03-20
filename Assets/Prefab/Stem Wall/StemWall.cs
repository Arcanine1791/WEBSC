using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StemWall : MonoBehaviour
{
    public void OpenThis(GameObject obj)
    {
        obj.GetComponent<Animator>().Play("Main");
    }
    public void EnableThis(GameObject obj)
    {
        obj.SetActive(true);
    }
}