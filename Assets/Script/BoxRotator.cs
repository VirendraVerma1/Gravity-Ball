using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRotator : MonoBehaviour
{
   //right for clock wise
   //left for anticlockwise
    public float rotateSpeed = 0.2f;
    public void OnLeftRotation()
    {
        
        StartCoroutine(RotateToDirection(-90));
        

    }

    public void OnRightRotation()
    {
        
        StartCoroutine(RotateToDirection(90));
        
    }

    void FrezeBall()
    {
        GameObject.FindGameObjectWithTag("MyBall").GetComponent<Rigidbody>().isKinematic = true;
    }

    void UnFrezeBall()
    {
        GameObject.FindGameObjectWithTag("MyBall").GetComponent<Rigidbody>().isKinematic = false;
    }

    IEnumerator RotateToDirection(int rotate)
    {
        FrezeBall();
        int n=rotate;
        while (n != 0)
        {
            yield return new WaitForSeconds(rotateSpeed);
            if (n > 0)
            {
                gameObject.transform.Rotate(Vector3.forward, 1f);
                n--;
            }
            else
            {
                gameObject.transform.Rotate(Vector3.forward, -1f);
                n++;
            }
        }
        UnFrezeBall();
    }
}
