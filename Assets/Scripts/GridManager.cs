using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour
{

	public GameObject bubble;
	public Vector3 initialPos;
	public int columns;
	public int rows;
	public int[,] grid;

	void Start()
	{
		grid = new int[columns, rows];

		for (int i = 0; i < columns; i++)
        {
            Vector3 position = new Vector3((float)i * 1.3f, 0f, 0f) + initialPos;
            Create(position);
        }
	}

	public Vector3 Snap(Vector3 position)
	{
		Vector3 objectOffset = position - initialPos;
        Vector3 objectSnap = new Vector3(
            Mathf.Round(objectOffset.x / 1.3f) * 1.3f,
            Mathf.Round(objectOffset.y / 1.3f) * 1.3f,
            0f
        );
        return initialPos + objectSnap;
	}

	public void Create(Vector2 position)
	{
        Vector3 snappedPosition = Snap(position);
        GameObject bubbleClone = (GameObject)Instantiate(bubble, snappedPosition, Quaternion.identity);
        bubbleClone.GetComponent<CircleCollider2D>().isTrigger = true;
        bubbleClone.GetComponent<GridMember>().mother = gameObject;
        Debug.Log(bubbleClone.GetComponent<GridMember>().mother);
        bubbleClone.SetActive(true);
    }
}
