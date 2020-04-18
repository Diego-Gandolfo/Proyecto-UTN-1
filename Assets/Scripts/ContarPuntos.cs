using UnityEngine;
using System.Collections;

public class ContarPuntos : MonoBehaviour
{
	public int PuntajeAlMorir;

	public void Mori ()
	{
		GameManager.GM.PuntajeTotal = GameManager.GM.PuntajeTotal + PuntajeAlMorir;
	}
}
