using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingLava : MonoBehaviour
{
    public float speed = 8.0f;
    private Material mat;
    private Vector2 cOffset;

    // Start is called before the first frame update
    void Start()
    {
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        cOffset.x += speed * Time.deltaTime;
        if (cOffset.x > 1) {
            cOffset.x = 0;
        }
        mat.mainTextureOffset = cOffset;
    }
}
