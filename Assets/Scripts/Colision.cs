using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
   {
    Debug.Log("Colision");
    Destroy(gameObject);

   }
}