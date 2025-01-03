using UnityEngine;

public class test : MonoBehaviour
{
public Rigidbody rb;
public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter() 
    {  
        if (Collision == rb) 
        {  
            rb.addForce(rb.forward * speed, forceMode.Acceleration);

        }

    }
}
