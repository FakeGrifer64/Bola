using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangecolorOntrigger : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Color randomlySelectedColorwithAlpha = GetRandomColorWithAlpha();
        GetComponent<Renderer>().material.color = randomlySelectedColorwithAlpha;
    }

    private Color GetRandomColorWithAlpha()
    {
        return new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f),0.25f);
    }

}
