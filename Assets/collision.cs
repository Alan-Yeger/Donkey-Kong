using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collision : MonoBehaviour
{
    public GameObject victoria;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball(Clone)" || col.gameObject.name == "ball 1(Clone)")
        {
            gameObject.transform.position = new Vector3(3.95f, 1.25f, 0);
        }

        if(col.gameObject.name == "CuboVictoria")
        {
            victoria.SetActive(true);
        }
    }
}
