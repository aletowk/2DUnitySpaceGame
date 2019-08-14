using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController G_PlayerControllerInstance;
    public float m_speed = 5f;
    public float m_retroSpeed = 1f;
    public float m_angularSpeed = 100f;

    private void OnEnable()
    {
        G_PlayerControllerInstance = this;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_move = Input.GetAxis("Horizontal");
        float vertical_move = Input.GetAxis("Vertical");

        // Rotate Ship
        if (horizontal_move != 0)
        {
            transform.Rotate(0f,0f,- horizontal_move * m_angularSpeed * Time.deltaTime);
        }
        // Translate ship
        if(vertical_move != 0f)
        {
            if(vertical_move > 0f)
                transform.Translate(0f, vertical_move * m_speed * Time.deltaTime, 0f); 
            else
                transform.Translate(0f, vertical_move * m_retroSpeed * Time.deltaTime, 0f);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_speed += 10f;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            m_speed -= 10f;
        }

    }

    
}
