using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > jeda)
        {
            int random = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random],transform.position, transform.rotation);
            timer = 0;
        }
    }

}
