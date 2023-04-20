using UnityEngine;
using UnityEngine.UI;

public class PropsLightIntensitySlider : MonoBehaviour
{
    public MeshRenderer forReflectionRenderMaterial;
    public Light propsRoomLight;
    Slider slider;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    void Update()
    {
        propsRoomLight.intensity = slider.value * 10;
        forReflectionRenderMaterial.material.color = new Color(255,255,255,slider.value * 255);
    }
}
