using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlanetHandler : MonoBehaviour
{
	private RandomNameProvider _randomNameProvider;

	private void Awake()
	{
		_randomNameProvider = GetComponent<RandomNameProvider>();
	}
	public Planet CreateNewPlanet()
	{
		Planet _planet = gameObject.AddComponent<Planet>();
		_planet.SetName(_randomNameProvider.ProvideRandomName<Planet>());
		return _planet;
	}
}
