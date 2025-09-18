using UnityEngine;
namespace Method
{
    public class MethodRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            //몬스터 생성 
            Monster monster1 = new Monster(100, 10);
            Monster.MonsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.MonsterCount++;

            //전투
            //MonsterBattle(monster1 , monster2);
            //MonsterBattle(monster2 , monster1);
            monster2.TakeDamage(monster1.atk);
            monster1.TakeDamage(monster2.atk);

            //UI
            Debug.Log($"monster1 hp:{monster1.hp}, atk: {monster1.atk}");
            Debug.Log($"monster2 hp:{monster2.hp}, atk: {monster2.atk}");
            Debug.Log($"Monster Count: {Monster.MonsterCount}");


        }
        //전투하는 함수, 공방식 : 체력 -= 공격력
        //매개변수로 공격하는 몬스터와 방어하는 몬스터를 입력받아 공방식 적용

        void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            //공방식
            defMonster.hp -= atkMonster.atk;
        }
    }
}
