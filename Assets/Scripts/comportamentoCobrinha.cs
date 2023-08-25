using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoCobrinha : MonoBehaviour
{
    public bool Cobrinha01;
    public float VelocidadeDaCobrinha;

    // Update is called once per frame
    void Update()
    {
        // Se for a cobrinha 01
        if (Cobrinha01)
        {
            if (Input.GetKey(KeyCode.T))
            {
                gameObject.transform.position =
                    new Vector2(gameObject.transform.position.x, Mathf.Min(365,
                    gameObject.transform.position.y + (VelocidadeDaCobrinha * Time.deltaTime * 60)));

                gameObject.transform.localScale = new Vector2(1, 1);
            }
            else if (Input.GetKey(KeyCode.G))
            {
                gameObject.transform.position =
                    new Vector2(gameObject.transform.position.x, Mathf.Max(135,
                    gameObject.transform.position.y - (VelocidadeDaCobrinha * Time.deltaTime * 60)));

                gameObject.transform.localScale = new Vector2(-1, -1);
            }
        }
        //Se for a cobrinha 02
        else
        {
            if (Input.GetKey(KeyCode.O))
            {
                gameObject.transform.position =
                    new Vector2(gameObject.transform.position.x, Mathf.Min(365,
                    gameObject.transform.position.y + (VelocidadeDaCobrinha * Time.deltaTime * 60)));

                gameObject.transform.localScale = new Vector2(1, 1);
            }
            else if (Input.GetKey(KeyCode.L))
            {
                gameObject.transform.position =
                    new Vector2(gameObject.transform.position.x, Mathf.Max(135,
                    gameObject.transform.position.y - (VelocidadeDaCobrinha * Time.deltaTime * 60)));

                gameObject.transform.localScale = new Vector2(-1, -1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("Bolinha"))
            other.gameObject.GetComponent<controladorBola>().DirecaoHorizontal *= -1;
    }
}
