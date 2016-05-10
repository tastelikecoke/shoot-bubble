using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public Transform transform;

    public Rigidbody2D bubble;

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
        Rigidbody2D bubbleClone = (Rigidbody2D) Instantiate(bubble, transform.position, transform.rotation);
        bubbleClone.velocity = transform.rotation * Vector3.forward * 100f;

    }
}
