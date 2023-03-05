
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Shape : MonoBehaviour
{
    public string shapeName;
    public int indice;// see if this variable can be encapsulated

    [SerializeField] private Vector3 rotationAxe = new Vector3(0, 0, 1);
    [SerializeField] private float m_speed = 1;

    private bool selected=false;
    private readonly int increment = 10;
    private readonly float increaseIncrement = 0.02f;

    public float speed
    {
        get
        {
            return m_speed;
        }
        set
        {

            if (value < 0)
            {
                m_speed = 0;
            }
            else
                m_speed = value;

        }

    }
    

    public string GetName()
    {
        return shapeName;
    }

    protected void SetName(string name)
    {
        shapeName = name;
    }

    protected void Rotate()
    {
        transform.Rotate(m_speed * Time.deltaTime * rotationAxe);
    }



    // Start is called before the first frame update
    void Start()
    {
        shapeName = "simple shape";
       // material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }



    public virtual void IncreaseSize() {
        if (transform.localScale.x <= 1.5)
            transform.localScale += new Vector3(increaseIncrement, increaseIncrement, increaseIncrement);
    } 
    public virtual void DecreaseSize()
    {
        
        transform.localScale -= new Vector3(increaseIncrement, increaseIncrement, increaseIncrement);
        if (CalculateVolume()<0)
            transform.localScale += new Vector3(increaseIncrement, increaseIncrement, increaseIncrement);
    }

    private void OnMouseDown()
    {
        
        selected = true;

        //SetMaterial(newMaterial);
    }

    public void SetMaterial(Material m)
    {
        if (selected)
        {
            GetComponent<Renderer>().material = m;
        }
        
    }

    public abstract float CalculateVolume();
    public bool IsSelected()
    {
        //Debug.Log(this + " " + selected);
        return selected;
    }
    public void UnSelect()
    {
        selected = false;
    }
    public void IncreaseSpeed()
    {
        m_speed += increment;
    }
    public void DecreaseSpeed()
    {

        m_speed -= increment;
       /* if (speed < 0)
            speed = 0;*/
    }

    protected void SetRotation(Vector3 v)
    {
        rotationAxe = new Vector3(v.x, v.y, v.z);
    }

}
