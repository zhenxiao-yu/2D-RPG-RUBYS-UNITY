using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTrap : MonoBehaviour
{
   public float rotationSpeed;
   private int damageValue = 1;
   public bool clockwise;

   void Update(){
       //rotate along Z axis
       if(clockwise == true){
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
       } else {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);   
       }
   }

  void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();
        
        if (player != null)
        {
            player.ChangeHealth(damageValue);
        }
    }
}
