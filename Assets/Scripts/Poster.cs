using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] private float timeChanger;
    private int index = 0;
    [SerializeField] private List<Texture> m_Textures = new List<Texture>();
    [SerializeField] private MeshRenderer render;
    private void Awake() { InvokeRepeating("ChangeTexture", 2, timeChanger); }
    public void ChangeTexture()
    {
        if (index < m_Textures.Count) { index = index + 1; }
        if (index >= m_Textures.Count) { index = 0; }
        render.material.mainTexture = m_Textures[index];
    }
}