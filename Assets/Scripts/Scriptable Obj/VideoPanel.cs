using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Video;

[System.Serializable]
public class VideoInfo
{
    public Button videoBtn;
    public VideoClip videoImg;
    public int chapterNo;
}
[CreateAssetMenu(fileName = "VideoPanel", menuName = "UIPanels/Video")]
public class VideoPanel : ScriptableObject
{
    public List<VideoInfo> chapters;
}
