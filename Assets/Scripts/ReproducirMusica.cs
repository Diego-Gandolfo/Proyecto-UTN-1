using UnityEngine;
using System.Collections;

public class ReproducirMusica : MonoBehaviour 
{
	public AudioSource Audio;
	
	void Awake () 
	{
		Audio.Play ();
	}
}