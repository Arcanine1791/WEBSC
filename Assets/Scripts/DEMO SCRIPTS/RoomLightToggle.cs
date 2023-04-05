using UnityEngine;

public class RoomLightToggle : MonoBehaviour
{
    public GameObject playerRoomLight, propsRoomLight;
    public void PlayerLightToggle()
    {
        playerRoomLight.SetActive(!playerRoomLight.activeInHierarchy);
    }
    public void PropsLightToggle()
    {
        propsRoomLight.SetActive(!propsRoomLight.activeInHierarchy);
    }
}
