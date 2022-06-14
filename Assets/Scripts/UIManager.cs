using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public static int _score;
    [SerializeField]
    private Text _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        //_scoreText.text = "0";
        //Debug.Log(_scoreText.text);
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = _score.ToString();
    }
    public static void AddScore()
    {
        _score++;
    }
}
