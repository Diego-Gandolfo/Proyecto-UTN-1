using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModificarBarraVida : MonoBehaviour 
{
	void Update () 
	{
		Vida vVida = gameObject.GetComponentInParent<Vida>();

		Image Imagen = GetComponent<Image>();
		Imagen.fillAmount = (vVida.VidaActual / vVida.VidaMaxima);
	}
}
