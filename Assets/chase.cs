using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chase : MonoBehaviour {

    Rigidbody rigidbody;
    [SerializeField] GameObject player;
    [SerializeField] NavMeshAgent navMeshAgent;
    Vector3 rotation;

    

	// Use this for initialization
	void Start () {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rotation.x = gameObject.transform.localRotation.x;
        rotation.y = gameObject.transform.localRotation.y;
        rotation.z = gameObject.transform.localRotation.z;
    }
	
	// Update is called once per frame
	void Update () {

        navMeshAgent.transform.LookAt(player.transform);
        navMeshAgent.destination = player.transform.position;
        this.gameObject.transform.eulerAngles = new Vector3(rotation.x, this.gameObject.transform.eulerAngles.y, rotation.z);
	}
}
