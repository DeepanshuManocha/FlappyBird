using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    public GameObject baseSprite;
    public GameObject pipeSprite;
    public GameObject game;
    public List<GameObject> li = new List<GameObject>();
    public Transform CameraTransform;
    int distance=0;
    // Start is called before the first frame update
    void Start()
    {
        float actualWidth = baseSprite.GetComponent<SpriteRenderer>().sprite.rect.width;
        float scaledWidth = (baseSprite.transform.localScale.x * actualWidth)/100.0f;
        CameraTransform = Camera.main.transform;

        for (int i = 0; i < 5; i++)
        {
            float dis = Random.Range(-1.0f, 2.5f);
            GameObject newBaseSprite1 = Instantiate<GameObject>(pipeSprite);
            newBaseSprite1.transform.position = new Vector2(((pipeSprite.transform.position.x)+(i + 1) * scaledWidth), dis);
            newBaseSprite1.transform.SetParent(game.transform);
            li.Add(newBaseSprite1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Random.Range(-1.0f, 2.5f);
        float actualWidth = baseSprite.GetComponent<SpriteRenderer>().sprite.rect.width;
        float scaledWidth = (baseSprite.transform.localScale.x * actualWidth) / 100.0f;
        foreach (var pipe in li)
        {
            if (pipe.transform.position.x + 6 < CameraTransform.position.x)
                pipe.transform.position = new Vector3(pipe.transform.position.x+(scaledWidth * li.Count) ,dis, pipeSprite.transform.position.z);
        }
    }
}