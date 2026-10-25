using TreeEditor;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float moveSpeed;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate(0, -moveSpeed, 0);

        if (transform.position.y <= -6.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position; //화살표의 중심 좌표
        Vector2 p2 = player.transform.position; //플레이어의 중심 좌표
        Vector2 dir = p1 - p2; //방향
        float d = dir.magnitude; //거리
        float r1 = 0.5f; //화살의 반지름 반경
        float r2 = 1.0f; //플레이어의 반지름 반경

        if(d < r1 + r2)
        {
            //GameManager 스크립트에 플레이어와 화살이 충돌했으니 피를 깎으라고 전달
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<GameManager>().DecreaseHP(); //피를 깎는 함수 실행

            Destroy(gameObject);
        }
    }
}
