using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inicializadorJogo : MonoBehaviour
{
    public controladorBola Bolinha;
    public Text TextoPlacarJogador, TextoPlacarAdversario;

    public void ComecarPartida()
    {
        Bolinha.gameObject.transform.localPosition = new Vector2(0, 0);
        Bolinha.enabled = !Bolinha.enabled;

        controladorJogo.PlacarJogador = 0;
        controladorJogo.PlacarAdversario = 0;
        TextoPlacarJogador.text = "Jogador: 0";
        TextoPlacarAdversario.text = "Adversário: 0";
    }
}
