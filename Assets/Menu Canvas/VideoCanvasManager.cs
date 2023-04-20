using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoCanvasManager : MonoBehaviour
{
    public MyButtons videoScriptableObj;
    public VideoPlayer pl;
    public GameObject videoPlayer;
    public int videoTime;
    public TextMeshProUGUI time;
    public Slider sliderObj;

    void Start()
    {
        foreach (MyBtn btn in videoScriptableObj.buttons)
        {
            GameObject videoo = Instantiate(btn._button, transform);
            videoo.GetComponentInChildren<TextMeshProUGUI>().text = btn._name.ToString();
            videoo.GetComponentInChildren<AspectRatioFitter>().GetComponentInChildren<Image>().sprite = btn._image;
            videoo.GetComponent<Button>().onClick.AddListener(() => CheckWhichClickedVideo(btn.clip));
        }
    }

    public void CheckWhichClickedVideo(VideoClip clip)
    {
        videoPlayer.SetActive(true);
        videoTime = (int)(clip.frameCount / 60);
        pl.clip = clip;
        pl.Play();
        sliderObj.maxValue = (float)clip.length;
        sliderObj.value = (float)pl.time;
    }

    public void SeekForward()
    {
        pl.time = sliderObj.value;
    }

    public bool pause;
    public void PausePlay()
    {
        pause = !pause;
        if (pause)
            pl.Pause();
        else
            pl.Play();
    }
}