using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class moveWIthJoystick : MonoBehaviour
{
   
    public CharacterController characterC;
    public float speed = 8.0f;
    public float jumpSpeed = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = -Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickHorizontal");
        float v = -Input.GetAxis("Oculus_CrossPlatform_PrimaryThumbstickVertical");
        Vector3 dir = new Vector3(h, 0, v);
        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryThumbstick"))
        {
            dir.y = jumpSpeed;
        }
        Debug.Log(OVRInput.Axis2D.PrimaryThumbstick);
        characterC.Move(dir * Time.deltaTime * speed);
        
    }
}
