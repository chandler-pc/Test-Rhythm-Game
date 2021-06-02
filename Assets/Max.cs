using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Max : MonoBehaviour
{
    public AudioSource audioSource = null;
    public float[] sample = new float[64];
    public float x = 0;
    public float d = 0;

    // Update is called once per frame
    void Update()
    {
        audioSource.GetSpectrumData(sample, 0, FFTWindow.Rectangular);
        x = Mathf.Max(sample)/d;
    }
}
