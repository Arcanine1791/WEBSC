using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ExperimentDetails
{
    public int experimentNo;
    public Sprite expThumbnail;
}
[CreateAssetMenu(fileName = "Panel", menuName = "UIPanels/Experiments")]
public class ExperimentList : ScriptableObject
{
    public List<ExperimentDetails> experimentList;
}
