
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Shape : MonoBehaviour
{
    
 
   // [SerializeField] private string color;
    [SerializeField] private Vector3 rotationAxe = new Vector3(0, 0, 1);
    public float speed = 1;
    public string shapeName;
    [SerializeField] private bool selected=false;
    public int indice;
    private int increment = 10;
    private float increaseIncrement = 0.02f;

    private float m_speed
    {
        get
        {
            return speed;
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



    protected void Rotate()
    {
        transform.Rotate(m_speed * Time.deltaTime * rotationAxe);
    }



    // Start is called before the first frame update
    void Start()
    {
        shapeName = "simple shape";
        Debug.Log("This shape is a ..." + shapeName);
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
        if (transform.localScale.x>=0)
            transform.localScale -= new Vector3(increaseIncrement, increaseIncrement, increaseIncrement);
        
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
        speed += increment;
    }
    public void DecreaseSpeed()
    {

        speed -= increment;
        if (speed < 0)
            speed = 0;
    }

}
