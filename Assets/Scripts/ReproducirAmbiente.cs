using UnityEngine;
using System.Collections;

public class ReproducirAmbiente : MonoBehaviour 
{
	public AudioSource Audio;
	
	void Awake () 
	{
		Audio.Play ();
	}
}