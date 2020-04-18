using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FocusBoton : MonoBehaviour 
{
	void Start () 
	{
		Button b = GetComponent<Button>();

		b.Select ();
	}
}
