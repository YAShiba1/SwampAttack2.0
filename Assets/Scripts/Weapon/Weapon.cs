using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private bool _isBuyed = false;
    [SerializeField] protected Bullet Bullet;

    public abstract void Shoot(Transform shootPoint);
}
