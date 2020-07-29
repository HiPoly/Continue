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
    private bool gameinplay = false;

    [SerializeField]
    private GameObject Limit1;
    [SerializeField]
    private GameObject Limit2;

    [SerializeField]
    private GameObject Markers;

    void Update()
    {

        if (gameinplay == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SwitchLock();
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
                    transform.position = new Vector3(Mathf.Clamp(mousePos.x, Limit1.transform.position.x, Limit2.transform.position.x), transform.position.y, 0);
                }
                else if (yAble == true)
                {
                    transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePos.y, Limit1.transform.position.y, Limit2.transform.position.y), 0);
                }
            }
        }
    }
    public void SwitchLock()
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

    public void LockGame()
    {
        movable = false;
        gameinplay = true;
    }
    
    public void UnLockGame()
    {
        movable = true;
    }


    private void OnMouseDown()
    {
        if (movable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {


                Markers.SetActive(true);

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

            Markers.SetActive(false);
          
            held = false;
        }

    }


}
