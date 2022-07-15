using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Face : MonoBehaviour
{
    public short id;
    private Dice _dice;

    private void Awake()
    {
        _dice = GetComponentInParent<Dice>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        _dice.onFaceCollisionEnter?.Invoke(id);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _dice.onFaceCollisionExit?.Invoke();
    }
}