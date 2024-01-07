using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mudaContador : MonoBehaviour
{   
    public TextMeshProUGUI Texto;
    // Start is called before the first frame update
    void Start()
    {
        Texto = FindObjectOfType<TextMeshProUGUI>();
    }

private IEnumerator ShowContadorFuntion()
        {
            Texto.text = "INSPIRE\n0";
            yield return new WaitForSeconds(1.5f);
            Texto.text = "INSPIRE\n1";
            yield return new WaitForSeconds(1f); 
            Texto.text = "INSPIRE\n2";
            yield return new WaitForSeconds(1f);
            Texto.text = "INSPIRE\n3";
            yield return new WaitForSeconds(1f);
            Texto.text = "INSPIRE\n4";
            yield return new WaitForSeconds(1f);
            Texto.text = "INSPIRE\n5";
            yield return new WaitForSeconds(0.5f);
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
            yield return new WaitForSeconds(0.5f);
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
            yield return new WaitForSeconds(0.5f);
            Texto.text = " ";
        }
    // Update is called once per frame
    void Update()
    {
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
