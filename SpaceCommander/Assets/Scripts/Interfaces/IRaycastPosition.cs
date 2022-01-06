using UnityEngine;

public interface IRaycastPosition
{
	void Check(Ray _ray);
	Vector3 GetDesiredPosition();
}