using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAI : MonoBehaviour
{
	public Transform start;
	public Transform end;
	
	void OnCollisionEnter(Collision collision) {
		Debug.Log("Car COLLISION");
		if(collision.gameObject.tag == "FlagEnd") {
			Debug.Log("End COLLISION");
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.destination = start.position;
		}
		else if(collision.gameObject.tag == "FlagStart") {
			NavMeshAgent agent = GetComponent<NavMeshAgent>();
			agent.destination = end.position;
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.destination = end.position;
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
