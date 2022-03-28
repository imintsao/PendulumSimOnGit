using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTestObj : MonoBehaviour
{
    GameObject testCube;
    GameObject testCylinder;
    GameObject emptyObj;

    Rigidbody cubeRB;
    // Start is called before the first frame update
    void Start()
    {
        testCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testCube.transform.position = new Vector3(0f, 0f, 0f);
        cubeRB = testCube.AddComponent<Rigidbody>();
        cubeRB.useGravity = false;
        cubeRB.isKinematic = true;

        testCylinder = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        testCylinder.transform.position = new Vector3(0f, -2f, 0f);
        testCylinder.transform.localScale = new Vector3(1f, 4f, 1f);
        testCylinder.AddComponent<HingeJoint>();
        testCylinder.GetComponent<Rigidbody>().useGravity = true;
        testCylinder.GetComponent<HingeJoint>().connectedBody = cubeRB;

        emptyObj = new GameObject("empty");


        testCylinder.transform.parent = emptyObj.transform;

        emptyObj.transform.Rotate(0, -60, -30, Space.World);

        
    }

   
}
