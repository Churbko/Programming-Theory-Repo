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

        return transform.localScale.x * size.x * transform.localScale.z * size.z  * transform.localScale.y * size.y;
    }


}
