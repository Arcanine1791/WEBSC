using UnityEngine;
using UnityEngine.UI;

public class PropsLightIntensitySlider : MonoBehaviour
{
    public Light propsRoomLight;
    Slider slider;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    void Update()
    {
        propsRoomLight.intensity = slider.value * 10;
    }
}
