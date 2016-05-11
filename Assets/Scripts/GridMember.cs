using UnityEngine;
using System.Collections;

public class GridMember : MonoBehaviour
{
    public GameObject mother;
	void Start ()
    {
	}
	
	void Update ()
    {
	
	}
    void OnTriggerEnter2D (Collider2D collider)
    {
        Transform t = collider.gameObject.GetComponent<Transform>();
        Destroy(collider.gameObject);
        mother.GetComponent<GridManager>().Create(t.position);
    }
}
