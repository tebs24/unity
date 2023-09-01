using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
   {
    Debug.Log("Colision");
    Destroy(gameObject);

   }
}
