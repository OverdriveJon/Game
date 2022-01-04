using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    Vector3 m_mousePos;
    public Camera camera;
    public Transform currentTarget;
    
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentTarget);
        m_mousePos = Input.mousePosition;
        CheckIfMouseDownOnPlanet();
        Debug.Log(currentTarget);
              
    }

	private void FixedUpdate()
	{
        Hoover();
    }

	void Hoover()
	{
        RaycastHit hit;
        ray = camera.ScreenPointToRay(m_mousePos);

        if (currentTarget != null)
        {
            currentTarget.gameObject.layer = LayerMask.NameToLayer("Planet");
            currentTarget = null;
        }

        if (Physics.Raycast(ray, out hit, 2000.0f, LayerMask.GetMask("Planet")))
        {
            var target = hit.transform;
            currentTarget = target;
            currentTarget.gameObject.layer = LayerMask.NameToLayer("Hoovered");
        }
    }

    void CheckIfMouseDownOnPlanet()
	{
		if (Input.GetButtonDown("Fire1"))
		{
            RaycastHit hit;
            Ray rayMouse = camera.ScreenPointToRay(m_mousePos);
            if(Physics.Raycast(ray, out hit, 2000.0f, LayerMask.GetMask("Hoovered"))){
                Ship.desPos = hit.transform.position;
			}
        }
	}
}
