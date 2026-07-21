class Player
{
    public string Name { get; protected set; }
    public float HP { get; protected set; }
    public float MP { get; protected set; }
    public float attack {  get; protected set; }
    public float defense { get; protected set; }

    public Player(string name, float hp, float mp, float attack, float defense)
    {
        Name = name;
        HP = hp;
        MP = mp;
        this.attack = attack;
        this.defense = defense;
    }
}