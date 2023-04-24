using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CareerPathStemWall : MonoBehaviour
{
    [Serializable]
    public class CareersOptions
    {
        public GameObject careerBtn;
        public Vector3 finalPos;
    }
    public List<CareersOptions> co = new List<CareersOptions>();
    private void Start()
    {
        arrow.SetActive(false);
        foreach (var career in co)
        {
            career.finalPos = career.careerBtn.transform.localPosition;
        }
        foreach (var career in co)
        {
            career.careerBtn.transform.localPosition = Vector3.zero;
            career.careerBtn.SetActive(false);
        }
    }

    public float timeOfAnim = 2f;
    public bool playAnim = false;
    public void AnimateStuff()
    {
        playAnim = true;
    }

    Vector3 poss = new Vector3(5,5,5);
    public GameObject arrow;
    float timee = 0;
    private void Update()
    {
        


        if (playAnim)
        {
            timee += Time.deltaTime;
            foreach (var career in co)
            {
                career.careerBtn.SetActive(true);
                //career.careerBtn.transform.localPosition = Vector3.MoveTowards(Vector3.zero, career.finalPos, 100);
            }
            arrow.SetActive(true);

            co[0].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[0].finalPos, timee / timeOfAnim);
            co[1].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[1].finalPos, timee / timeOfAnim);
            co[2].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[2].finalPos, timee / timeOfAnim);
            co[3].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[3].finalPos, timee / timeOfAnim);
            co[4].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[4].finalPos, timee / timeOfAnim);
            co[5].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[5].finalPos, timee / timeOfAnim);
            co[6].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[6].finalPos, timee / timeOfAnim);
            co[7].careerBtn.transform.localPosition = Vector3.Lerp(Vector3.zero, co[7].finalPos, timee / timeOfAnim);
            arrow.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timee / timeOfAnim);
        }
    }
}