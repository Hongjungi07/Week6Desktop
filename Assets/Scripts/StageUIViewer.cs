using UnityEngine;
using TMPro;

public class StageUIViewer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textPlayerHP;
    [SerializeField]
    private TextMeshProUGUI textPlayerGold;
    [SerializeField]
    private PlayerHP playerHP;
    [SerializeField]
    private PlayerGold playerGold;

    private void Update()
    {
        textPlayerHP.text = $"{playerHP.CurrentHP}/{playerHP.MaxHP}";
        textPlayerGold.text = $"{playerGold.CurrentGold}";
    }
}