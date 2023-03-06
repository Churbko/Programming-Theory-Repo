using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public Shape[] shapes;//assign
    // Start is called before the first frame update
    void Start()
    {
        FreezeShapes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyPanel()
    {
        //get started the spinning of shapes
        for (int i = 0; i < 3; i++)
        {
            float f= Random.Range(10, 100);
            shapes[i].GetComponent<Shape>().speed = f;
        }
        Destroy(gameObject);

    }

    private void FreezeShapes()
    {
        for (int i = 0; i < shapes.Length; i++)
        {
            shapes[i].GetComponent<Shape>().Freeze();
        }
    }
}
