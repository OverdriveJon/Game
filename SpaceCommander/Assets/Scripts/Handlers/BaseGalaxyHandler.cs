using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGalaxyHandler : MonoBehaviour
{
    private Displayer _displayer;
    private BaseSolarSystemHandler _BSSHandler;

	private void Awake()
	{
        _BSSHandler = GetComponent<BaseSolarSystemHandler>();
        _displayer = GameObject.Find("Displayer").GetComponent<Displayer>();
	}

	public IEnumerator CreateGalaxy(Galaxy _galaxy)
    {
        for (int i = 0; i < 3; i++)
        {
            SolarSystem _solarSystem = _BSSHandler.CreateNewSolarSystem();
            _galaxy._solarSystems.Add(_solarSystem);
        }

       foreach(SolarSystem _solarSystem in _galaxy._solarSystems)
        {
           _BSSHandler.CreateNewPlanets(_solarSystem);
       }

        yield return null;
    }
    
    public void DisplayGalaxyInfo(Galaxy _galaxy)
    {
        string _word = "";
        foreach (SolarSystem _system in _galaxy._solarSystems)
        {
            _word+="System: " + _system.GetName() + "\n";
            foreach (Planet _planet in _system._planets)
            {
                _word+=" Planet: " + _planet.GetName()+ "\n";
            }
        }
        _displayer.Type(_word);
    }
}
