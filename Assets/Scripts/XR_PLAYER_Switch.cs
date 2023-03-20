using UnityEngine;
using BNG;

public class XR_PLAYER_Switch : MonoBehaviour
{
    public Transform environment, XR_Config, tutorial, ExperimentZone,Lightt;
    public CharacterController cc;
    public DialogueManger dd;
    public HandController hc;

    bool check = true;

    void Update()
    {
        if(InputBridge.Instance.AButton)
        {
            cc.enabled = false;
            environment.localScale = new Vector3(5, 5, 5);
            XR_Config.position = new Vector3(-1.5f, 3.96f, -11.23f);
            Lightt.gameObject.SetActive(true);
            //XR_Config.position = Vector3.MoveTowards(XR_Config.position, new Vector3(-1.5f, 3.96f, -11.23f), 1f);
        }
        if(InputBridge.Instance.BButton)
        {
            environment.localScale = new Vector3(1, 1, 1);
            XR_Config.position = new Vector3(0, 0, 0);
            cc.enabled = true;
            Lightt.gameObject.SetActive(false);
        }
        if(dd.activeMessage >= 1)
            ExperimentZone.gameObject.SetActive(true);

        
        if(dd.activeMessage >= 3 && check)
        {
            tutorial.gameObject.SetActive(true);
            check = false;
        }
        
        if (dd.activeMessage == 3)
        {
            if (hc.PreviousHeldObject != null)
                tutorial.gameObject.SetActive(false);
        }
    }
}
