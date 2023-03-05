using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update

    MeshRenderer shape;
    Vector3 size;
    void Start()
    {
        shapeName = "cube";
        shape = GetComponent<MeshRenderer>();
        size = shape.bounds.size;
    }


    public override float CalculateVolume()
    {
        //Debug.Log("width cube=" + transform.localScale);
        return transform.localScale.x*size.x* transform.localScale.y*size.y * transform.localScale.z*size.z;
    }
}
