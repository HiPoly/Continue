using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    [SerializeField]
    private bool xAble = false;
    [SerializeField]
    private bool yAble = false;

    private float startPosX;
    private float startPosY;
    private bool held = false;
    private bool movable = true;

    [SerializeField]
    private GameObject Limit1;
    [SerializeField]
    private GameObject Limit2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (movable == true)
            {
                movable = false;
            }
            else
            {
                movable = true;
            }
        }

        if (movable == true)
        {
            if (held == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                if (xAble == true)
                {
                    this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, transform.position.y, 0);
                }
                else if (yAble == true)
                {
                    this.gameObject.transform.localPosition = new Vector3(transform.position.x, mousePos.y - startPosY, 0);
                }
            }
        }


    }

    private void OnMouseDown()
    {
        if (movable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                if (xAble == true)
                {
                    startPosX = mousePos.x - this.transform.localPosition.x;
                }

                else if (yAble == true)
                {
                    startPosY = mousePos.y - this.transform.localPosition.y;
                }

                held = true;
            }
        }
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            held = false;
        }

    }


}
