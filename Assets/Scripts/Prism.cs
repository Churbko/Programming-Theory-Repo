using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;



public class Prism : Shape
{
    // Start is called before the first frame update
    MeshRenderer shape;
    Vector3 size;
    void Start()
    {

        shapeName = "prism";
        shape = GetComponent<MeshRenderer>();
       size=shape.bounds.size;
       
        //Debug.Log("prism =" + size.x +" "+ size.y +" "+ size.z);
    }

    // Update is called once per frame
    public override float CalculateVolume()
    {
        Transform t = GetComponent<ProBuilderMesh>().transform;
        //Debug.Log("height=" + t.localScale.z);
        return ((t.localScale.x*size.x * t.localScale.z*size.z)/2) * t.localScale.y*size.y;
    }

 
    }
