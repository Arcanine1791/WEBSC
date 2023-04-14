using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPanelManager : MonoBehaviour
{
    public VideoPanel videoScriptableObj;
    public VideoPlayer pl;
    Button videoo;
    public GameObject videoChapterPanel;
    // Start is called before the first frame update
    void Start()
    {
        foreach (VideoInfo xyz in videoScriptableObj.chapters)
        {
            videoo = Instantiate(xyz.videoBtn, transform);
            videoo.GetComponentInChildren<Text>().text = xyz.chapterNo.ToString();
            videoo.GetComponent<Image>().sprite = xyz.thumbnail;
            videoo.onClick.AddListener(() => CheckWhichClickedVideo(xyz.video));
        }
    }

    public void CheckWhichClickedVideo(VideoClip video)
    {
        videoChapterPanel.SetActive(false);
        pl.transform.parent.gameObject.SetActive(true);
        pl.clip = video;
    }
}
