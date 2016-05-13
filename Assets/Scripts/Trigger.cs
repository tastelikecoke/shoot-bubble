using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
	
	void OnMouseDown ()
	{
		Application.LoadLevel("Level1");
	}
}
