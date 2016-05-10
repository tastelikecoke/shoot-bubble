using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

    public GameObject bubble;
    public Vector3 initialPos;

    void Start ()
    {
        
        for(int i = 1; i <= 10; i++)
        {
            Vector3 offset = new Vector3((float)i * 1.0f, 0f, 0f);
            GameObject bubbleClone = (GameObject)Instantiate(bubble, initialPos + offset, Quaternion.identity);

        }
    }
	
	void Update ()
    {
	    
	}
}
