using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour {

	//OnTrrigerEnter 何かが自分に接触した時にUnityが自動実行
    //引数にコライダーをセット
    void OnTriggerEnter(Collider col){
        //接触したコライダーがプレイヤータグを持っていた場合
        if(col.gameObject.tag == "Player"){
            //SceneManager.GetActiveScene().name 現在のシーン、つまり現在のシーンを読み込み直す
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
