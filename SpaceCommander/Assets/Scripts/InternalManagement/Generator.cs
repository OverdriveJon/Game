using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	private BaseGalaxyHandler _BGHandler;
	public Galaxy _galaxy;

	private void Awake()
	{
		_BGHandler = GetComponent<BaseGalaxyHandler>();
	}

	public void Generate()
	{
		StartCoroutine(_BGHandler.CreateGalaxy(_galaxy));
		_BGHandler.DisplayGalaxyInfo(_galaxy);
	}



}
