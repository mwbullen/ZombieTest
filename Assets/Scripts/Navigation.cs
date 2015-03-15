using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {
	NavMeshAgent navAgent;

	// Use this for initialization
	void Start () {
		navAgent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NavtoTarget(GameObject target) {
		navAgent.SetDestination (target.transform.position);

	}

	void NavtoPosition (Vector3 position) {
		navAgent.SetDestination (position);
	}

	void Stop () {
		navAgent.Stop ();
	}

	public bool HasArrived() {
		if (navAgent == null) {
			return true;
				}

		if (!navAgent.hasPath) {
			return true;
				}
		if (navAgent.pathPending) {
			return false;
		}
		if (navAgent.remainingDistance <= navAgent.stoppingDistance) {
			return true;
				}
		return false;
	}

	public Vector3 GetRandomLocation(GameObject g) {
		Bounds b = g.transform.collider.bounds;

		return new Vector3(Random.Range(b.min.x, b.max.x), 0, Random.Range(b.min.z, b.max.z));

	}

}
