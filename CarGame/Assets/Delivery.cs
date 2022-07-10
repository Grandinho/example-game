using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
      bool hasPackage = false;
      [SerializeField] float timeToDestroy = 1f;
      void OnCollisionEnter2D(Collision2D other) 
        {
           Debug.Log("Lewo na rondzie"); 
        }

       void OnTriggerEnter2D(Collider2D other) 
        {
          if (other.tag == "Package" && !hasPackage)
            {
              Debug.Log("Package picked up");
              hasPackage = true;
              Destroy(other.gameObject, timeToDestroy);
              
            }
          else if(other.tag == "customer" && hasPackage)
          {
            Debug.Log("delivered package");
            hasPackage = false;
          }
        }
}
