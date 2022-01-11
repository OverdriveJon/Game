using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
	private string _name;
    public List<Planet> _planets;

	
	public string GetName()
	{
		return _name;
	}

	public void SetName(string _name)
	{
		this._name = _name;
	}

	

	void LoadSolarSystem()
	{
	}

	private void LoadPlanets(List<GameObject> _planets)
	{
		throw new NotImplementedException();
	}

	void Start()
    {
        
    }

    void Update()
    {
        
    }

	[Serializable]
	public class SolarSystemData
	{
		string _name;
		List<Planet> _planets;
	}
}
