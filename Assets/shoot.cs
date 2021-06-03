using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    bool shot;
    public Transform fingerTip;
    public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") > 0.1f && shot == false)
        {
            shot = true;
            PewPew();
            Debug.Log("hi");
        }
        else if(Input.GetAxis("Oculus_CrossPlatform_SecondaryHandTrigger") == 0 && shot == true)
        {
            shot = false;
        }
        
    }

    public void PewPew()
    {
        RaycastHit hit;
        if (Physics.Raycast(fingerTip.position, fingerTip.forward, out hit, 100, layerMask))
        {
            Debug.Log("pewpew");
            Debug.Log(hit.transform.gameObject.name);
        }
    }
}
