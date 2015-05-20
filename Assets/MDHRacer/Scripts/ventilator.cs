using UnityEngine;
using System.Collections;

public class ventilator : MonoBehaviour {

	public ConstantForce wind;
	public GameObject car;

	private Transform car_tr;

	private float wind_x;
	private float wind_y;
	private float wind_z;

	// Use this for initialization
	void Start () 
	{
		car = GameObject.Find ("Car");
		wind = car.GetComponent<ConstantForce>();
		car_tr = car.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		wind_x = transform.position.x - car_tr.position.x;
		wind_y = transform.position.y - car_tr.position.y;
		wind_z = transform.position.z - car_tr.position.z;
	}

	void OnTriggerEnter(Collider obj)
	{
		if (obj.CompareTag ("Player")) 
		{
			wind.enabled = true;
		}
	}

	void OnTriggerStay(Collider obj)
	{
		if (obj.CompareTag ("Player")) 
		{
			wind.force = new Vector3(wind_x, wind_y, wind_z).normalized;
		}
	}

	void OnTriggerExit(Collider obj)
	{
		if (obj.CompareTag ("Player")) 
		{
			wind.enabled = false;
		}
	}
}
