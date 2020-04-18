using UnityEngine;
using System.Collections;

public class InstanciarNPC1 : MonoBehaviour
{
	public GameObject Prefab;
	public Vector3 Posicion;

	void Awake ()
	{
		Instantiate (Prefab, Posicion, transform.rotation);
	}
}
