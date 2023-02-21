using UnityEngine;

// バーが移動する処理
public class MoveBar : MonoBehaviour
{
    float chargeTime; // バーのチャージ時間を記憶する
    bool chargeFlgWidth = false; // チャージが完了したかどうかを判定する
    float oldPosX; // 移動前のバーの位置を記憶する

    void Start()
    {
        // gameObjectのログ取得
        Debug.Log(gameObject);
    }

    void Update()
    {
        // gameObjectを削除
        // Destroy(this.gameObject);

        // 右キーで右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            chargeTime += Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)) // キーが離されたなら（チャージ完了したなら）
        {
            // チャージ完了フラグをTRUE
            chargeFlgWidth = true;

            // チャージ完了時点のバーの位置を記憶
            oldPosX = transform.position.x;
        }
        
        // チャージが完了したなら動き出す
        if (chargeFlgWidth)
        {
            // チャージした分だけ動く
            if (transform.position.x >= oldPosX + 2f * chargeTime)
            {
                // チャージした分動ききったら止まる
                chargeFlgWidth = false;
                // gameObjectのログ取得
                Debug.Log(transform.position.x);

                return;
            }

            // バーの移動処理（deltaTimeで計算）
            transform.position += new Vector3(2f * Time.deltaTime, 0f, 0f);
        }
       
    }
}
