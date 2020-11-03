using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour {

    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;

	// Use this for initialization
	void Start () {
        //PlayerPrefs データのセーブを行うクラス
        //ハイスコアがある場合はその値を格納しておく
        if(PlayerPrefs.HasKey("HighScore")){
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else{
            highScore = 999;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //ゴールクラスの変数がtrueになった時
        if(Goal.goal){
            //UIオブジェクトをtrueにして表示させるようにする
            resultUI.SetActive(true);

            int result = Mathf.FloorToInt(Timer.time);

            //結果と前回までのベストタイムを格納
            resultTime.text = "ResultTime" + result;
            bestTime.text = "BestTime" + highScore;

            if (highScore > result)
            {
                //ハイスコアのキー値でresultを格納
                PlayerPrefs.SetInt("HighScore", result);
            }
        }
	}

    //ロード時にはスタート画面から表示させる
    public void OnRetry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
