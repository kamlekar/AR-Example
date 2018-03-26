using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //render Black color
    public void BlackColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    //render Blue color
    public void BlueColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    //render Greycolor
    public void GreyColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }


    //render Red color
    public void RedColor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }
}