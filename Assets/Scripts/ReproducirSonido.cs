using UnityEngine;
using System.Collections;

public class ReproducirSonido : MonoBehaviour 
{
	public AudioSource Audio;

	void Awake () 
	{
		Audio.Play ();
	}
}
