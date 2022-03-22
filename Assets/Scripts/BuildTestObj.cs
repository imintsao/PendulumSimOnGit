using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTestObj : MonoBehaviour
{
    GameObject testCube;
    GameObject testCylinder;

    Rigidbody cubeRB;
    // Start is called before the first frame update
    void Start()
    {
        testCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testCube.transform.position = new Vector3(0f, 0f, 0f);
        cubeRB = testCube.AddComponent<Rigidbody>();
        cubeRB.useGravity = false;
        cubeRB.isKinematic = true;

        testCylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        testCylinder.transform.position = new Vector3(0f, -2f, 0f);
        testCylinder.AddComponent<HingeJoint>();
        testCylinder.GetComponent<Rigidbody>().useGravity = true;
        testCylinder.GetComponent<HingeJoint>().connectedBody = cubeRB;



        
    }

   
}
