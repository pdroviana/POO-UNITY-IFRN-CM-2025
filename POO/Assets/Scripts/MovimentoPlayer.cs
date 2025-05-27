using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    private Rigidbody _rigidbody; 
    
    private float velocidade;
     void Start()
     {
         velocidade = gameObject.GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 posicao = transform.position;
        
        //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,-90,0);
        }

        //direira  X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        
        //cima  Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        
        transform.position = posicao;
        
        

    }
}
