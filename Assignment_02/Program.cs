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
        }
    }
}