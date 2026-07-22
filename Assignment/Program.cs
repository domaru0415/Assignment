namespace Assignment_01
{
    internal class Program
    {
        static void Main()
        {
            string strname;
            float hp, mp, attack, defense;

            Console.WriteLine("=======================\n플레이어 데이터 입력\n=======================");

            while (true)
            {
                Console.Write("플레이어 이름 : ");
                strname = Console.ReadLine()!;
                strname = strname.Replace(" ", "");

                if (strname.Length <= 3)
                {
                    Console.WriteLine("이름은 3자를 초과해야 합니다. 다시 입력해주세요.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("hp, mp : ");
                string strhpmp = Console.ReadLine()!;
                strhpmp = strhpmp.Replace(" ", "");

                string[] hpmpArr = strhpmp.Split(',');
                hp = float.Parse(hpmpArr[0]);
                mp = float.Parse(hpmpArr[1]);

                if (hp < 50 || mp < 40)
                {
                    Console.WriteLine("hp는 50 이상, mp는 40 이상이어야 합니다. 다시 입력해주세요.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("공격력, 방어력 : ");
                string stratkdef = Console.ReadLine()!;
                stratkdef = stratkdef.Replace(" ", "");

                string[] atkdefArr = stratkdef.Split(',');
                attack = float.Parse(atkdefArr[0]);
                defense = float.Parse(atkdefArr[1]);

                if (attack < 15 || defense < 5)
                {
                    Console.WriteLine("공격력은 15 이상, 방어력은 5 이상이어야 합니다. 다시 입력해주세요.");
                    continue;
                }

                break;
            }

            Player player = new Player(strname, hp, mp, attack, defense);

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine($"{player.name}의 상태창");
            Console.WriteLine("=======================");
            Console.WriteLine($"hp : {player.hp}, mp : {player.mp}, 공격력 : {player.attack}, 방어력 : {player.defense}");
            Console.WriteLine("=======================");

            // 포션 및 쿠폰 지급
            int hpPotion = 3;
            int mpPotion = 3;
            int attackCoupon = 2;
            int defenseCoupon = 3;

            Console.WriteLine();
            Console.WriteLine($"hp 포션 {hpPotion}개, mp 포션 {mpPotion}개를 지급했습니다.");
            Console.WriteLine($"공격력 up 쿠폰 {attackCoupon}개, 방어력 up 쿠폰 {defenseCoupon}개를 지급했습니다.");

            bool bGameStart = false;

            while(bGameStart == false)
            {
                Console.WriteLine("=======================");
                Console.WriteLine($"< {player.name} 강화 >");
                Console.WriteLine("1. hp up");
                Console.WriteLine("2. mp up");
                Console.WriteLine("3. 공격력 2배");
                Console.WriteLine("4. 방어력 2배");
                Console.WriteLine("5. 능력치 보기");
                Console.WriteLine("0. 게임시작");
                Console.WriteLine("=======================");
                Console.Write("메뉴를 선택하세요 : ");

                int select = int.Parse(Console.ReadLine()!);

                switch (select)
                {
                    case 1:
                        if(hpPotion <= 0)
                        {
                            Console.WriteLine("포션이 부족합니다.");
                        }
                        else
                        {
                            player.IncreaseHP(20);
                            hpPotion--;
                            Console.WriteLine($"hp가 20 증가했습니다(hp 포션 -1 -> 남은포션 {hpPotion}개)");
                        }
                        break;
                    case 2:
                        if (mpPotion <= 0)
                        {
                            Console.WriteLine("포션이 부족합니다.");
                        }
                        else
                        {
                            player.IncreaseMP(20);
                            mpPotion--;
                            Console.WriteLine($"mp가 20 증가했습니다(mp 포션 -1 -> 남은포션 {mpPotion}개)");
                        }
                        break;
                    case 3:
                        if(attackCoupon <= 0)
                        {
                            Console.WriteLine("쿠폰이 부족합니다.");
                        }
                        else
                        {
                            player.DoubleAttack();
                            attackCoupon--;
                            Console.WriteLine("공격력이 2배 증가했습니다.");
                        }
                        break;
                    case 4:
                        if (defenseCoupon <= 0)
                        {
                            Console.WriteLine("쿠폰이 부족합니다.");
                        }
                        else
                        {
                            player.DoubleDefense();
                            defenseCoupon--;
                            Console.WriteLine("방어력이 2배 증가했습니다.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("=======================");
                        Console.WriteLine($"{player.name}의 상태창");
                        Console.WriteLine("=======================");
                        Console.WriteLine($"hp : {player.hp}, mp : {player.mp}, 공격력 : {player.attack}, 방어력 : {player.defense}");
                        Console.WriteLine("=======================");
                        break;
                    case 0:
                        bGameStart = true;
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }// 쿠폰 메인
            Console.WriteLine("=======================");
            Console.WriteLine("Game Start!!");
            Console.WriteLine("=======================");
        }
    }
}