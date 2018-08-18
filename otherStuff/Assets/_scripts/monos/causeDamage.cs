using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class causeDamage : MonoBehaviour {

	public UnityEvent onDamage;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			onDamage.Invoke();
		}
	}
}
