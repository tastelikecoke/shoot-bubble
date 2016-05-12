using UnityEngine;
using System.Collections;

public class Hitter : MonoBehaviour
{
	public int kind;
	public GameObject parent;

	void Start ()
	{
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
		if(spriteRenderer != null)
		{
			float lot = Random.Range(0f, 3f);
			if (0f <= lot && lot <= 1f)
			{
				spriteRenderer.color = Color.red;
				kind = 1;
			}
			if (1f <= lot && lot <= 2f)
			{
				spriteRenderer.color = Color.blue;
				kind = 2;
			}
			if (2f <= lot && lot <= 3f)
			{
				spriteRenderer.color = Color.yellow;
				kind = 3;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider != null)
		{
			CircleCollider2D selfcollider = GetComponent<CircleCollider2D>();
			if(selfcollider != null)
			{
				selfcollider.enabled = false;
			}
			GridManager gridManager = parent.GetComponent<GridManager>();
			if (gridManager != null)
			{
				GameObject newBubble = gridManager.Create(transform.position, kind);
				GridMember gridMember = newBubble.GetComponent<GridMember>();
				gridManager.Seek(gridMember.column, -gridMember.row, gridMember.kind);
			}
			Launcher launcher = parent.GetComponent<Launcher>();
			if (launcher != null)
			{
				launcher.load = null;
				launcher.Load();
			}
			Destroy(gameObject);
		}
	}
}
