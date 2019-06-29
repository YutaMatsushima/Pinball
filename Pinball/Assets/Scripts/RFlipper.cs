using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFlipper : MonoBehaviour {

    public float spring;
    public float damper;
    public float openAngle;
    public float closeAngle;

    private HingeJoint hj;
    private Rigidbody rb;

    void Start()
    {
        hj = gameObject.GetComponent<HingeJoint>();
        rb = gameObject.GetComponent<Rigidbody>();
        closeFlipper();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            openFlipper();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            closeFlipper();
        }
    }

    public void openFlipper()
    {
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = openAngle;
        hj.spring = spr;
    }

    public void closeFlipper()
    {
        JointSpring spr = hj.spring;
        spr.spring = spring;
        spr.damper = damper;
        spr.targetPosition = closeAngle;
        hj.spring = spr;
    }
}
