using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
	public GameObject bubble;
	Transform t;

	void Start ()
	{
		t = GetComponent<Transform>();
	}
	
	void Update ()
	{
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 delta = mousePos - new Vector2(t.position.x, t.position.y);
		t.rotation = Quaternion.Euler(0f, 0f, 90 - Mathf.Rad2Deg * Mathf.Atan2(delta.x, delta.y));

		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}

	void Fire ()
	{
		GameObject bubbleClone = (GameObject) Instantiate(bubble, t.position, t.rotation);
		bubbleClone.SetActive(true);
		bubbleClone.GetComponent<Rigidbody2D>().velocity = transform.right * 10f;
	}
}
