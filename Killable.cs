using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]

public class Killable : MonoBehaviour
{

   public int health;

   private void OnMouseDown()
   {
        //subract 2 from health
        health-=2;

        if (health<=0)
        {
            Die();
        }
        
   }

    void Die()
    {
        Destroy(gameObject);
    }

}
