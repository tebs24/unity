using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform Capsule;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if(Capsule != null){
            transform.position = Capsule.position+offset;
        }
    }
}
