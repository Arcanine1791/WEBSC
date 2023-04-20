using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[System.Serializable]
public class MyBtn
{
    public GameObject _button;
    public string _name;
    public Sprite _image;
    public VideoClip clip;
}

[CreateAssetMenu(fileName = "Panel", menuName = "UIPanels/ButtonsList")]
public class MyButtons : ScriptableObject
{
   public List<MyBtn> buttons;
}