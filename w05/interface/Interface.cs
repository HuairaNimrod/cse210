public interface IAnimal
{
    string Onomatopoeia();
}

public class Dog : IAnimal
{
    private string sound = "bark";

    public string Onomatopoeia()
    {
        return sound;
    }
}

public class Cat : IAnimal
{
    private string sound_a = "miaow";
    private string sound_b = "prrrup";

    public string Onomatopoeia()
    {

        string sounds = sound_a +", "+ sound_b;
        return sounds;
    }
}