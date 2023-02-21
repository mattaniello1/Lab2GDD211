using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    int FruitCount;
    public TextMeshProUGUI fc;
    [SerializeField] private Slider slider1;
    [SerializeField] private Slider slider2;
    [SerializeField] private Button Spawn;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject apple;


  
    private void Update()
    {
        fc.text = FruitCount.ToString();

        Vector3 move = new Vector3(slider1.value * 2, 0, slider2.value * 3);

        transform.position += move * Time.deltaTime;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            addPoints();
            Destroy(collision.gameObject);
        }
    }
    void addPoints()
    {
        FruitCount += 1;
    }
    public void Spawner()
    {
        Instantiate(apple, new Vector3(Random.Range(-3.5f, 5.3f), 4, Random.Range(-9, 3)), Quaternion.identity);
    }
}
