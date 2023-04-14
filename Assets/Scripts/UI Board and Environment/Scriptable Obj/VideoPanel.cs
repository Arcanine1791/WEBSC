using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Video;

[System.Serializable]
public class VideoInfo
{
    public int chapterNo;
    public VideoClip video;
    public Sprite thumbnail;
    public Button videoBtn;
}
[CreateAssetMenu(fileName = "VideoPanel", menuName = "UIPanels/Video")]
public class VideoPanel : ScriptableObject
{
    public List<VideoInfo> chapters;
}
