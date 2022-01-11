using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private string _name;
    public int size;

    public void SetName(string name)
	{
        this._name = name;
	}

    public string GetName()
    {
        return _name;
    }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


    [Serializable]
    public class PlanetData
	{
        string name;
        int size;
	}
}
