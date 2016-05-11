using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour
{

    public GameObject bubble;
    public Vector3 initialPos;
    public int columns;
    public int rows;

    void Start ()
    {
        
        for(int i = 0; i < columns; i++)
        {
            Vector3 offset = new Vector3((float)i * 1.3f, 0f, 0f);
            GameObject bubbleClone = (GameObject)Instantiate(bubble, initialPos + offset, Quaternion.identity);
            bubbleClone.GetComponent<CircleCollider2D>().isTrigger = true;
            bubbleClone.GetComponent<GridMember>().mother = gameObject;
            bubbleClone.SetActive(true);
        }
    }
	
}
