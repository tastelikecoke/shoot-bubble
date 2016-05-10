using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public Transform transform;

    public GameObject bubble;

	void Start ()
    {
        transform = GetComponent<Transform>();
	}
	
	void Update ()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 delta = mousePos - new Vector2(transform.position.x, transform.position.y);
        transform.rotation = Quaternion.Euler(0f, 0f, 90 - Mathf.Rad2Deg * Mathf.Atan2(delta.x, delta.y));

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire ()
    {
        GameObject bubbleClone = (GameObject) Instantiate(bubble, transform.position, transform.rotation);
        bubbleClone.GetComponent<Rigidbody2D>().velocity = transform.right * 10f;

    }
}
