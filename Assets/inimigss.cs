
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    [SerializeField]
    private float _velocidade = 6.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _velocidade * Time.deltaTime);

        if (transform.position.y < -6.40f)
        {
            transform.position = new Vector3(Random.Range(-7.7f, 7.7f), 6.4f, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.DanoAoPlayer();
            }
        }



    }




}
