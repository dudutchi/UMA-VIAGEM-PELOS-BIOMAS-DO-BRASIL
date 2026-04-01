using UnityEngine;
using TMPro;

[System.Serializable]
public class Pergunta
{
    public string enunciado;
    public string[] alternativas;
    public int respostaCorreta;
}

public class QuizManager : MonoBehaviour
{
    public TextMeshProUGUI textoPergunta;
    public TextMeshProUGUI[] textosAlternativas;

    public Pergunta[] perguntas;

    private int perguntaAtual = 0;

    void Start()
    {
        MostrarPergunta();
    }

    void MostrarPergunta()
    {
        Pergunta p = perguntas[perguntaAtual];

        textoPergunta.text = p.enunciado;

        for (int i = 0; i < textosAlternativas.Length; i++)
        {
            textosAlternativas[i].text = p.alternativas[i];
        }
    }

    public void Responder(int indice)
    {
        if (indice == perguntas[perguntaAtual].respostaCorreta)
        {
            Debug.Log("Acertou!");
        }
        else
        {
            Debug.Log("Errou!");
        }

        perguntaAtual++;

        if (perguntaAtual < perguntas.Length)
        {
            MostrarPergunta();
        }
        else
        {
            Debug.Log("Fim do quiz");
        }
    }
}
