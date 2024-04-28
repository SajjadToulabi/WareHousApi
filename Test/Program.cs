class user
{
    public string Name { get; set; }
    public string NamFamilye { get; set; }
}
 abstract class AbestractuserReposirory
{
    public string addres { get; set; }
    public abstract string addres2 { get; set; }
    public abstract void creat(user user);
    public void delete(user user)
    {
        Console.WriteLine("sajjad toulabi");
    }
    public virtual void update(user user)
    {

    }
}
