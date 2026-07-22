class Player
{
    public string name { get; protected set; }
    public float hp { get; protected set; }
    public float mp { get; protected set; }
    public float attack { get; protected set; }
    public float defense { get; protected set; }

    public Player(string name, float hp, float mp, float attack, float defense)
    {
        this.name = name;
        this.hp = hp;
        this.mp = mp;
        this.attack = attack;
        this.defense = defense;
    }

    public void IncreaseHP(float amount)
    {
        hp += amount;
    }

    public void IncreaseMP(float amount)
    {
        mp += amount;
    }

    public void DoubleAttack()
    {
        attack *= 2;
    }

    public void DoubleDefense()
    {
        defense *= 2;
    }
}