using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
//INHERITANCE
public class Cylinder : Shape
{
    MeshRenderer shape;
    Vector3 size;
    // Start is called before the first frame update
    private void Start()
    {
        SetName("cylinder");
        shape = GetComponent<MeshRenderer>();
        size = shape.bounds.size;
    }

    //POLYMORPHISM
    public override float CalculateVolume()
    {
        return Mathf.PI * (transform.localScale.x*size.x / 2) * transform.localScale.z*size.z;
    }
}
