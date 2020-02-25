using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelScript : MonoBehaviour
{
		 public TimerScript fuel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
	
	 void OnTriggerEnter2D(Collider2D other)     
     {
         if(other.tag == "Player")
         {  
			 Debug.Log("Refilled");
             Destroy(this.gameObject);
             fuel.timeLeft += 10;    
         }    
     }
}
