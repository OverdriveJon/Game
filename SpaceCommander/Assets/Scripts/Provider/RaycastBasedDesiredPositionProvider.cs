using UnityEngine;

public class RaycastBasedDesiredPositionProvider : MonoBehaviour, IRaycastPosition
{
	Vector3 _desiredPosition;

	public Vector3 GetDesiredPosition()
	{
		return this._desiredPosition;
	}

	public void Check(Ray _ray)
	{
		if (Physics.Raycast(_ray, out RaycastHit _hit))
		{
			this._desiredPosition = _hit.point;

		}
	}
}