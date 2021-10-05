using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterball : MonoBehaviour, ball
{
    [SerializeField] private GameObject masterballPre;
    [SerializeField] private Transform inicioM;
    [SerializeField] float speed;
    private GameObject pokeball;

    public void Lanzar()
    {
        pokeball = Instantiate(masterballPre, inicioM.position, inicioM.rotation);
        pokeball.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}
