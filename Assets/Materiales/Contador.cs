using TMPro;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public static int contador = 0;
    public static int dororosEliminados = 0;
    [SerializeField] 
    private TextMeshProUGUI UIContador;
    [SerializeField]
    private TextMeshProUGUI UIContadorDororos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIContador.text = "Score: " + contador.ToString();
        if(dororosEliminados > 0 && dororosEliminados<4)
        {
            UIContadorDororos.text = "Dororos eliminados: " + dororosEliminados.ToString();
        }
        if(dororosEliminados == 4)
        {
            UIContadorDororos.text = "Se acabo el juego...";
            UIContadorDororos.text += "\nRecargue la pagina para reiniciar";
        }
    }
}
