using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ship : MonoBehaviour
{
    private MovableBody _thisBody;
    private IRayProvider _rayProvider;
    public GameObject MouseHandler;

	float _speed;
    Vector3 _desiredPosition;

	private void Awake()
	{
        _rayProvider = MouseHandler.GetComponent<IRayProvider>();
        _speed = 70.0f;
        _thisBody = new MovableBody(transform, _speed);
	}

	private void Start()
    {
        //
        _desiredPosition = new Vector3(transform.position.x, 0.0f, transform.position.z);
        
    }

	private void Update()
    {
        Ray _ray = _rayProvider.CreateRay();
        if (Input.GetButtonDown("Fire2"))
        { 
            if (Physics.Raycast(_ray, out RaycastHit _hit))
            {
                _desiredPosition = new Vector3(_hit.point.x, 0.0f, _hit.point.z);

            }
        }

        MoveHandler.Move(_thisBody, _desiredPosition, _rayProvider);
    }

    //
	private void OnDrawGizmos()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_desiredPosition, 5.0f);
	}
}
