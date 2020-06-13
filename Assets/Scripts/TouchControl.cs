using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public static int playerTurnAxisTouch = 0;
    public static string shif;
    public static int salto = 0;

    void Start()
    {
        playerTurnAxisTouch = 0;
        shif = "a";
        salto = 0;
    }

    public void playerLeftUIPointerDown()
    {
        playerTurnAxisTouch = -1;
    }

    public void playerLeftUIPointerUp()
    {
        playerTurnAxisTouch = 0;
    }

    public void playerLeftUIPointerDownR()
    {
        playerTurnAxisTouch = 1;
    }

    public void playerLeftUIPointerUpR()
    {
        playerTurnAxisTouch = 0;
    }

    public void shiftDown()
    {
        shif = "s";
    }

    public void shiftUp()
    {
        shif = "a";
    }

    public void saltoDown()
    {
        salto = -1;
    }

    public void saltoUp()
    {
        salto = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
