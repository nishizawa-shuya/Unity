using UnityEngine;

// �u���b�N�����̂��鏈��
public class UnionBlock : MonoBehaviour
{  
    void Start()
    {
        // gameObject�̃��O�擾
        Debug.Log(gameObject);
    }

    void Update()
    {

    }

    // �ڐG����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("��������");
        if (collision.gameObject.tag == "Block")
        {
            // ���ݎg�p����Ă���}�e���A�����擾
            Material mat = this.GetComponent<Renderer>().material;

            // �}�e���A���̐F�ݒ�ɐԐF��ݒ�
            mat.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }
}