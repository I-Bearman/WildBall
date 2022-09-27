using UnityEngine;
using UnityEngine.UI;

public class CatchBonus : MonoBehaviour
{
    [SerializeField] Collider PlayerCollider;
    [SerializeField] Animator BonusAnim;
    [SerializeField] GameObject ParticalBurst;
    [SerializeField] Text BonusText;
    private static int bonusFound;

    private void Start()
    {
        bonusFound = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollider)
        {
            BonusAnim.SetTrigger("Catch");
            ParticalBurst.SetActive(true);
            BonusText.text = $"You found {++bonusFound}/5 bonuses";
            Destroy(gameObject);
        }
    }
}
