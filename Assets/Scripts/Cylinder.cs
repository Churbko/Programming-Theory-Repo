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
        Transform t = GetComponent<ProBuilderMesh>().transform;
        return Mathf.PI * (t.localScale.x*size.x / 2) * t.localScale.z*size.z;
    }
}
