using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pikachu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Masterball" || collision.gameObject.tag == "Pokeball")
        {
            Destroy(this.gameObject);
            Debug.Log("¡Felicidades, has atrapado un Pikachu!");
        }
    }
}
