using UnityEngine;
using System.Collections;

public class OleadasAleatorias : MonoBehaviour
{
	public GameObject NPC;
	public int TiempoMinimo;
	public int TiempoMaximo;
	public int TiempoMinimoBase;
	public int TiempoMaximoBase;
	public GameManager GM;

	private int Aleatorio;

	void Awake () 
	{
		TiempoMinimo = TiempoMinimoBase / GM.Dificultad;
		TiempoMaximo = TiempoMaximoBase / GM.Dificultad;

		Aleatorio = Random.Range (TiempoMinimo, TiempoMaximo + 1);
		Invoke("Instanciador", Aleatorio / 5);
	}

	void Instanciador()
	{
		Aleatorio = Random.Range (TiempoMinimo, TiempoMaximo + 1);

		Instantiate (NPC, transform.position, transform.rotation);

		Invoke ("Instanciador", Aleatorio);
	}
}