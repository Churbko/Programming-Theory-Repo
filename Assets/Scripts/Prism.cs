using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;


//INHERITANCE
public class Prism : Shape
{
    // Start is called before the first frame update
    MeshRenderer shape;
    Vector3 size;
    void Start()
    {

        SetName("prism");
        shape = GetComponent<MeshRenderer>();
        size = shape.bounds.size;

    }

    // Update is called once per frame
    public override float CalculateVolume()
    {
        Transform t = GetComponent<ProBuilderMesh>().transform;
        return ((t.localScale.x * size.x * t.localScale.z * size.z) / 2) * t.localScale.y * size.y;
    }


}
