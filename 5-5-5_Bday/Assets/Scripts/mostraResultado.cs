using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;



public class mostraResultado : MonoBehaviour
{   
    public int minutos = 0;
    public int segundos = 0;

    string tempoFormatado;

   public TextMeshProUGUI Placar;
    
    string baloes = mudaContador.numBaloes.ToString();
    float tempoSessao = mudaContador.tempoDecorrido;
    // Start is called before the first frame update
    void formataTempo(float tempoSegundos)
    {
         minutos = Mathf.FloorToInt(tempoSegundos / 60);
         segundos = Mathf.FloorToInt(tempoSegundos % 60);
         Debug.Log(segundos);

        minutos.ToString();
        segundos.ToString();
        tempoFormatado = "\nTEMPO: " + minutos + " minuto(s) e " + segundos + " segundo(s)";
        baloes+=tempoFormatado;
        Debug.Log(tempoFormatado);

    }
    void Start()
    {
        Placar = FindObjectOfType<TextMeshProUGUI>();
        formataTempo(tempoSessao);

        Placar.text += baloes;


        Debug.Log(tempoFormatado);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) ||Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarJogo();
        }
       
    }

     void ReiniciarJogo()
    {
        // Reinicializar variáveis do jogo
        mudaContador.numBaloes = 0;
        mudaContador.tempoDecorrido = 0f;

        SceneManager.LoadScene("Inicio");
    }
}

