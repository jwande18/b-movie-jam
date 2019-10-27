using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchCollision : MonoBehaviour
{		
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "PropShort") {
			DestroyObject(collision.gameObject);
			FindObjectOfType<GameManager>().addPoints(4);
		}
		else if(collision.gameObject.tag == "PropSmall") {
			DestroyObject(collision.gameObject);
			FindObjectOfType<GameManager>().addPoints(3);
		}
		else if(collision.gameObject.tag == "PropMedium") {
			DestroyObject(collision.gameObject);
			FindObjectOfType<GameManager>().addPoints(2);
		}
		else if(collision.gameObject.tag == "PropLarge") {
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
