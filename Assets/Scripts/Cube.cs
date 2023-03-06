using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE
public class Cube : Shape
{
    // Start is called before the first frame update

    MeshRenderer shape;
    Vector3 size;
    void Start()
    {
        SetName("cube");
        shape = GetComponent<MeshRenderer>();
        size = shape.bounds.size;
    }


    public override float CalculateVolume()
    {

        return transform.localScale.x*size.x* transform.localScale.y*size.y * transform.localScale.z*size.z;
    }
}
