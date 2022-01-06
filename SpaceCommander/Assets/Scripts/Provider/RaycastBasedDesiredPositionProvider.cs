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
			this._desiredPosition = new Vector3(_hit.point.x, 0.0f, _hit.point.z);

		}
	}
}