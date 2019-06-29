using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballroll : MonoBehaviour {

    public GameObject ball1;
    public GameObject ball2;


    // Update is called once per frame
    void Update()
    {
        //スペースキーを押したら
        if (Input.GetKeyDown(KeyCode.R))
        {
            //(2.0, -4.5, -0.35)にボール出現
            GameObject balls = Instantiate(ball1, new Vector3(10.0f, 0.6f, 2.0f), Quaternion.identity) as GameObject;

            bool isFirst = true;
            //ボールに初速を加える
            if (isFirst)
            {
                isFirst = false;
                Rigidbody rb = balls.GetComponent<Rigidbody>();
                Vector3 force = new Vector3(-10.0f, 0.0f, 0.0f);
                rb.AddForce(force, ForceMode.Impulse);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            //(2.0, -4.5, -0.35)にボール出現
            GameObject balls = Instantiate(ball2, new Vector3(10.0f, 0.6f, 2.0f), Quaternion.identity) as GameObject;

            bool isFirst = true;
            //ボールに初速を加える
            if (isFirst)
            {
                isFirst = false;
                Rigidbody rb = balls.GetComponent<Rigidbody>();
                Vector3 force = new Vector3(-10.0f, 0.0f, 0.0f);
                rb.AddForce(force, ForceMode.Impulse);
            }

        }
    }
}
