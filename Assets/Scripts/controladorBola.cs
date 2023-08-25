using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorBola : MonoBehaviour
{
    internal int DirecaoVertical = 1;
    internal int DirecaoHorizontal = 1;
    public float VelocidadeBola;
    internal float VelocidadeInicialBola;

    // Start is called before the first frame update
    void Start()
    {
        VelocidadeInicialBola = VelocidadeBola;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(
           gameObject.transform.position.x + (VelocidadeBola * DirecaoHorizontal * Time.deltaTime * 60),
           gameObject.transform.position.y + (VelocidadeBola * DirecaoVertical * Time.deltaTime * 60));

        VelocidadeBola += 0.001f;
    }
}
