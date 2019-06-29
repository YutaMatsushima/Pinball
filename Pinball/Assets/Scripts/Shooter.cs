using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject ball;


    // Update is called once per frame
    void Update()
    {
        //スペースキーを押したら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //(2.0, -4.5, -0.35)にボール出現
            GameObject balls = Instantiate(ball, new Vector3(2.3f, -4.5f, -0.35f), Quaternion.identity) as GameObject;

            bool isFirst = true;
            //ボールに初速を加える
            if (isFirst)
            {
                isFirst = false;
                Rigidbody rb = balls.GetComponent<Rigidbody>();
                Vector3 force = new Vector3(0.0f, 8.5f, 0.0f);
                rb.AddForce(force, ForceMode.Impulse);
            }
        }
    }

}
