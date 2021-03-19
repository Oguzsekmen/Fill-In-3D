using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpwn2 : MonoBehaviour
{
    public static CubeSpwn2 instance;

    [Space]
    [SerializeField]
    private Sprite image;
    [Space]
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    float size = 0.1f;

    Texture2D texture2D;
    Vector3 CubePos = Vector3.zero;

    public List<GameObject> created = new List<GameObject>();


    private void Awake()
    {
        texture2D = image.texture;

        for (int x = 0; x < texture2D.width; x++)
        {
            for (int y = 0; y < texture2D.height; y++)
            {

                Color color = texture2D.GetPixel(x, y);
                if (color.a == 0)
                {
                    continue;
                }
                CubePos = new Vector3(x * size - texture2D.width * .10f, 0f, y * size - texture2D.height * .10f);
                GameObject cubeObj = Instantiate(cube, transform);
                cubeObj.transform.localPosition = CubePos;
                cubeObj.GetComponent<Renderer>().material.color = Color.black;
                created.Add(cubeObj);
            }

        }

    }
}
