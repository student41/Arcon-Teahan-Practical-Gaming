using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviroment_Generation : MonoBehaviour {

	// Use this for initialization
	void Start () {


        int x = -21;
        int z = -21;
        int i = 0;

        while (x < 21)
        {
            while (z < 21)
            {
  GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.position = new Vector3(x, 0.5f, z);
                z++;
            }
            z = -21;
            x++;
        }

        while (x < 21)
        {
            while (z < 21)
            {
                GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
                floor.transform.position = new Vector3(-21, x, z);
                z++;
            }
            z = -21;
            x++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
