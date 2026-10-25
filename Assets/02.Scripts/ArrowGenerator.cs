using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float spawn = 1.0f;
    float delta = 0f;

    public bool isGameOver = false;

    public void ArrowStop()
    {
        isGameOver = true;
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(isGameOver == true)
        {
            return;
        }
        delta += Time.deltaTime;
        if(delta > spawn)
        {
            delta = 0f;
            GameObject go = Instantiate(arrowPrefab);

            go.transform.position = new Vector3(Random.Range(-8.5f, 8.5f), 6f, 0f);
        }
    }
}
