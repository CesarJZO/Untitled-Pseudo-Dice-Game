using System;
using UnityEngine;
using UnityEngine.Events;

public class Dice : MonoBehaviour
{
    public float rotation;
    public UnityEvent<short> onFaceCollisionEnter;
    public UnityEvent onFaceCollisionExit;
    public Face[] faces;

    [SerializeField] private float smoothTime;
    private float _rotateTimer;
    private float _velocity;
    
    public void DisableAllOtherFaces(short id)
    {
        for (var i = 0; i < faces.Length; i++)
        {
            if (i == id) break;
            faces[i].GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void EnableFaces()
    {
        foreach (var face in faces) 
            face.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void OnRotateRight()
    {
        transform.Rotate(0,0, -rotation);
    }
    
    public void OnRotateLeft()
    {
        transform.Rotate(0,0, rotation);
    }
}