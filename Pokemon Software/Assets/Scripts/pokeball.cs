using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokeball : MonoBehaviour, ball
{
    [SerializeField] private GameObject pokeballPre;
    [SerializeField] private Transform inicio;
    [SerializeField] float speed;


    public void Lanzar()
    {
        var pokeball = Instantiate(pokeballPre, inicio.position, inicio.rotation);
        pokeball.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}
