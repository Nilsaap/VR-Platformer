using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public Transform player;
    public Transform startPosition;
    private bool ded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.position = startPosition.position;
        }
        if (ded == true)
        {
            //player.position = Vector3.Lerp(player.position, startPosition.position, 2 * Time.deltaTime);
            
        }
        if(Vector3.Distance(player.position, startPosition.position) <= 0.5)
        {
            ded = false;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            ded = true;
            Debug.Log("fell");
            player.position = startPosition.position;
        }
    }
}
