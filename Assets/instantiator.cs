using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball2;
    /*public GameObject ball3;
    public GameObject ball4;*/
    public float Timer = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int rotacionBall = Random.Range(-90, 90);
        int rotacionBall2 = Random.Range(-90, 90);
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            /*var clon1 = ball;
            var clon2 = ball2;
            clon1.transform.eulerAngles = new Vector3(0, rotacionBall, 0);
            clon2.transform.eulerAngles = new Vector3(0, rotacionBall2, 0);
            clon1 = Instantiate(clon1, transform.eulerAngles = new Vector3();
            clon2 = Instantiate(clon2);*/
            
            GameObject clon1 = Instantiate(ball, transform.position, ball.transform.rotation);
            GameObject clon2 = Instantiate(ball2, transform.position, ball.transform.rotation);
            /*GameObject clon3 = Instantiate(ball3, transform.position, ball.transform.rotation);
            GameObject clon4 = Instantiate(ball4, transform.position, ball.transform.rotation);*/
            clon1.transform.localPosition = new Vector3(-8.98f, 4.3f, -0.86f);
            clon2.transform.localPosition = new Vector3(-8.75f, 4.9f, -3.25f);
            clon1.transform.localEulerAngles = new Vector3(20, 70, 70);
            clon2.transform.Rotate(0, rotacionBall2, 0);

            Timer = 3;
            Destroy(clon1, 5);
            Destroy(clon2, 5);
        }
    }

}
