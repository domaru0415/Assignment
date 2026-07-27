class Player
{
    private string name, hp, mp, attack, defense;
    public string name 
    {
        get
        {
            return name;
            return hp;
            return mp;
            return attack;
            return defense;
        }
        set
        {
            name = value;
            hp = value;
            mp = value;
            attack = value;
            defense = value;
        } 
    }

    public Player(string name, float hp, float mp, float attack, float defense)
    {
        this.name = name;
        this.hp = hp;
        this.mp = mp;
        this.attack = attack;
        this.defense = defense;
    }
}