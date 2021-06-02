using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPeer : MonoBehaviour
{
    public float t = 0.5f;
    private float tt = 0f;
    public GameObject Note = null;
    public bool pause = true;
    public Max xMax = null;
    public float min = 0;
    public float max = 0;
    void Start()
    {
        tt = t;
        Instantiate(Note, this.transform.position + Vector3.up * -8, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (pause == false)
        {
            t -= Time.deltaTime;
            if (t <= 0)
            {
                if (xMax.x > min && xMax.x<=max)
                {
                    Instantiate(Note, this.transform.position, Quaternion.identity);
                    Debug.Log(xMax.x);
                    t = tt;
                }
            }
        }
    }
}
