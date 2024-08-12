using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour
{
    public Button myButton; // Referência ao botão
    public float blinkInterval = 0.5f; // Intervalo de tempo para o piscar
    private bool isBlinking = false; // Controle para o efeito de piscar
    private Coroutine blinkCoroutine; // Referência para a corrotina de piscar

    void Start()
    {
        if (myButton == null)
        {
            Debug.LogError("Nenhum botão foi atribuído!");
            return;
        }

        myButton.onClick.AddListener(ToggleBlinking); // Adiciona a função ao evento de clique do botão
    }

    void ToggleBlinking()
    {
        if (isBlinking)
        {
            StopBlinking();
        }
        else
        {
            StartBlinking();
        }
    }

    void StartBlinking()
    {
        isBlinking = true;
        blinkCoroutine = StartCoroutine(Blink());
    }

    void StopBlinking()
    {
        isBlinking = false;
        if (blinkCoroutine != null)
        {
            StopCoroutine(blinkCoroutine);
        }
        myButton.image.color = Color.white; // Reseta a cor do botão para branco
    }

    IEnumerator Blink()
    {
        while (isBlinking)
        {
            myButton.image.color = Color.gray; // Define a cor do botão para cinza
            yield return new WaitForSeconds(blinkInterval);
            myButton.image.color = Color.white; // Define a cor do botão para branco
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
