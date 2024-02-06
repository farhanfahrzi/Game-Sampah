using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audiobenar;
    public AudioClip audiosalah;
    public AudioSource mediaplayerbenar;
    public AudioSource mediaplayersalah;
    public Text textscore;
    // Start is called before the first frame update
    void Start()
    {
        mediaplayerbenar = gameObject.AddComponent<AudioSource>();
        mediaplayerbenar.clip = audiobenar;
        mediaplayersalah = gameObject.AddComponent<AudioSource>();
        mediaplayersalah.clip = audiosalah;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(nameTag))
        {
            Data.score += 25;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            mediaplayerbenar.Play();
        }
        else
        {
            Data.score -= 15;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            mediaplayersalah.Play();
        }
    }
}
