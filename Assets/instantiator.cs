using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball2;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball);
        Instantiate(ball2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
