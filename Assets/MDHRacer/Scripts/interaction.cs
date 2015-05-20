using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class interaction : MonoBehaviour {
	
	public UnityEvent OnInteraction;

	void OnTriggerEnter(Collider obj)
	{
		if (obj.CompareTag ("Player")) 
		{
			OnInteraction.Invoke();
		}
	}
}

