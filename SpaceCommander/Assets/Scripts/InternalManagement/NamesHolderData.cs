using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamesHolderData {
	private static string[] SystemNames = {
		"Solar",
		"Vardius",
		"Capazes"
	};
	private static string[] SunNames = {
		"Beltegeuse",
		"Sol",
		"Palam"
	};
	private static string[] PlanetNames = {
		"Arrakis",
		"Terra",
		"Elternu",
		"Krypton",
		"Lordan",
		"Maracanã"
	};

	public static string ReturnName<T>(int i)
	{
		if (typeof(T) == typeof(SolarSystem))
			return SystemNames[i];
		if (typeof(T) == typeof(Planet))
			return PlanetNames[i];
		return null;
	}
}
