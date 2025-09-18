using UnityEngine;
namespace Method
{
    public class Monster
    {
        //필드
        //정적멤버 변수: 단 하나만 존재, 공유
        //생성된 몬스터의 갯수
        public static int MonsterCount = 0;

        public int hp;  //체력
        public int atk; //공격력

        //생성자
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }

        //데미지를 입는 함수 - 매개변수로 들어온 데미지량 만큼 hp가 감산된다
        public void TakeDamage(int damage)
        {
            hp -= damage;
        }

    }
}