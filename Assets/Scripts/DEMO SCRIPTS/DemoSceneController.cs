using UnityEngine;

public class DemoSceneController : MonoBehaviour
{
    public GameObject EnvLights,roomLightParent,planeBoard,boxMirror,realMirror;

    [Space(10)]
    public bool isTeleported;
    public Animator player,environment,roomAnimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTeleported)
        {
            player.Play("Teleport");
            environment.Play("Environment Scaler");
            EnvLights.SetActive(false);
            roomLightParent.SetActive(true);
            planeBoard.SetActive(true);
            boxMirror.SetActive(false);
            realMirror.SetActive(true);
        }
        if(!isTeleported)
        {
            player.Play("Deport");
            environment.Play("Environment Shrinker");
            EnvLights.SetActive(true);
            roomLightParent.SetActive(true);
            boxMirror.SetActive(true);
            realMirror.SetActive(false);
        }
        
    }
    public void Toggle()
    {
        isTeleported = !isTeleported;
    }
    public void MirrorRotate()
    {
        realMirror.transform.Rotate(0.0f, realMirror.transform.rotation.y + 180, 1.0f);
    }
    
}
