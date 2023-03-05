using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public enum ColorEnum { purple, blue, red, green, pink, orange, yellow };
    public Material purpleM, blueM, redM, greenM, pinkM, orangeM, yellowM;
    public Shape[] shapes;//assign
    public Shape selectedShape=null;
    public Light[] selection;//assign
    private Shape shapeScript;
    public TextMeshProUGUI volumeText,nameShape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < 3; i++)
        {
            Shape shape = shapes[i].GetComponent<Shape>();
            if (shape.IsSelected())
            {
                if (selectedShape != shape&& selectedShape!=null)
                {//on garde celui ci..ça veut dire qu'il vient d'être sélectionné
                    
                    selectedShape.GetComponent<Shape>().UnSelect();
                }
                selectedShape = shape;
                
            }
            else
            {
                selection[shape.GetComponent<Shape>().indice].gameObject.SetActive(false);
            }
            selection[i].gameObject.SetActive(shape.IsSelected());
            
        }
        CalculateVolume();


    }


    public void ClickYellow()
    {
        ChangeColor(ColorEnum.yellow);
    }
    public void ClickRed()
    {
        ChangeColor(ColorEnum.red);
    }
    public void ClickBlue()
    {
        ChangeColor(ColorEnum.blue);
    }
    public void ClickPurple()
    {
        ChangeColor(ColorEnum.purple);
    }
    public void ClickGreen()
    {
        ChangeColor(ColorEnum.green);
    }
    public void ClickPink()
    {
        ChangeColor(ColorEnum.pink);
    }



    public void ChangeColor(ColorEnum color)
    {
       
        //Shape shape = selectedShape.GetComponent<Shape>();
        switch (color)
        {
            case ColorEnum.blue:
                {
                    SetMaterial(blueM);
                    break;
                }
            case ColorEnum.purple:
                {
                    SetMaterial(purpleM);
                    break;
                }
            case ColorEnum.pink:
                {
                    SetMaterial(pinkM);
                    break;
                }
            case ColorEnum.red:
                {
                    SetMaterial(redM);
                    break;
                }
            case ColorEnum.green:
                {
                    SetMaterial(greenM);
                    break;
                }
            case ColorEnum.yellow:
                {
                    SetMaterial(yellowM);
                    break;
                }
            case ColorEnum.orange:
                {
                    SetMaterial(orangeM);
                    break;
                }
        }

    }
    private void SetMaterial(Material material)
    {


        for (int i = 0; i < 3; i++)
        {
            Shape shape = shapes[i].GetComponent<Shape>();
            if (shape.IsSelected())
            {
                shape.SetMaterial(material);
            }
        }

    }



    public void IncreaseSpeed()
    {
        for (int i = 0; i < 3; i++)
        {
            Shape shape = shapes[i].GetComponent<Shape>();
            if (shape.IsSelected())
            {
               
                shape.IncreaseSpeed();
            }
        }
    }

    public void DecreaseSpeed()
    {
        for (int i = 0; i < 3; i++)
        {
            Shape shape = shapes[i].GetComponent<Shape>();
            if (shape.IsSelected())
            {
                shape.DecreaseSpeed();
            }
        }
    }

    public void IncreaseSize()
    {
        if (selectedShape != null)
        {

            selectedShape.IncreaseSize();
        }
    }

    public void DecreaseSize()
    {
        if (selectedShape != null)
        {

            selectedShape.DecreaseSize();
        }
    }

    public void CalculateVolume()
    {
        if (selectedShape != null)
        {
            float volume = selectedShape.CalculateVolume();
            volumeText.text = volume.ToString() + " m3";
            ShapeName();
        }
    }

    public void ShapeName()
    {
        nameShape.text="Volume "+selectedShape.GetName()+" :";
    }

}
