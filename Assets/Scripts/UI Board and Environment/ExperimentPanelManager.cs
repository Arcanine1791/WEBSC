using UnityEngine.UI;
using UnityEngine;

public class ExperimentPanelManager : MonoBehaviour
{
    public GameObject videoPanel,experimentPanel,lightMeterDetector;
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
                videoPanel.SetActive(true);
                experimentPanel.SetActive(false);
                break;
            }
        }
    }
}
