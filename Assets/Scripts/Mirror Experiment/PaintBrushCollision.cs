using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrushCollision : MonoBehaviour
{
    public GameObject paintMesh;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Aluminium Renderer")
        {
            paintMesh.SetActive(true);
        }
    }
}
