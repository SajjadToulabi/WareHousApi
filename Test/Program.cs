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

    }
    public virtual void update(user user)
    {

    }
}
public class Ss:AbestractuserReposirory 
{
    public override string addres2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void creat(user user)
    {
        throw new NotImplementedException();
    }

    public override void update(user user)
    {
        base.update(user);
    }
}