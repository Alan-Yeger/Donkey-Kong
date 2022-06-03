using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            gameObject.transform.position = new Vector3(3.95f, 1.25f, 0);
            Debug.Log("aidasjdioa");
        }
    }
}
