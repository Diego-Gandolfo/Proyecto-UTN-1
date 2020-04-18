using UnityEngine;
using System.Collections;

public class OleadasSuperAleatorias : MonoBehaviour 
{
	public GameObject Prefab;
	public int TiempoMinimo;
	public int TiempoMaximo;
	public int AreaMinima;
	public int AreaMaxima;

	private int Aleatorio;
	
	void Awake () 
	{
		Aleatorio = Random.Range (TiempoMinimo, TiempoMaximo + 1);
		Invoke("Instanciador", Aleatorio);
	}
	
	void Instanciador()
	{
		Vector3 PosicionAleatoria = Vector3.zero;
		
		Aleatorio = Random.Range (TiempoMinimo, TiempoMaximo + 1);

		PosicionAleatoria.x = Random.Range (AreaMinima, AreaMaxima + 1);
		PosicionAleatoria.z = Random.Range (AreaMinima, AreaMaxima + 1);
		PosicionAleatoria.y = transform.position.y;
		
		Instantiate (Prefab, transform.position + PosicionAleatoria, transform.rotation);
		
		Invoke ("Instanciador", (Time.deltaTime * Aleatorio));
	}
}