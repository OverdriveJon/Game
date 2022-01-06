using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetClass : MonoBehaviour
{
    string name;
    
    public float diameter;
    public Color color;

    ///public GameObject orbit;
    float n;
    float randomR;
    float randomG;
    float randomB;
    void Start()
    {

        n = Random.Range(30.0f, 70.0f);
        randomR=Random.Range(50.0f, 150.0f);
        randomG=Random.Range(50.0f, 90.0f);
        randomB=Random.Range(50.0f, 200.0f);
        //Debug.Log(n);
        diameter = n;
        name = "Calaban-" + Mathf.RoundToInt(n);
        color = new Color(n/randomR, n/randomG, n/randomB, 1.0f);
       //Debug.Log(color);
        transform.localScale = Vector3.one * diameter;
        transform.name = name;
        transform.GetComponent<Renderer>().material.SetColor("_Color", color);
        transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);

        //orbit.transform.localScale = Vector3.one * (diameter/(diameter)+1.0f);
    }

    void Update()
    {
        
    }
  
}
