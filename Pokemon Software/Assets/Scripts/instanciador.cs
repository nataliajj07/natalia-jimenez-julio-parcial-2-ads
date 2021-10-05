using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
{
    [SerializeField] private player playerPrefab;
    [SerializeField] private pokeball pokeballPrefab;
    [SerializeField] private masterball masterballPrefab;
    private player player;
    private ball ball;
    private bool isPokeball = true;


    private void Awake()
    {
        player = Instantiate(playerPrefab);
        ball = GetBall(player.transform);
        player.SetBall(ball);
    }

    private ball GetBall(Transform padre)
    {
        if (isPokeball)
        {
            return Instantiate(pokeballPrefab, padre);
        }
        else
            return Instantiate(masterballPrefab, padre);
    }

    private void CambiarBall()
    {
        Destroy(player.transform.GetChild(0).gameObject);
        ball = GetBall(player.transform);
        player.SetBall(ball);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            isPokeball = !isPokeball;
            CambiarBall();
        }
    }
}
