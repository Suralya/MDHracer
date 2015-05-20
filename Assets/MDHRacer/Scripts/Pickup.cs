using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	public int coins;
	// Use this for initialization
	void Start () {
		coins = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Destroy(other.gameObject);
			coins+=1;
		}
	}

}
