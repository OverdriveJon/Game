using UnityEngine;

public struct MovableBody
{
    public Transform Transform;
    public float Speed;

	public MovableBody(Transform transform, float speed)
	{
        Transform = transform;
		Speed = speed;
	}
}
