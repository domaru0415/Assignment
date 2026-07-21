namespace Assignment_01
{
    internal class Program
    {
        static void Main()
        {
            string name;
            float hp;
            float mp;
            float attack;
            float defense;

            Console.WriteLine("=======================\n플레이어 데이터 입력\n=======================");

            Console.Write("플레이어 이름 :");
            string strname = Console.ReadLine()!;

            Console.Write("hp, mp :");
            string strhpmp = Console.ReadLine()!;

            Console.Write("공격력, 방어력 :");
            string stratkdef = Console.ReadLine()!;

            strname = strname.Replace(" ", "");
            strhpmp = strhpmp.Replace(" ", "");
            stratkdef = stratkdef.Replace(" ", "");

            string[] hpmparr = strhpmp.Split(',');
            string[] atkdefarr = stratkdef.Split(",");

            name = strname;
            hp = float.Parse(hpmparr[0]);
            mp = float.Parse(hpmparr[1]);
            attack = float.Parse(atkdefarr[0]);
            defense = float.Parse(atkdefarr[1]);

            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine($"{name}의 상태창");
            Console.WriteLine("=======================");
            Console.WriteLine($"HP : {hp}, MP : {mp}, 공격력 : {attack}, 방어력 : {defense}");
            Console.WriteLine("=======================");
        }
    }
}