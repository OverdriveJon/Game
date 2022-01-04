using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    public GameObject planet;
    int xRandom;
    int zRandom;

    void Start()
    {
        CreatePlanets();    
    }

    public void CreatePlanets()
	{
        int n = Mathf.RoundToInt(Random.Range(2.0f, 5.0f));
        
        //Debug.Log(n);
        for (int i = 0; i<n; i++)
		{
            xRandom = Mathf.RoundToInt(Random.Range(0.0f, 360.0f))+(72*(i+1));
            zRandom = Mathf.RoundToInt(Random.Range(0.0f, 360.0f))+(72*(i+1));
            Instantiate(planet, new Vector3(transform.position.x + (200.0f*(i+1)*Mathf.Cos(xRandom)), 0.0f, transform.position.z+(200.0f * (i + 1)*Mathf.Sin(zRandom))), Quaternion.identity);
		}
	}
}
