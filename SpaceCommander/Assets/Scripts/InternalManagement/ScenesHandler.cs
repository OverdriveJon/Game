using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesHandler : MonoBehaviour
{
	public Generator _generator;

	public void OnNewGameButtonClick() {
		_generator.Generate();
	}
}
