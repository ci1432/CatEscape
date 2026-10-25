using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image hpGauge; //이미지 오브젝트 연결하기 위한 변수
    public GameObject gameOver_Text;
    public GameObject arrowGenerator; //제너레이터 되는 오브젝트 연결하기 위한 변수

    private void Start()
    {
        arrowGenerator = GameObject.Find("ArrowGenerator");
    }
    public void DecreaseHP()
    {
        hpGauge.fillAmount -= 0.25f;
    }

    void Update()
    {
        if (hpGauge.fillAmount < 0.1f)
        {
            arrowGenerator.GetComponent<ArrowGenerator>().ArrowStop();
            //gameOver_Text.text = "게임 오버!";
            gameOver_Text.SetActive(true);
        }
    }
}
