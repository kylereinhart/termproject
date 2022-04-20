using UnityEngine;
using UnityEngine.AI;

namespace Motor {
    [RequireComponent(typeof(CharacterController), typeof(NavMeshAgent))]
    public class PlayerMotor : MonoBehaviour, IMotor {
        [SerializeField] private float movementSpeed = 5.0f;
        [SerializeField] private CharacterController m_controller;
        [SerializeField] private NavMeshAgent m_agent;
        
        private void Awake() {
            m_controller = GetComponent<CharacterController>();
            m_agent = GetComponent<NavMeshAgent>();
            m_controller.center = new Vector3(0, 1.08f, 0);
        }

        public void Move(Vector3 movement) {
            //m_controller.Move(movement * movementSpeed * Time.deltaTime);
            m_agent.Move(movement * Time.deltaTime * movementSpeed);
        }
    }
}
