using UnityEngine;
using BNG;
using System.Linq;
using UnityEngine.UI;

public class XR_PLAYER_Switch : MonoBehaviour
{
    public Transform environment, XR_Config, tutorial, ExperimentZone,roomLight,labLight,props;
    public Transform teleportedPosition,deportedPosition;

    [Space(5)]
    public CharacterController characterController;
    public DialogueManger dialogueManager;
    public HandController handController;
    RoomConstructionValidator RCV;
    bool check = true;
    public Text mirror_M;
    public Light spotLight;
    bool lightState = true;

    private void Awake()
    {
        RCV = GetComponent<RoomConstructionValidator>();
    }
    private void Start()
    {
        //spotLight = roomLight.GetComponentInChildren<Light>();
    }
    void Update()
    {
        //if(InputBridge.Instance.AButton)
        //{
        //    Teleport();
        //}
        //if(InputBridge.Instance.BButton)
        //{
        //    Deport();
        //}

        if(dialogueManager.activeMessage >= 1)
            ExperimentZone.gameObject.SetActive(true);

        
        if(dialogueManager.activeMessage >= 3 && check)
        {
            tutorial.gameObject.SetActive(true);
            check = false;
        }
        
        if (tutorial.gameObject.activeSelf && handController.PreviousHeldObject != null)
            tutorial.gameObject.SetActive(false);
        
    }
    public void Teleport()
    {
        characterController.enabled = false;
        environment.localScale = new Vector3(5, 5, 5);
        XR_Config.position = teleportedPosition.position;
        roomLight.gameObject.SetActive(true);
        labLight.gameObject.SetActive(false);
        props.gameObject.SetActive(true);
        mirror_M.enabled = false;
        foreach (var grabbable in RCV.snapZone)
        {
            grabbable.CanRemoveItem = false;
            grabbable.CanSwapItem = false;
        }
    }
    public void Deport()
    {
        environment.localScale = new Vector3(1, 1, 1);
        XR_Config.position = deportedPosition.position;
        characterController.enabled = true;
        roomLight.gameObject.SetActive(false);
        labLight.gameObject.SetActive(true);
        props.gameObject.SetActive(false);
        mirror_M.enabled = true;
        foreach (var grabbable in RCV.snapZone)
        {
            grabbable.CanRemoveItem = true;
            grabbable.CanSwapItem = true;
        }
    }

    public void RoomLightToggle()
    {
        lightState = !lightState;
        spotLight.gameObject.SetActive(lightState);
    }
}