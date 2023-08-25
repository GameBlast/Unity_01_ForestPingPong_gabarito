using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gol : MonoBehaviour
{
    public bool GolDaEsquerda;
    public Text TextoPlacarJogador, TextoPlacarAdversario;
    public AudioSource AudioPonto;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.StartsWith("Bolinha"))
        {

            if (GolDaEsquerda)
                controladorJogo.PlacarAdversario += 1;
            else
                controladorJogo.PlacarJogador += 1;

            // Ajustar o placar:
            TextoPlacarJogador.text = "Jogador: " + controladorJogo.PlacarJogador;
            TextoPlacarAdversario.text = "Adversário: " + controladorJogo.PlacarAdversario;

            // Voltar bolinha para o centro da tela:
            other.gameObject.transform.localPosition = new Vector2(0, 0);

            // Ajustar velocidade da bolinha
            other.gameObject.GetComponent<controladorBola>().VelocidadeBola =
                other.gameObject.GetComponent<controladorBola>().VelocidadeInicialBola;

            //Tocar som para sinalizar ponto ganho
            AudioPonto.Play();
        }            
    }
}
