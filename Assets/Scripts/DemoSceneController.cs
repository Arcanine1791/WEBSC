using UnityEngine;

public class DemoSceneController : MonoBehaviour
{
    public Animator player,environment,roomAnimation;
    public bool isTeleported;
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
        }
        if(!isTeleported)
        {
            player.Play("Deport");
            environment.Play("Environment Shrinker");
        }
        
    }
    public void Toggle()
    {
        isTeleported = !isTeleported;
    }
    
}
