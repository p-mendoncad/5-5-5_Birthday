using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using Unity.Mathematics;

public class mudaContador : MonoBehaviour
{   
    public static float tempoDecorrido = 0f;
    public TextMeshProUGUI Texto;
    

    public static int numBaloes = 0;



    // Start is called before the first frame update
    void Start()
    {
        Texto = FindObjectOfType<TextMeshProUGUI>();
    }


    private IEnumerator ShowContadorFuntion()
            {
                Texto.text = "INSPIRE\n0";
                yield return new WaitForSeconds(1.2f);
                Texto.text = "INSPIRE\n1";
                yield return new WaitForSeconds(1f); 
                Texto.text = "INSPIRE\n2";
                yield return new WaitForSeconds(1f);
                Texto.text = "INSPIRE\n3";
                yield return new WaitForSeconds(1f);
                Texto.text = "INSPIRE\n4";
                yield return new WaitForSeconds(1f);
                Texto.text = "INSPIRE\n5";
                yield return new WaitForSeconds(0.2f);
                Texto.text = "SEGURE O AR\n0";
                yield return new WaitForSeconds(1f);
                Texto.text = "SEGURE O AR\n1";
                yield return new WaitForSeconds(1f); 
                Texto.text = "SEGURE O AR\n2";
                yield return new WaitForSeconds(1f);
                Texto.text = "SEGURE O AR\n3";
                yield return new WaitForSeconds(1f);
                Texto.text = "SEGURE O AR\n4";
                yield return new WaitForSeconds(1f);
                Texto.text = "SEGURE O AR\n5";
                yield return new WaitForSeconds(0.2f);
                Texto.text = "ENCHA O BALÃO\n0";
                yield return new WaitForSeconds(1f);
                Texto.text = "ENCHA O BALÃO\n1";
                yield return new WaitForSeconds(1f); 
                Texto.text = "ENCHA O BALÃO\n2";
                yield return new WaitForSeconds(1f);
                Texto.text = "ENCHA O BALÃO\n3";
                yield return new WaitForSeconds(1f);
                Texto.text = "ENCHA O BALÃO\n4";
                yield return new WaitForSeconds(1f);
                Texto.text = "ENCHA O BALÃO\n5";
                yield return new WaitForSeconds(0.2f);
                Texto.text = " ";
                numBaloes++;
                
            }
    // Update is called once per frame
    void Update()
    {
        tempoDecorrido = tempoDecorrido + Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ShowContadorFuntion());
        }

        if(Input.GetKeyDown(KeyCode.Escape) ||Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("Final");
        }
    }
}
