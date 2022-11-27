using DG.Tweening;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace Tarodev {
    public class MissileTarget : MonoBehaviour, IExplode {

        [SerializeField] private UnityEvent FinalEvent;
        [SerializeField] private GameObject targetPoint;
        [SerializeField] private float LerpSpeed;

        [SerializeField] private Rigidbody _rb;
        [SerializeField] private float _size = 10;
        [SerializeField] private float _speed = 10;
        [SerializeField] private MeshRenderer meshRenderer;
         public Rigidbody Rb => _rb;

        public bool allowMove;

        void Update() {

            if (!allowMove) return;
            var dir = new Vector3(Mathf.Cos(Time.time * _speed) * _size, Mathf.Sin(Time.time * _speed) * _size);

            _rb.velocity = dir;
        }

        public void Explode()
        {
            FinalEvent.Invoke();
        }

        public void AllowMove()
        {
            allowMove = true;
        }

        public void CancleMove()
        {
            allowMove = false;
        }

        public void DisableMesh()
        {
            meshRenderer.enabled = false;
        }

        public void moveZep()
        {
            transform.DOMove(targetPoint.transform.position, LerpSpeed);
        }
    }
}