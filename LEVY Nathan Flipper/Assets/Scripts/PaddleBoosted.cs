using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBoosted : MonoBehaviour
{
    [SerializeField] private GameObject Booster;
    public float targetPosition = 75;
    public float originPosition = 0;
    public float boosterDelay;

    public HingeJoint hingeJoint;
    private JointSpring jointSpring;

    public KeyCode key;
    void Start()
    {
        jointSpring = hingeJoint.spring;
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Booster.SetActive(true);
            Invoke("SetFalse",boosterDelay);
        }
        if (Input.GetKey(key))
        {
            jointSpring.targetPosition = targetPosition;
        }
        else
        {
            jointSpring.targetPosition = originPosition;
        }

        if (Input.GetKeyUp(key))
        {
            Booster.SetActive(false);
        }

        hingeJoint.spring = jointSpring;
    }

    void SetFalse()
    {
        Booster.SetActive(false);
    }
}

