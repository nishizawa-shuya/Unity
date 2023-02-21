using UnityEngine;

// ブロックが合体する処理
public class UnionBlock : MonoBehaviour
{  
    void Start()
    {
        // gameObjectのログ取得
        Debug.Log(gameObject);
    }

    void Update()
    {

    }

    // 接触判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("当たった");
        if (collision.gameObject.tag == "Block")
        {
            // 現在使用されているマテリアルを取得
            Material mat = this.GetComponent<Renderer>().material;

            // マテリアルの色設定に赤色を設定
            mat.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }
}