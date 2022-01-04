using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ship : MonoBehaviour
{

    float m_Speed;
    Vector3 m_mousePos;
    public Camera camera;
    ///public NavMeshAgent myAgent; 
    // Start is called before the first frame update
    void Start()
    {
        m_Speed = 70.0f;
        desPos = new Vector3(transform.position.x, 0.0f, transform.position.z);
        
    }

    public static Vector3 desPos;
    Vector3 atualPos;
    public static Vector3 direction;
    public static Vector3 distance;
    
    void Update()
    {
        m_mousePos = Input.mousePosition;
        atualPos = new Vector3(transform.position.x, 0.0f, transform.position.z);

        if (Input.GetButtonDown("Fire2"))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(m_mousePos);
        
            if(Physics.Raycast(ray, out hit))
        	{
                desPos = new Vector3(hit.point.x, 0.0f, hit.point.z);
                transform.LookAt(new Vector3(desPos.x, 2.0f, desPos.z));
            }
        }
        direction = desPos - atualPos;
        distance = desPos - atualPos;
       
        if (Mathf.Abs(distance.magnitude) <= 1.0f)
            {
                //Debug.Log("DesPos="+desPos.magnitude);
                //Debug.Log("AtualPos=" + atualPos.magnitude);
                //Debug.Log(Mathf.Abs(distance.magnitude));
                direction = Vector3.zero;
            }
        
        transform.Translate(direction.normalized * m_Speed * Time.deltaTime, Space.World);

        //Debug.Log("DesPos=" + desPos);
        //Debug.Log("Direction=" + direction);

    }

	private void FixedUpdate()
	{
        Debug.DrawLine(atualPos, desPos, Color.red, 0.5f, false);
    }

	private void OnDrawGizmos()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(desPos, 5.0f);
	}

	private void OnCollisionStay(Collision collision)
	{
		if(collision.collider.name == "Orbit")
		{
            m_Speed = 0.0f;
		}
	}

    
}
