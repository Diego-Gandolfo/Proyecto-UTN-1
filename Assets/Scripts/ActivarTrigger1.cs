using UnityEngine;
using System.Collections;

public class ActivarTrigger1 : MonoBehaviour
{
	public GameObject Objeto1;
	public Vector3 Posicion1;
	public GameObject Objeto2;
	public Vector3 Posicion2;

	void OnTriggerEnter()
	{
		Instantiate (Objeto1, Posicion1, transform.rotation);
		Instantiate (Objeto2, Posicion2, transform.rotation);
		Destroy (gameObject);
	}
}
