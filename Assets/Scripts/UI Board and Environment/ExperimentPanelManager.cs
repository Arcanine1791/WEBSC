using UnityEngine.UI;
using UnityEngine;

public class ExperimentPanelManager : MonoBehaviour
{
    public GameObject videoPanel1, videoPanel2, videoPanel3, videoPanel4, videoPanel5, videoPanel6;
    [Space(10)]
    public GameObject experimentPanel,lightMeterDetector;
    public GameObject[] experiments;
    [Space(10)]
    public ExperimentList experimentScriptableObj;
    public Button expBtn;
    public LightMeter lightMeterScript;
    void Start()
    {
        foreach(ExperimentDetails exp in experimentScriptableObj.experimentList)
        {
            expBtn = Instantiate(expBtn,transform);
            expBtn.GetComponentInChildren<Text>().text = exp.experimentNo.ToString();
            expBtn.GetComponent<Image>().sprite = exp.expThumbnail;
            expBtn.onClick.AddListener(()=>ActiveExperimentSelection(exp.experimentNo));
            expBtn.onClick.AddListener(()=> VideoPlayerSelectionFunctionTemporary(exp.experimentNo));
        }
    }

    public void ActiveExperimentSelection(int experimentNumber)
    {
        for (int i = 0; i < experiments.Length; i++)
        {
            experiments[i].SetActive(false);


            if (i == experimentNumber)
            {
                experiments[i].SetActive(true);
                if(i == 1)
                {
                    lightMeterDetector.SetActive(true);
                    lightMeterScript.lineRenderer.enabled = true;
                }
                if (i != 1)
                {
                    lightMeterDetector.SetActive(false);
                    lightMeterScript.lineRenderer.enabled = false;
                }
                experimentPanel.SetActive(false);
                break;
            }
        }
    }

    public void VideoPlayerSelectionFunctionTemporary(int experimentNumber)
    {
        if (experimentNumber == 0)
        {
            videoPanel1.SetActive(true);
            videoPanel2.SetActive(false);
            videoPanel3.SetActive(false);
            videoPanel4.SetActive(false);
            videoPanel5.SetActive(false);
            videoPanel6.SetActive(false);
        }
        if (experimentNumber == 1)
        {
            videoPanel1.SetActive(false);
            videoPanel2.SetActive(true);
            videoPanel3.SetActive(false);
            videoPanel4.SetActive(false);
            videoPanel5.SetActive(false);
            videoPanel6.SetActive(false);
        }
        if (experimentNumber == 2)
        {
            videoPanel1.SetActive(false);
            videoPanel2.SetActive(false);
            videoPanel3.SetActive(true);
            videoPanel4.SetActive(false);
            videoPanel5.SetActive(false);
            videoPanel6.SetActive(false);
        }
        if (experimentNumber == 3)
        {
            videoPanel1.SetActive(false);
            videoPanel2.SetActive(false);
            videoPanel3.SetActive(false);
            videoPanel4.SetActive(true);
            videoPanel5.SetActive(false);
            videoPanel6.SetActive(false);
        }
        if (experimentNumber == 4)
        {
            videoPanel1.SetActive(false);
            videoPanel2.SetActive(false);
            videoPanel3.SetActive(false);
            videoPanel4.SetActive(false);
            videoPanel5.SetActive(true);
            videoPanel6.SetActive(false);
        }
        if (experimentNumber == 5)
        {
            videoPanel1.SetActive(false);
            videoPanel2.SetActive(false);
            videoPanel3.SetActive(false);
            videoPanel4.SetActive(false);
            videoPanel5.SetActive(false);
            videoPanel6.SetActive(true);
        }
    }
}
