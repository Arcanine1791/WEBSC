using UnityEngine;

public class RoomLightToggle : MonoBehaviour
{
    public GameObject playerRoomLight, propsRoomLight;
    public GameObject roomMat;
    
    public void PlayerLightToggle()
    {
        playerRoomLight.SetActive(!playerRoomLight.activeInHierarchy);
        roomMat.SetActive(!roomMat.activeInHierarchy);
    }
    public void PropsLightToggle()
    {
        propsRoomLight.SetActive(!propsRoomLight.activeInHierarchy);
        roomMat.SetActive(!roomMat.activeInHierarchy);
    }
}
