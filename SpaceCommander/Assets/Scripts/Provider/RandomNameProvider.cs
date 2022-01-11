using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNameProvider : MonoBehaviour
{
    public string ProvideRandomName<T>()
	{	
		if (typeof(T) == typeof(SolarSystem))
		{
			int randonNumber = Random.Range(0, 2);
			return NamesHolderData.ReturnName<SolarSystem>(randonNumber);
		}
		if (typeof(T) == typeof(Planet))
		{
			int randonNumber = Random.Range(0, 5);
			return NamesHolderData.ReturnName<Planet>(randonNumber);
		}
		return null;
	}
}
