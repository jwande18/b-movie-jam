using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchCollision : MonoBehaviour
{		
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "PropTag") {
			Debug.Log("Collided with Prop!");
			DestroyObject(collision.gameObject);
			FindObjectOfType<GameManager>().addPoints(1);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
