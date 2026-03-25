using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Função do botão INICIAR
    public void IniciarJogo()
    {
        SceneManager.LoadScene("MenuPrincipalScene");
    }

    // Função do botão SAIR
    public void SairJogo()
    {
        Debug.Log("Saiu do jogo");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void IniciarCreditos()
    {
        SceneManager.LoadScene("CreditosScene");
    }
}