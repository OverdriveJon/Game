using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSolarSystemHandler : MonoBehaviour
{
	private BasePlanetHandler _BPHandler;
	private RandomNameProvider _randomNameProvider;

	private void Awake()
	{
		_BPHandler = GetComponent<BasePlanetHandler>();
		_randomNameProvider = GetComponent<RandomNameProvider>();
	}
	public SolarSystem CreateNewSolarSystem()
	{
		SolarSystem _solarSystem = gameObject.AddComponent<SolarSystem>();
		_solarSystem.SetName(_randomNameProvider.ProvideRandomName<SolarSystem>());
		_solarSystem._planets = new List<Planet>();
		return _solarSystem;
	}

	public void CreateNewPlanets(SolarSystem _solarSystem)
	{
		for (int i = 0; i < 5; i++)
		{
			Planet _planet = _BPHandler.CreateNewPlanet();
			_solarSystem._planets.Add(_planet);
		}
	}
}
