using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
	public GameObject ball;
	public GameObject load;

	public const float LAUNCH_SPEED = 15f;

	void Start()
	{
		Load();
	}

	void Update()
	{
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 delta = mousePos - new Vector2(transform.position.x, transform.position.y);
		transform.rotation = Quaternion.Euler(0f, 0f, 90 - Mathf.Rad2Deg * Mathf.Atan2(delta.x, delta.y));

		if (Input.GetMouseButtonDown(0))
		{
			Fire();
		}
	}

	public void Load()
	{
		if (load == null)
		{
			load = (GameObject)Instantiate(ball, transform.position, transform.rotation);
			load.SetActive(true);

			CircleCollider2D collider = load.GetComponent<CircleCollider2D>();
			if (collider != null)
				collider.enabled = false;

			Hitter hitter = load.GetComponent<Hitter>();
			if (hitter != null)
				hitter.parent = gameObject;
		}
	}

	void Fire()
	{
		if (load != null)
		{

			CircleCollider2D collider = load.GetComponent<CircleCollider2D>();
			if (collider != null)
				collider.enabled = true;

			Rigidbody2D rb = load.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				rb.velocity = transform.right * LAUNCH_SPEED;
			}
		}
	}
}
