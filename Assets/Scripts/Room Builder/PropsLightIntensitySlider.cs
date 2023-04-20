using UnityEngine;
using UnityEngine.UI;

public class PropsLightIntensitySlider : MonoBehaviour
{
    public MeshRenderer forReflectionRenderMaterial;
    public Material changegg;
    public Color cc;
    public Light propsRoomLight;
    Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
        cc=changegg.color;
        //changegg = forReflectionRenderMaterial.GetComponent<Material>();
    }
    void Update()
    {
        propsRoomLight.intensity = slider.value * 10;
        cc.a = slider.value;
        changegg.color = cc;
    }
}
