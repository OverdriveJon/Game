using UnityEngine;

public class MoveHandler : MonoBehaviour
{

    public static void Move(MovableBody _body, Vector3 _desiredPosition,IRayProvider _rayProvider)
	{
        Vector3 _currentPosition;
        Vector3 _direction;
        float _distance;

        _currentPosition = _body.Transform.position;

        _direction = _desiredPosition - _currentPosition;
        _distance = _direction.magnitude;

        if (Mathf.Abs(_distance) <= 1.0f)
        {
            _direction = Vector3.zero;
        }

        _body.Transform.Translate(_direction.normalized * _body.Speed * Time.deltaTime, Space.World);
    }
}
