using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PunchCollision : MonoBehaviour
{
    public AudioClip pointGain;
    void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "PropShort") {
			Object.Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().addPoints(4);
		}
		else if(collision.gameObject.tag == "PropSmall") {
			Object.Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().addPoints(3);
        }
		else if(collision.gameObject.tag == "PropMedium") {
			Object.Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().addPoints(2);
        }
		else if(collision.gameObject.tag == "PropLarge") {
			Object.Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();
            FindObjectOfType<GameManager>().addPoints(1);
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = pointGain;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
