using UnityEngine;
using System.Collections;

public class GridMember : MonoBehaviour
{
	public GameObject parent;
	public int row;
	public int column;
	public int kind;
	public string state;

	public void Update ()
	{
		if (state == "Pop")
		{
			CircleCollider2D cc = GetComponent<CircleCollider2D>();
			if (cc != null)
				cc.enabled = false;

			transform.localScale = transform.localScale * 0.9f;
			if(transform.localScale.sqrMagnitude < 0.05f)
			{
				Destroy(gameObject);
			}
		}
		else if(state == "Explode")
		{
			CircleCollider2D cc = GetComponent<CircleCollider2D>();
			if (cc != null)
				cc.enabled = false;

			Rigidbody2D rb = GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				rb.gravityScale = 1f;
				rb.velocity = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
			}
			state = "Fall";
		}
		else if(state == "Fall")
		{
			if(transform.position.y < -30f)
			{
				Destroy(gameObject);
			}
		}
	}

}
