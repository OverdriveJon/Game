using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BaseShipHandler : MonoBehaviour
{
    private MovableBody _thisBody;
    private IRayProvider _rayProvider;
    private IRaycastPosition _DPSetter;
    public GameObject MouseHandler;

	float _speed;
    Vector3 _desiredPosition;

	private void Awake()
	{
        _rayProvider = MouseHandler.GetComponent<IRayProvider>();
        _DPSetter = MouseHandler.GetComponent<IRaycastPosition>();
        _speed = 70.0f;
        _thisBody = new MovableBody(transform, _speed);
	}

	private void Start()
    {
        _desiredPosition = transform.position;
        
    }

	private void Update()
    {
     
        if (Input.GetButtonDown("Fire2"))
        {
            _DPSetter.Check(_rayProvider.CreateRay());
            _desiredPosition = _DPSetter.GetDesiredPosition();
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
