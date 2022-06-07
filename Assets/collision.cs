using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collision : MonoBehaviour
{
    public GameObject Victoria;
    public AudioClip Muerte;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball(Clone)" || col.gameObject.name == "ball 1(Clone)")
        {
            transform.position = new Vector3(3.95f, 1.25f, 0);
            fuenteAudio.clip = Muerte;
            fuenteAudio.Play();
            
        }

        if(col.gameObject.name == "CuboVictoria")
        {
            Victoria.SetActive(true);
        }
    }
}
