using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public ButtonHolder buttons;
    public Text tx;
    public GameObject videoPanel,subjectPanel;

    private void Start()
    {
     
        foreach (ButtonInfo xyz in buttons.subjects)
        {
            Button jar = Instantiate(xyz.btn,transform);
            jar.GetComponentInChildren<RawImage>().texture = xyz.image;
            jar.GetComponentInChildren<RawImage>().color = Color.white;
            jar.GetComponentInChildren<Text>().text = xyz.name;
            jar.onClick.AddListener(() => CheckWhichClicked(xyz.name));
        }
    }

    public void CheckWhichClicked(string name)
    {
        switch (name)
        {
            case "Physics":
                tx.text = "Physics";
                videoPanel.SetActive(true);
                subjectPanel.SetActive(false);
                break;

            case "Chemistry":
                tx.text = "Chemistry";
                break;

            default:
                tx.text = "Invalid";
                break;

        }
    }

}
