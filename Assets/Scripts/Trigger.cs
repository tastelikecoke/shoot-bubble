using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

	void OnMouseDown()
	{
		SceneManager.LoadScene("Level1");
	}
}
